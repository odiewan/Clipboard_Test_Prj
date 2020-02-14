Public Class Form1
  Dim cbData As IDataObject = Clipboard.GetDataObject()
  Dim cbText As String = ""
  Dim iCount As Integer = 0
  Dim buffer As IList(Of Object)

  '----------------------------------------------------------------------------
  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    buffer = New List(Of Object)
  End Sub

  '----------------------------------------------------------------------------
  Private Sub getClipboardContent()
    Dim wrappedString As String
    If My.Computer.Clipboard.ContainsAudio() Then
      tsslCmd.Text = "Audio"
    ElseIf My.Computer.Clipboard.ContainsData(DataFormats.Html) Then
      If cbText <> My.Computer.Clipboard.GetText() Then
        cbText = My.Computer.Clipboard.GetText()
        lblCBContents.Text = cbText
        wrappedString = "<" + cbText + ">"
        Dim tmpList As IList(Of Object) = New List(Of Object)({cbText, wrappedString})

        buffer.Insert(0, tmpList)
        lbxClipboardBuffer.Items.Insert(0, wrappedString)
        tsslCmd.Text = "HTML"
      Else
        lblCBContents.Text = "HTML: No change: " + cbText
        tsslCmd.Text = lblCBContents.Text
      End If
    ElseIf My.Computer.Clipboard.ContainsFileDropList() Then
      tsslCmd.Text = "File Drop List"
    ElseIf My.Computer.Clipboard.ContainsText() Then
      If cbText <> My.Computer.Clipboard.GetText() Then
        cbText = My.Computer.Clipboard.GetText()
        lblCBContents.Text = cbText
        wrappedString = "<" + cbText + ">"
        Dim tmpList As IList(Of Object) = New List(Of Object)({cbText, wrappedString})

        buffer.Insert(0, tmpList)
        lbxClipboardBuffer.Items.Insert(0, wrappedString)
        tsslCmd.Text = "Text"
      Else
        lblCBContents.Text = "No change:" + cbText
        tsslCmd.Text = lblCBContents.Text
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
  Private Sub lbxClipboardBuffer_DoubleClick(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.DoubleClick
    Dim idx As Integer = lbxClipboardBuffer.SelectedIndex
    Dim tmpObj = buffer.Item(idx)
    'cbText = buffer.Item(idx).ToString
    Dim n As Integer = 0
    For Each i As Object In tmpObj
      If n = 0 Then
        cbText = i.ToString
      End If

      n += 1
    Next
    If cbText <> "" Then
      My.Computer.Clipboard.SetText(cbText)
      tsslCmd.Text = cbText
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
  Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

  End Sub

  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_MouseHover(sender As Object, e As EventArgs)
    ToolTip1.SetToolTip(lbxClipboardBuffer, cbText)
  End Sub

End Class
