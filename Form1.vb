
Public Class Form1
  Dim cbData As IDataObject = Clipboard.GetDataObject()
  Dim cbContent As String
  Dim iCount As Integer
  Dim cboBuffer As IList(Of cbObject)
  Dim tmrEn As Boolean

  '----------------------------------------------------------------------------
  Private Sub AddMsg(msg As String)
    Dim prfx As String
    Dim totMsg As String

    '---Get the method name
    prfx = (New System.Diagnostics.StackTrace).GetFrame(1).GetMethod.Name


    If msg IsNot "" Then
      totMsg = prfx + "->" + msg

    ElseIf msg = "s" Then
      totMsg = prfx + "->Start"

    ElseIf msg = "d" Then
      totMsg = prfx + "->Done"

    Else
      totMsg = prfx
    End If

    Debug.WriteLine(totMsg)
    lbxConsole.Items.Insert(0, totMsg)
  End Sub


  '----------------------------------------------------------------------------
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    AddMsg("s")
    cbContent = ""
    iCount = 0
    cboBuffer = New List(Of cbObject)
    tmrEn = True
    Timer1.Enabled = tmrEn
    cbxTmrEn.Checked = tmrEn
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Function procNewCBData() As Integer

    Dim wrappedString As String
    Dim retVal As Integer
    Dim cbContentNew As String = My.Computer.Clipboard.GetText()

    If cbContent <> cbContentNew Then
      AddMsg("New CB content")
      cbContent = My.Computer.Clipboard.GetText()
      If cbContent.Length < 127 Then
        lblCBContents.Text = cbContent
      End If

      If cbContent = "" Then
        wrappedString = "<EMPTY>"
      Else
        wrappedString = "<" + cbContent + ">"
      End If

      Dim tmpCBObj As New cbObject(cbContent)



      cboBuffer.Insert(0, tmpCBObj)
      lbxClipboardBuffer.Items.Insert(0, tmpCBObj.WrappedName)

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
    cboBuffer.Clear()
    lblCBContents.Text = "Clear Buffer"
    cbContent = ""
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  ' Desc: Given the lbx item index, returns the item text
  '----------------------------------------------------------------------------
  Private Sub extractCBData(ByVal idx As Integer)
    AddMsg("s")
    AddMsg("Get CBO index")
    Dim tmpCBObj = cboBuffer.Item(idx)

    AddMsg("Copy CBO name (unwrapped) to cbContent")

    cbContent = tmpCBObj.Name


    AddMsg("d")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_DoubleClick(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.DoubleClick
    Dim idx As Integer = lbxClipboardBuffer.SelectedIndex
    Dim tmpName As String
    AddMsg("s")
    AddMsg("Get item data")
    extractCBData(idx)

    If cbContent <> "" Then
      AddMsg("Assign the CB to the dbl clicked item data")
      My.Computer.Clipboard.SetText(cbContent)
      If cbContent.Length < 127 Then
        AddMsg("str < 127 chars")
        tsslCmd.Text = cbContent
        lblCBContents.Text = cbContent
      Else
        AddMsg("str > 127 chars")
        tmpName = Strings.Left(cbContent, 45)
        tsslCmd.Text = tmpName
        lblCBContents.Text = tmpName
      End If
    End If
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub btnClearClipboard_Click(sender As Object, e As EventArgs) Handles btnClearClipboard.Click
    AddMsg("Clear Clipboard")
    cbContent = ""
    My.Computer.Clipboard.Clear()
    lblCBContents.Text = "<empty>"
    tsslCmd.Text = "Clear Clipboard"
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_MouseHover(sender As Object, e As EventArgs)
    AddMsg("s")
    ToolTip1.SetToolTip(lbxClipboardBuffer, cbContent)
    AddMsg("d")
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
    tmrEn = cbxTmrEn.Checked

    Timer1.Enabled = tmrEn
    AddMsg("d")
  End Sub

  Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

  End Sub
End Class
