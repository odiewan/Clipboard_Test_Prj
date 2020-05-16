Imports System.Net.Mail

Public Class Form1

  Private cbData As IDataObject = Clipboard.GetDataObject()

  Private cbContent As String
  Private iCount As Integer
  Private copyCount As Integer
  Private unkCount As Integer

  Private cboBufferList As List(Of cbObject)
  Private cboUniqueList As List(Of cbObject)
  Private cboFavoriteList As List(Of cbObject)
  Private coUnique As Collection
  Private currentCBO As cbObject
  Private favoriteCBO As cbObject

  Private gblTmrEnable As Boolean

  Private gblCBLock As Boolean

  Private gblToEmailSuzy As MailAddress

  Private gblToEmailOdie As MailAddress
  Private gblFromEmailOdie As MailAddress

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
  Private Sub AddStrVar(var As String)
    Dim varObj As Object = var
    Dim varName As String = NameOf(varObj)
    Dim prfx As String
    Dim totMsg As String

    '---Get the method name
    prfx = (New System.Diagnostics.StackTrace).GetFrame(1).GetMethod.Name
    totMsg = prfx & "->" & varName & ":" & var

    Debug.WriteLine(totMsg)
    lbxConsole.Items.Insert(0, totMsg)

  End Sub


  '----------------------------------------------------------------------------
  Private Sub AddIntVar(var As Integer)
    Dim varObj As Object
    Dim varName As String
    Dim prfx As String
    Dim totMsg As String

    '---Get the method name
    prfx = (New System.Diagnostics.StackTrace).GetFrame(1).GetMethod.Name

    '---Create object with passed argumente
    varObj = var

    '---Get the variable name
    varName = NameOf(varObj)

    '---Assemble the complete method
    totMsg = prfx & "->" & varName & ":" & var

    Debug.WriteLine(totMsg)
    lbxConsole.Items.Insert(0, totMsg)

  End Sub


  '----------------------------------------------------------------------------
  Private Sub loadSettings()
    gblToEmailSuzy = New MailAddress(My.Settings.defaultAdrSuzy.Item(1), My.Settings.defaultAdrSuzy.Item(0))
    gblToEmailOdie = New MailAddress(My.Settings.defaultAdrOdie.Item(1), My.Settings.defaultAdrOdie.Item(0))
    gblFromEmailOdie = New MailAddress(My.Settings.defaultAdrOdie.Item(1), My.Settings.defaultAdrOdie.Item(0))
  End Sub

  '----------------------------------------------------------------------------
  Private Sub updateSettings()
    My.Settings.defaultAdrSuzy.Item(0) = gblToEmailSuzy.Address
    My.Settings.defaultAdrSuzy.Item(1) = gblToEmailSuzy.DisplayName
    My.Settings.defaultAdrOdie.Item(0) = gblToEmailOdie.Address
    My.Settings.defaultAdrOdie.Item(1) = gblToEmailOdie.DisplayName


    AddMsg("Setting updated")
  End Sub
  '----------------------------------------------------------------------------
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    AddMsg("s")
    AddStrVar("VarTest")

    AddIntVar("121")
    copyCount = 0
    unkCount = 0
    iCount = 0
    cbContent = ""
    cboBufferList = New List(Of cbObject)
    cboUniqueList = New List(Of cbObject)
    cboFavoriteList = New List(Of cbObject)
    coUnique = New Collection
    currentCBO = New cbObject("")
    favoriteCBO = New cbObject("")
    gblTmrEnable = True
    gblCBLock = False
    Timer1.Enabled = gblTmrEnable
    cbxTmrEn.Checked = gblTmrEnable
    loadSettings()
    cbxEmailTo.Items.Add(gblToEmailSuzy)
    cbxEmailTo.Items.Add(gblToEmailOdie)


    AddMsg("d")
  End Sub

  Private Sub assignCB()
    AddMsg("s")
    gblCBLock = True
    My.Computer.Clipboard.SetText(currentCBO.Name)

    AddMsg("d")
  End Sub

  Private Sub updateGui()


    lblCBContents.Text = currentCBO.ShortName

    tsslCopyCount.Text = "Copy Count:" & copyCount
    tsslCOCout.Text = "CO Count:" & coUnique.Count

    If lbxLinks.Items.Count > 0 Then
      btnFwdLink.Enabled = True
      cbxEmailTo.Enabled = True
    Else
      btnFwdLink.Enabled = False
      cbxEmailTo.Enabled = False

    End If
  End Sub

  '----------------------------------------------------------------------------

  Private Sub updateBufferLbx()
    Dim idx As Integer = 0

    lbxClipboardBuffer.Items.Clear()
    idx = 0
    For Each cbObj As cbObject In cboBufferList
      cbObj.Rank = idx
      lbxClipboardBuffer.Items.Add(cbObj.WrappedName)
      cbxMostFreq.Items.Add(cbObj.Name)
      idx += 1
    Next

  End Sub

  '----------------------------------------------------------------------------
  Private Sub updateUniqueLbx()
    Dim cboListCount = cboUniqueList.Count

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
    If cboListCount > 1 Then
      While jdx < cboListCount
        For idx = 0 To cboListCount - 2 Step 1

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

      AddMsg("cboListCount <= 1")
    End If


    idx = 0
    For Each cbObj As cbObject In cboUniqueList
      cbObj.Rank = idx
      lbxUniqueBuffer.Items.Add(" <" & cbObj.Count & ">" & cbObj.WrappedName)
      cbxMostFreq.Items.Add(cbObj.Name)
      idx += 1
    Next
    'favoriteCBO = cboUniqueList.Item(0)


  End Sub


  Private Sub updateBufferList()
    cboBufferList.Insert(0, currentCBO)
    updateBufferLbx()

  End Sub

  Private Sub updateUniqueList()
    Dim cbDupCnt As Integer = 0

    AddMsg("New: Look for duplicates")
    For Each cbObj As cbObject In cboUniqueList
      If cbContent = cbObj.Name Then
        cbObj.cboIncCount()
        cbDupCnt += 1

        AddMsg("Duplicate found:" & cbObj.Count)
      End If
    Next

    If cbDupCnt = 0 Then
      cboUniqueList.Insert(0, currentCBO)
      coUnique.Add(currentCBO)
    End If


    updateUniqueLbx()
  End Sub

  Private Sub updateLinkList()
    If currentCBO.Type = cbObject.CboType.LINK Then
      lbxLinks.Items.Insert(0, currentCBO.Name)
    End If

  End Sub

  '----------------------------------------------------------------------------
  Private Function procNewCBData() As Integer

    Dim retVal As Integer
    Dim cbChanged As Boolean = False

    cbContent = My.Computer.Clipboard.GetText()
    Static cbContentOld As String = ""

    If cbContent <> "" Then
      'AddMsg("Not empty")
      If cbContent <> cbContentOld And gblCBLock = False Then
        If System.IO.File.Exists("C:\Users\Odie\Music\Sounds\Camera Shutter Click.wav") Then
          My.Computer.Audio.Play("C:\Users\Odie\Music\Sounds\Camera Shutter Click.wav")
        Else
          My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If


        AddMsg("New CB content")

        currentCBO = New cbObject(cbContent)

        updateBufferList()
        updateUniqueList()
        updateLinkList()


        copyCount += 1
        retVal = 1


        updateGui()
        'gblCBLock = False

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

    If My.Computer.Clipboard.ContainsText() Then

      tsslPollStat.Text = "Text"
      If procNewCBData() Then
        tsslCmd.Text = currentCBO.StatMsg
        'Else
        '  tsslCmd.Text = "--:"
      End If
    ElseIf My.Computer.Clipboard.ContainsAudio() Then
      tsslPollStat.Text = "Audio"

    ElseIf My.Computer.Clipboard.ContainsImage() Then
      tsslPollStat.Text = "Image"
    ElseIf My.Computer.Clipboard.ContainsData(DataFormats.UnicodeText) Then
      tsslPollStat.Text = "Data"

    Else
      unkCount += 1
      tsslPollStat.Text = "Unknown" & unkCount

    End If


  End Sub

  '----------------------------------------------------------------------------
  Private Sub btnGetCB_Click(sender As Object, e As EventArgs)
    AddMsg("s")
    getClipboardContent()
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub hndlClipboardChanged(sender As Object, e As EventArgs) Handles Timer1.Tick, lbxClipboardBuffer.MouseHover
    getClipboardContent()
    iCount += 1
    tsslCount.Text = iCount

    gblCBLock = False
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
  Private Sub extractCBData(ByRef cboList As List(Of cbObject), ByVal idx As Integer)
    AddMsg("s")

    If idx > -1 And idx < cboList.Count Then
      AddMsg("Get CBO at index:" & idx)
      currentCBO = cboList.Item(idx)
      assignCB()

      AddMsg("CBO:" & currentCBO.ShortName)

    Else
      AddMsg("Buffer is empty")
    End If

    AddMsg("d")
  End Sub

  Private Sub setCBData(ByRef cboList As List(Of cbObject), ByVal idx As Integer)
    AddMsg("s")
    AddMsg("Get clipboard buffer item data")
    extractCBData(cboList, idx)

    If currentCBO.Name <> "" Then
      AddMsg("Copy clipboard buffer item to inspect tab")
      tbxInspect.Text = currentCBO.Name

    End If
    updateGui()
    AddMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_DoubleClick(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.DoubleClick
    Dim idx As Integer = sender.SelectedIndex

    setCBData(cboBufferList, idx)
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
  Private Sub lbxClipboardBuffer_MouseHover(sender As Object, e As EventArgs)
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
  Private Sub lbxUniqueBuffer_MouseClick(sender As Object, e As MouseEventArgs)
    Dim idx As Integer = lbxUniqueBuffer.SelectedIndex

    setCBData(cboUniqueList, idx)
  End Sub

  '----------------------------------------------------------------------------
  Sub createMail(body As String, subj As String)
    AddMsg("s")
    Try
      AddMsg("Create Message")
      Dim newMsg As New MailMessage()
      newMsg.From = gblFromEmailOdie
      newMsg.To.Add(gblToEmailOdie)
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

  ''----------------------------------------------------------------------------
  'Private Sub btnFwdLink_Click(sender As Object, e As EventArgs) Handles btnFwdLink.Click

  '  'createMail("This is a test", "Subj: Test")

  '  createMail(lbxLinks.Items(0).ToString, "Send a link")
  'End Sub

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

  'Private Sub cbxEmailTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEmailTo.SelectedIndexChanged
  '  gblLinkRecipient = cbxEmailTo.Items(cbxEmailTo.SelectedIndex)
  '  AddMsg("Fwd recipient email set to " & gblLinkRecipient)

  'End Sub

  Private Sub lbxLinks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxLinks.SelectedIndexChanged

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
  Private Sub btnFwdLink_Click(sender As Object, e As EventArgs) Handles btnFwdLink.Click


    'createMail("This is a test", "Subj: Test")

    createMail(lbxLinks.Items(0).ToString, "Send a link")
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



  Private Sub lbxUniqueBuffer_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbxUniqueBuffer.MouseDoubleClick
    Dim idx As Integer = sender.SelectedIndex
    gblCBLock = True
    setCBData(cboBufferList, idx)
  End Sub


  ''----------------------------------------------------------------------------
  'Private Sub tsmiCopyToFav01_Click(sender As Object, e As EventArgs) Handles tsmiCopyToFav01.Click
  '  If lbxClipboardBuffer.SelectedIndex >= 0 Then
  '    AddMsg("Selected Index:" & lbxClipboardBuffer.SelectedIndex)
  '  Else
  '    AddMsg("Invalid index")

  '  End If
  'End Sub

  ''----------------------------------------------------------------------------
  'Private Sub tsmiCopyToFav02_Click(sender As Object, e As EventArgs) Handles tsmiCopyToFav02.Click
  '  If lbxClipboardBuffer.SelectedIndex >= 0 Then
  '    AddMsg("Selected Index:" & lbxClipboardBuffer.SelectedIndex)
  '  Else
  '    AddMsg("Invalid index")

  '  End If
  'End Sub

  ''----------------------------------------------------------------------------
  'Private Sub tsmiCopyToFav03_Click(sender As Object, e As EventArgs) Handles tsmiCopyToFav03.Click
  '  If lbxClipboardBuffer.SelectedIndex >= 0 Then
  '    AddMsg("Selected Index:" & lbxClipboardBuffer.SelectedIndex)
  '  Else
  '    AddMsg("Invalid index")

  '  End If
  'End Sub

  'Private Sub tsmiCopyUToClipboard_Click(sender As Object, e As EventArgs) Handles tsmiCopyUToClipboard.Click, lbxUniqueBuffer.SelectedIndexChanged

  'End Sub

  'Private Sub tsmiUCopyToFav01_Click(sender As Object, e As EventArgs) Handles tsmiUCopyToFav01.Click
  '  If lbxClipboardBuffer.SelectedIndex >= 0 Then
  '    AddMsg("Selected Index:" & lbxUniqueBuffer.SelectedIndex)
  '  Else
  '    AddMsg("Invalid index")

  '  End If
  'End Sub

  'Private Sub tsmiUCopyToFav02_Click(sender As Object, e As EventArgs) Handles tsmiUCopyToFav02.Click
  '  If lbxUniqueBuffer.SelectedIndex >= 0 Then
  '    AddMsg("Selected Index:" & lbxUniqueBuffer.SelectedIndex)
  '  Else
  '    AddMsg("Invalid index")

  '  End If
  'End Sub

  'Private Sub tsmiUCopyToFav03_Click(sender As Object, e As EventArgs) Handles tsmiUCopyToFav03.Click
  '  If lbxUniqueBuffer.SelectedIndex >= 0 Then
  '    AddMsg("Selected Index:" & lbxUniqueBuffer.SelectedIndex)
  '  Else
  '    AddMsg("Invalid index")

  '  End If
  'End Sub

End Class