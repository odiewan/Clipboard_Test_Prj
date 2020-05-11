
Imports System.Drawing.Imaging

Public Class Form1

  Dim cbData As IDataObject = Clipboard.GetDataObject()
  Dim iCount As Integer
  Dim copyCount As Integer
  Dim cboBufferList As List(Of cbObject)
  Dim cboUniqueList As List(Of cbObject)
  Dim coUnique As Collection
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
    cboUniqueList = New List(Of cbObject)
    coUnique = New Collection
    currentCBO = New cbObject("")
    tmrEnable = True
    Timer1.Enabled = tmrEnable
    cbxTmrEn.Checked = tmrEnable
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub updateUniqueLbx()

    lbxUniqueBuffer.Items.Clear()


    For Each cbObj As cbObject In cboUniqueList
      lbxUniqueBuffer.Items.Add(cbObj.WrappedName & " <" & cbObj.Count & ">")
    Next

  End Sub


  '----------------------------------------------------------------------------
  Private Function procNewCBData() As Integer

    Dim retVal As Integer
    Dim cbChanged As Boolean = False
    Dim cbDupCnt As Integer = 0
    Dim cbContent As String = My.Computer.Clipboard.GetText()
    Static cbContentOld As String = ""

    If cbContent <> "" Then
      'AddMsg("Not empty")
      If cbContent <> cbContentOld Then
        If System.IO.File.Exists("C:\Users\Odie\Music\Sounds\Camera Shutter Click.wav") Then
          My.Computer.Audio.Play("C:\Users\Odie\Music\Sounds\Camera Shutter Click.wav")
        Else
          My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If

        AddMsg("New: Look for duplicates")
        cbDupCnt = 0
        For Each cbObj As cbObject In cboBufferList
          If cbContent = cbObj.Name Then
            cbObj.cboIncCount()
            cbDupCnt += 1

            AddMsg("Duplicate found:" & cbObj.Count)
          Else
            AddMsg("New item")

          End If

        Next

        AddMsg("New CB content")

        currentCBO = New cbObject(cbContent)
        If cbDupCnt = 0 Then
          AddMsg("Unique CB content: add to ranking list")
          cboUniqueList.Insert(0, currentCBO)
          coUnique.Add(currentCBO)


        Else
          AddMsg("Not unique: Don't add, only increment")


        End If

        cboBufferList.Insert(0, currentCBO)

        lbxClipboardBuffer.Items.Insert(0, currentCBO.WrappedName)

        lblCBContents.Text = currentCBO.ShortName

        If currentCBO.Type = cbObject.CboType.LINK Then
          lbxLinks.Items.Insert(0, currentCBO.Name)
        End If


        copyCount += 1
        tsslCopyCount.Text = "Copy Count:" & copyCount
        tsslCOCout.Text = "CO Count:" & coUnique.Count
        retVal = 1
        updateUniqueLbx()
      Else
        'AddMsg("nothing new")
        retVal = 0
      End If
    Else
      retVal = 0
    End If
    cbContentOld = cbContent

    Return retVal
  End Function

  '----------------------------------------------------------------------------
  Private Sub getClipboardContent()
    Static ntCnt As Integer = 0
    Static typeStr As String = "NA"

    If My.Computer.Clipboard.ContainsFileDropList() Then
      tsslPollStat.Text = "FileDropList"
    ElseIf My.Computer.Clipboard.ContainsAudio() Then
      tsslPollStat.Text = "Audio"

    ElseIf My.Computer.Clipboard.ContainsImage() Then
      tsslPollStat.Text = "Image"
    ElseIf My.Computer.Clipboard.ContainsText() Then

      tsslPollStat.Text = "Text"
      If procNewCBData() Then
        tsslCmd.Text = currentCBO.StatMsg
        'Else
        '  tsslCmd.Text = "--:"
      End If
    ElseIf My.Computer.Clipboard.ContainsData(DataFormats.UnicodeText) Then
      tsslPollStat.Text = "Data"

    Else
      tsslPollStat.Text = "Unknown"

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
    lbxUniqueBuffer.Items.Clear()
    lbxLinks.Items.Clear()
    cboBufferList.Clear()
    cboUniqueList.Clear()
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
    Dim idx As Integer = sender.SelectedIndex

    AddMsg("s")
    AddMsg("Get item data")
    extractCBData(idx)

    assignCB()
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub btnClearClipboard_Click(sender As Object, e As EventArgs) Handles btnClearClipboard.Click
    AddMsg("Clear Clipboard")
    My.Computer.Clipboard.Clear()
    lblCBContents.Text = "<empty>"
    lbxUniqueBuffer.Text = "<empty>"
    lbxLinks.Text = "<empty>"
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

  Private Sub lblCBContents_MouseHover(sender As Object, e As EventArgs) Handles lblCBContents.MouseHover
    ToolTip1.SetToolTip(lbxClipboardBuffer, currentCBO.Name)
  End Sub

  '----------------------------------------------------------------------------
  '-- DESC: Displays contens of clipboard buffer item to inspect window
  '--
  '----------------------------------------------------------------------------
  Private Sub lbxUniqueBuffer_MouseClick(sender As Object, e As MouseEventArgs) Handles lbxUniqueBuffer.MouseClick
    Dim idx As Integer = lbxUniqueBuffer.SelectedIndex

    AddMsg("s")
    AddMsg("Get clipboard buffer item data")
    extractCBData(idx)

    If currentCBO.Name <> "" Then
      AddMsg("Copy clipboard buffer item to inspect tab")
      tbxInspect.Text = currentCBO.Name

    End If
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_MouseClick(sender As Object, e As MouseEventArgs) Handles lbxClipboardBuffer.MouseClick
    Dim idx As Integer = lbxClipboardBuffer.SelectedIndex

    AddMsg("s")
    AddMsg("Get clipboard buffer item data")
    extractCBData(idx)

    If currentCBO.Name <> "" Then
      AddMsg("Copy clipboard buffer item to inspect tab")
      tbxInspect.Text = currentCBO.Name

    End If
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub assignCB()
    If currentCBO.Name <> "" Then
      AddMsg("Assign the CB to the dbl clicked item data")
      My.Computer.Clipboard.SetText(currentCBO.Name)
      tsslCmd.Text = currentCBO.Name
      lblCBContents.Text = currentCBO.ShortName
    End If
  End Sub


  '----------------------------------------------------------------------------
  Private Sub lbxUniqueBuffer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.SelectedIndexChanged, tsmiCopyToClipboard.Click
    Dim idx As Integer = lbxClipboardBuffer.SelectedIndex

    AddMsg("Get item data")
    If idx >= 0 Then
      AddMsg("Get CBO index")
      currentCBO = cboBufferList.Item(idx)
      assignCB()

    Else
      AddMsg("Buffer is empty")
    End If

  End Sub


  '----------------------------------------------------------------------------
  Private Sub tsmiCopyToFav01_Click(sender As Object, e As EventArgs) Handles tsmiCopyToFav01.Click
    If lbxClipboardBuffer.SelectedIndex >= 0 Then
      AddMsg("Selected Index:" & lbxClipboardBuffer.SelectedIndex)
    Else
      AddMsg("Invalid index")

    End If
  End Sub

  '----------------------------------------------------------------------------
  Private Sub tsmiCopyToFav02_Click(sender As Object, e As EventArgs) Handles tsmiCopyToFav02.Click
    If lbxClipboardBuffer.SelectedIndex >= 0 Then
      AddMsg("Selected Index:" & lbxClipboardBuffer.SelectedIndex)
    Else
      AddMsg("Invalid index")

    End If
  End Sub

  '----------------------------------------------------------------------------
  Private Sub tsmiCopyToFav03_Click(sender As Object, e As EventArgs) Handles tsmiCopyToFav03.Click
    If lbxClipboardBuffer.SelectedIndex >= 0 Then
      AddMsg("Selected Index:" & lbxClipboardBuffer.SelectedIndex)
    Else
      AddMsg("Invalid index")

    End If
  End Sub

  Private Sub tsmiCopyUToClipboard_Click(sender As Object, e As EventArgs) Handles tsmiCopyUToClipboard.Click, lbxUniqueBuffer.SelectedIndexChanged

  End Sub

  Private Sub tsmiUCopyToFav01_Click(sender As Object, e As EventArgs) Handles tsmiUCopyToFav01.Click
    If lbxClipboardBuffer.SelectedIndex >= 0 Then
      AddMsg("Selected Index:" & lbxUniqueBuffer.SelectedIndex)
    Else
      AddMsg("Invalid index")

    End If
  End Sub

  Private Sub tsmiUCopyToFav02_Click(sender As Object, e As EventArgs) Handles tsmiUCopyToFav02.Click
    If lbxUniqueBuffer.SelectedIndex >= 0 Then
      AddMsg("Selected Index:" & lbxUniqueBuffer.SelectedIndex)
    Else
      AddMsg("Invalid index")

    End If
  End Sub

  Private Sub tsmiUCopyToFav03_Click(sender As Object, e As EventArgs) Handles tsmiUCopyToFav03.Click
    If lbxUniqueBuffer.SelectedIndex >= 0 Then
      AddMsg("Selected Index:" & lbxUniqueBuffer.SelectedIndex)
    Else
      AddMsg("Invalid index")

    End If
  End Sub
End Class