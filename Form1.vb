
Imports System.Drawing.Imaging
Imports System.Net.Mail
Imports System.Net.Sockets
Imports System.Threading

Public Class Form1

  Private cbData As IDataObject = Clipboard.GetDataObject()
  Private iCount As Integer
  Private copyCount As Integer
  Private cboBufferList As List(Of cbObject)
  Private cboUniqueList As List(Of cbObject)
  Private coUnique As Collection
  Private currentCBO As cbObject
  Private favoriteCBO As cbObject

  Private gblTmrEnable As Boolean
  Private gblToEmail00 As String = My.Settings.defaultRx00
  Private gblToEmail01 As String = My.Settings.defaultRx01
  Private gblLinkRecipient As String = "Unspecified"

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
  Private Sub loadSettings()
    gblToEmail00 = My.Settings.defaultRx00
    gblToEmail01 = My.Settings.defaultRx01
  End Sub

  '----------------------------------------------------------------------------
  Private Sub updateSettings()
    My.Settings.defaultRx00 = gblToEmail00
    My.Settings.defaultRx01 = gblToEmail01
    AddMsg("Setting updated")
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
    favoriteCBO = New cbObject("")
    gblTmrEnable = True
    Timer1.Enabled = gblTmrEnable
    cbxTmrEn.Checked = gblTmrEnable
    AddMsg("gblToEmail00:" & gblToEmail00)
    AddMsg("gblToEmail01:" & gblToEmail01)
    cbxEmailTo.Items.Add(gblToEmail00)
    cbxEmailTo.Items.Add(gblToEmail01)

    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub updateUniqueLbx()
    Dim uniqueCount = cboUniqueList.Count
    Dim maxCount As Integer = 0
    Dim count As Integer = 0
    Dim count1 As Integer = 0
    Dim countTmp As Integer = 0
    Dim cboTemp As cbObject
    Dim idx As Integer = 0
    Dim jdx As Integer = 0
    lbxUniqueBuffer.Items.Clear()
    cbxMostFreq.Items.Clear()


    'TODO: Sort unique list
    If uniqueCount > 1 Then
      While jdx < uniqueCount
        For idx = 0 To uniqueCount - 2 Step 1
          count = cboUniqueList.Item(idx).Count
          count1 = cboUniqueList.Item(idx + 1).Count
          If count1 > count Then
            'AddMsg("Jdx:" & jdx & " Idx:" & idx & " swap")
            cboTemp = cboUniqueList.Item(idx + 1)
            cboUniqueList.Item(idx + 1) = cboUniqueList.Item(idx)
            cboUniqueList.Item(idx) = cboTemp
          Else
            'AddMsg("Jdx:" & jdx & " Idx:" & idx & " no swap")

          End If
        Next
        jdx += 1
      End While
      'AddMsg("Done with sort")
    Else

      AddMsg("uniqueCount <= 1")

    End If



    lbxUniqueBuffer.Items.Add("<Count> <Data>")
    idx = 0
    For Each cbObj As cbObject In cboUniqueList
      cbObj.Rank = idx
      lbxUniqueBuffer.Items.Add(" <" & cbObj.Count & ">" & cbObj.WrappedName)
      cbxMostFreq.Items.Add(cbObj.Name)
      idx += 1
    Next
    cbxMostFreq.SelectedIndex = 0
    favoriteCBO = cboUniqueList.Item(0)

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
        updateUniqueLbx()

        lblCBContents.Text = currentCBO.ShortName

        If currentCBO.Type = cbObject.CboType.LINK Then
          lbxLinks.Items.Insert(0, currentCBO.Name)
        End If


        copyCount += 1
        tsslCopyCount.Text = "Copy Count:" & copyCount
        tsslCOCout.Text = "CO Count:" & coUnique.Count
        retVal = 1
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
    If cboBufferList.Count > 0 Then
      AddMsg("Get CBO at index:" & idx)
      currentCBO = cboBufferList.Item(idx)
      AddMsg("CBO:" & currentCBO.ShortName)

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
    gblTmrEnable = cbxTmrEn.Checked

    Timer1.Enabled = gblTmrEnable
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
  Sub createMail(body As String, subj As String)
    AddMsg("s")
    Try
      AddMsg("Create Message")
      Dim newMsg As New MailMessage()
      newMsg.From = New MailAddress("odie@odiesystems.com", "Odie")
      newMsg.To.Add(New MailAddress("odie@odiesystems.com", "Odie"))
      newMsg.Subject = subj
      newMsg.Body = body

      'New MailAddress("suzypeterson@mac.com", "Suzy")

      AddMsg("Create SMTP Client")
      Dim smtpServer As New SmtpClient()
      Dim userState As Object = newMsg
      AddMsg("Create Credentials")
      smtpServer.Credentials = New Net.NetworkCredential("odie@odiesystems.com", "!!Jerome19")

      AddMsg("Set SMTP")
      smtpServer.Port = 587
      smtpServer.Host = "smtp.dreamhost.com"

      AddMsg("Set callback")
      AddHandler smtpServer.SendCompleted, AddressOf sendCompleted
      AddMsg("Sending...")

      smtpServer.SendAsync(newMsg, userState)

      AddMsg("Msg sent asynchronosly")

    Catch ex As Exception
      Console.ForegroundColor = ConsoleColor.Red
      AddMsg("Class -> ClassStorage, Method -> MyContactByMail, Error -> " & ex.Message)
      Console.WriteLine("Class -> ClassStorage, Method -> MyContactByMail, Error -> " & ex.Message)
    End Try


    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub btnFwdLink_Click(sender As Object, e As EventArgs) Handles btnFwdLink.Click
    createMail("This is a test", "Subj: Test")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub sendCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    Dim tmpStr As String
    If e.Cancelled Then
      tmpStr = "Mail send was cancelled"
      AddMsg(tmpStr)
      MsgBox(tmpStr, vbOKOnly, "Error")
    ElseIf e.Error IsNot Nothing Then
      tmpStr = "Mail failed to send:" + e.Error.Message
      AddMsg(tmpStr)
      MsgBox(tmpStr, vbOKOnly, "SMTP Error")
    Else
      tmpStr = "Mail Sent"
      AddMsg(tmpStr)
      MsgBox(tmpStr, vbOKOnly, "Mail Status")
    End If
  End Sub

  Private Sub cbxEmailTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEmailTo.SelectedIndexChanged
    gblLinkRecipient = cbxEmailTo.Items(cbxEmailTo.SelectedIndex)
    AddMsg("Fwd recipient email set to " & gblLinkRecipient)

  End Sub
End Class