Class MainWindow
    Private Sub HelpDocs(sender As Object, e As RoutedEventArgs)
        System.Diagnostics.Process.Start("explorer.exe", "https://docs.qq.com/doc/DSWt4d1ZObHNud0xR")
    End Sub
    Private Sub SendMail(sender As Object, e As RoutedEventArgs)
        System.Diagnostics.Process.Start("explorer.exe", "mailto:ArtisticCraftOffical@proton.me")
    End Sub
    Private Sub CrashHelp(sender As Object, e As RoutedEventArgs)
        System.Diagnostics.Process.Start("explorer.exe", "https://www.bilibili.com/video/BV1xw41117KD")
    End Sub
End Class
