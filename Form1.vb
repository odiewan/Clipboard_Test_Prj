Public Class Form1
  Dim cbData As IDataObject = Clipboard.GetDataObject()
  Dim cbText As String
  Dim iCount As Integer
  Dim buffer As IList(Of Object)
  Dim tmrEn As Boolean

  '----------------------------------------------------------------------------
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cbText = ""
    iCount = 0
    buffer = New List(Of Object)
    tmrEn = True
    Timer1.Enabled = tmrEn
    cbxTmrEn.Checked = tmrEn
  End Sub

  Private Function procNewCBData() As Integer

    Dim wrappedString As String
    Dim tmpStr As String = My.Computer.Clipboard.GetText()
    If cbText <> tmpStr Then
      cbText = My.Computer.Clipboard.GetText()
      If cbText.Length < 127 Then
        lblCBContents.Text = cbText
      End If

      wrappedString = "<" + cbText + ">"

      Dim tmpList As IList(Of Object) = New List(Of Object)({cbText, wrappedString})

      buffer.Insert(0, tmpList)
      lbxClipboardBuffer.Items.Insert(0, wrappedString)

      Return 1
    Else
      Return 0
    End If


  End Function

  '----------------------------------------------------------------------------
  Private Sub getClipboardContent()
    If My.Computer.Clipboard.ContainsAudio() Then
      tsslCmd.Text = "Audio"
    ElseIf My.Computer.Clipboard.ContainsData(DataFormats.Html) Then
      If procNewCBData() Then
        tsslCmd.Text = "HTML"
      Else
        tsslCmd.Text = "HTML: No change:"
      End If
    ElseIf My.Computer.Clipboard.ContainsFileDropList() Then
      tsslCmd.Text = "File Drop List"
    ElseIf My.Computer.Clipboard.ContainsText() Then
      If procNewCBData() Then
        tsslCmd.Text = "Text"
      Else
        tsslCmd.Text = "Text: No change:"
      End If

    End If


  End Sub

  '----------------------------------------------------------------------------
  Private Sub btnGetCB_Click(sender As Object, e As EventArgs)
    getClipboardContent()
  End Sub

  '----------------------------------------------------------------------------
  Private Sub hndlClipboardChanged(sender As Object, e As EventArgs) Handles Timer1.Tick
    getClipboardContent()
    iCount += 1
    tsslCount.Text = iCount
  End Sub


  '----------------------------------------------------------------------------
  Private Sub btnClearBuffer_Click(sender As Object, e As EventArgs) Handles btnClearBuffer.Click
    lbxClipboardBuffer.Items.Clear()
    lblCBContents.Text = "Clear Buffer"
    cbText = ""
  End Sub

  '----------------------------------------------------------------------------
  Private Sub extractCBData(ByVal idx As Integer)

    Dim tmpObj = buffer.Item(idx)
    Dim n As Integer = 0
    For Each i As Object In tmpObj
      If n = 0 Then
        cbText = i.ToString
      End If

      n += 1
    Next

  End Sub


  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_DoubleClick(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.DoubleClick
    Dim idx As Integer = lbxClipboardBuffer.SelectedIndex

    extractCBData(idx)

    If cbText <> "" Then
      My.Computer.Clipboard.SetText(cbText)
      If cbText.Length < 127 Then
        tsslCmd.Text = cbText
      End If
    End If

  End Sub

  '----------------------------------------------------------------------------
  Private Sub btnClearClipboard_Click(sender As Object, e As EventArgs) Handles btnClearClipboard.Click
    cbText = ""
    My.Computer.Clipboard.Clear()
    lblCBContents.Text = "<empty>"
    tsslCmd.Text = "Clear Clipboard"
  End Sub

  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_MouseHover(sender As Object, e As EventArgs)
    ToolTip1.SetToolTip(lbxClipboardBuffer, cbText)
  End Sub

  Private Sub btnGetCB_Click_1(sender As Object, e As EventArgs) Handles btnGetCB.Click
    getClipboardContent()
  End Sub

  Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbxTmrEn.CheckedChanged

    tmrEn = cbxTmrEn.Checked

    Timer1.Enabled = tmrEn
  End Sub
End Class
