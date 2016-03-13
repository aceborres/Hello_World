Public Class Form1

    Dim directory As String = My.Application.Info.DirectoryPath

    Private Sub btn_click_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_click.Click
        MsgBox("Hello World")
    End Sub


    Private Sub btn_click_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_click.MouseEnter
        btn_click.BackgroundImage = System.Drawing.Image.FromFile(directory & "\btn_2.png")
    End Sub

    Private Sub btn_click_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_click.MouseLeave
        btn_click.BackgroundImage = System.Drawing.Image.FromFile(directory & "\btn.png")
    End Sub

End Class
