Class MainWindow 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Try
            MessageBox.Show(Me.Label1.Content)
        Catch ex As Exception
        End Try
    End Sub
End Class
