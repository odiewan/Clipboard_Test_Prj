Public Class Form1
  Dim cbData As IDataObject = Clipboard.GetDataObject()
  Dim cbText As String = ""
  Dim iCount As Integer = 0

  Private Sub getClipboardText()
    If cbText <> My.Computer.Clipboard.GetText() Then
      cbText = My.Computer.Clipboard.GetText()
      lblCBContents.Text = cbText
      lbxClipboardBuffer.Items.Insert(0, cbText)
    Else
      lblCBContents.Text = "No change:" + cbText
    End If

  End Sub


  Private Sub btnGetCB_Click(sender As Object, e As EventArgs) Handles btnGetCB.Click
    getClipboardText()
  End Sub

  Private Sub hndlClipboardChanged(sender As Object, e As EventArgs) Handles Timer1.Tick
    getClipboardText()
    iCount += 1
    tsslCount.Text = iCount
  End Sub

  Private Sub lblCBContents_Click(sender As Object, e As EventArgs) Handles lblCBContents.Click

  End Sub

  Private Sub btnClearBuffer_Click(sender As Object, e As EventArgs) Handles btnClearBuffer.Click
    lbxClipboardBuffer.Items.Clear()
    lblCBContents.Text = "Clear Buffer"
    cbText = ""
  End Sub

  Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles tsslStatus.Click

  End Sub

  Private Sub lbxClipboardBuffer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.SelectedIndexChanged

  End Sub

  Private Sub lbxClipboardBuffer_DoubleClick(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.DoubleClick
    cbText = lbxClipboardBuffer.Text
    If cbText <> "" Then
      My.Computer.Clipboard.SetText(cbText)
      tsslCmd.Text = cbText
    End If

  End Sub
End Class
