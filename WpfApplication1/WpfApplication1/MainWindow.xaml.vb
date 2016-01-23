Public Class MainWindow

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim panel As New StackPanel()
        panel.Orientation = Orientation.Vertical
        Me.Content = panel

        Dim txtInput As New TextBlock
        txtInput.Text = "Welcome to XAML Tutorial with Vb.Net"
        txtInput.Height = 20
        txtInput.Width = 220
        txtInput.Margin = New Thickness(5)

        panel.Children.Add(txtInput)

        Dim btn As New Button()
        btn.Content = "Ok"
        btn.Width = 60
        btn.Height = 20
        btn.Margin = New Thickness(5)

        panel.Children.Add(btn)
    End Sub


End Class
