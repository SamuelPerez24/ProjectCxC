Public Class f_BackMenuPrincipal
    'test
    Private Sub btn_Salir_Click(ByVal sender As Object, ByVal e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub f_MenuPrincipal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        f_MenuPrincipal.MdiParent = Me
        f_MenuPrincipal.Show()

    End Sub
End Class