Class MainWindow
    Private Sub Do_SayHello(sender As Object, e As RoutedEventArgs)
        Dim SourceButton = TryCast(sender, Button)
        If SourceButton IsNot Nothing Then
            MsgBox("Hello " & SourceButton.Content.ToString)
        Else
            MsgBox("Hello")

        End If
    End Sub
End Class
