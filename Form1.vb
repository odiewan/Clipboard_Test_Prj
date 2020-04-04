
Public Class Form1
  Dim cbData As IDataObject = Clipboard.GetDataObject()
  Dim iCount As Integer
  Dim copyCount As Integer
  Dim cboBufferList As IList(Of cbObject)
  Dim currentCBO As cbObject
  Dim tmrEnable As Boolean

  '----------------------------------------------------------------------------
  Private Sub AddMsg(msg As String)
    Dim prfx As String
    Dim totMsg As String

    '---Get the method name
    prfx = (New System.Diagnostics.StackTrace).GetFrame(1).GetMethod.Name


    If msg IsNot "" Then

      If msg = "s" Then
        totMsg = prfx + "->Start"

      ElseIf msg = "d" Then
        totMsg = prfx + "->Done"
      Else

        totMsg = prfx + "->" + msg
      End If

    Else
        totMsg = prfx
    End If

    Debug.WriteLine(totMsg)
    lbxConsole.Items.Insert(0, totMsg)
  End Sub


  '----------------------------------------------------------------------------
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    AddMsg("s")
    copyCount = 0
    iCount = 0
    cboBufferList = New List(Of cbObject)
    currentCBO = New cbObject("")
    tmrEnable = True
    Timer1.Enabled = tmrEnable
    cbxTmrEn.Checked = tmrEnable
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Function procNewCBData() As Integer

    Dim retVal As Integer
    Dim cbChanged As Boolean = False
    Dim cbDupCnt As Integer = 0
    Dim cbContentNew As String = My.Computer.Clipboard.GetText()

    If currentCBO.Name <> cbContentNew Then
      AddMsg("Look for duplicates")
      For Each cbObj As cbObject In cboBufferList
        If cbContentNew = cbObj.Name Then
          cbObj.cboIncCount()
          cbDupCnt += 1
          AddMsg("Duplicate found:" & cbObj.Count)
        End If
      Next

      If cbDupCnt = 0 Then
        AddMsg("No duplicates found")
      End If



      AddMsg("New CB content")
      currentCBO = New cbObject(My.Computer.Clipboard.GetText())


      cboBufferList.Insert(0, currentCBO)
      lbxClipboardBuffer.Items.Insert(0, currentCBO.WrappedName)

      lblCBContents.Text = currentCBO.ShortName

      copyCount += 1
      tsslCopyCount.Text = "Copy Count:" & copyCount
      retVal = 1
    Else
      retVal = 0
    End If
    Return retVal
  End Function

  '----------------------------------------------------------------------------
  Private Sub getClipboardContent()


    If My.Computer.Clipboard.ContainsText() Then
      If procNewCBData() Then
        tsslCmd.Text = "Text"
      Else
        tsslCmd.Text = "Text: No change:"
      End If
    ElseIf My.Computer.Clipboard.ContainsData(DataFormats.Html) Then
      If procNewCBData() Then
        tsslCmd.Text = "HTML"
      Else
        tsslCmd.Text = "HTML: No change:"
      End If
    ElseIf My.Computer.Clipboard.ContainsFileDropList() Then
      tsslCmd.Text = "File Drop List"

    End If


  End Sub

  '----------------------------------------------------------------------------
  Private Sub btnGetCB_Click(sender As Object, e As EventArgs)
    AddMsg("s")
    getClipboardContent()
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub hndlClipboardChanged(sender As Object, e As EventArgs) Handles Timer1.Tick
    getClipboardContent()
    iCount += 1
    tsslCount.Text = iCount
  End Sub


  '----------------------------------------------------------------------------
  Private Sub btnClearBuffer_Click(sender As Object, e As EventArgs) Handles btnClearBuffer.Click
    AddMsg("s")
    lbxClipboardBuffer.Items.Clear()
    cboBufferList.Clear()
    lblCBContents.Text = "Clear Buffer"
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  ' Desc: Given the lbx item index, returns the item text
  '----------------------------------------------------------------------------
  Private Sub extractCBData(ByVal idx As Integer)
    AddMsg("s")
    If idx >= 0 Then
      AddMsg("Get CBO index")
      currentCBO = cboBufferList.Item(idx)

    Else
      AddMsg("Buffer is empty")
    End If

    AddMsg("d")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_DoubleClick(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.DoubleClick
    Dim idx As Integer = lbxClipboardBuffer.SelectedIndex

    AddMsg("s")
    AddMsg("Get item data")
    extractCBData(idx)

    If currentCBO.Name <> "" Then
      AddMsg("Assign the CB to the dbl clicked item data")
      My.Computer.Clipboard.SetText(currentCBO.Name)
      tsslCmd.Text = currentCBO.Name
      lblCBContents.Text = currentCBO.ShortName

    End If
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub btnClearClipboard_Click(sender As Object, e As EventArgs) Handles btnClearClipboard.Click
    AddMsg("Clear Clipboard")
    My.Computer.Clipboard.Clear()
    lblCBContents.Text = "<empty>"
    tsslCmd.Text = "Clear Clipboard"
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_MouseHover(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.MouseHover
    ToolTip1.SetToolTip(lblCBContents, currentCBO.Name)
  End Sub

  '----------------------------------------------------------------------------
  Private Sub btnGetCB_Click_1(sender As Object, e As EventArgs) Handles btnGetCB.Click
    AddMsg("s")
    getClipboardContent()
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxTmrEn.CheckedChanged
    AddMsg("s")
    tmrEnable = cbxTmrEn.Checked

    Timer1.Enabled = tmrEnable
    AddMsg("d")
  End Sub

  Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

  End Sub

  Private Sub lblCBContents_MouseHover(sender As Object, e As EventArgs) Handles lblCBContents.MouseHover
    ToolTip1.SetToolTip(lbxClipboardBuffer, currentCBO.Name)
  End Sub
End Class
