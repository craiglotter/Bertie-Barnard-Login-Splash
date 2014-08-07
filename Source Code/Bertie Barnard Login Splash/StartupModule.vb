Module StartupModule
    Sub main(ByVal args() As String)
        Try
            If args.Length > 0 Then
                Dim splash As New Splash_Screen(args(0))
                Application.Run(splash)
            Else
                MsgBox("Usage: <filename.exe> <message.rtf> where message.rtf is the path of the required input message file for the splash screen to display.", MsgBoxStyle.Information, "Incorrect Startup Detected")
            End If
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub
End Module
