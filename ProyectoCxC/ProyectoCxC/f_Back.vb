Public Class f_Back

    Private Sub f_Back_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f_Login.MdiParent = Me
        f_Login.Show()

    End Sub
End Class
