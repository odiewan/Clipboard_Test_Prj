Module util_logging

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
    'lbxConsole.Items.Insert(0, totMsg)
  End Sub
End Module
