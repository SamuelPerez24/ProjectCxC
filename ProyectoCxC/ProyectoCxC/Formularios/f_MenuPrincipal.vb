Public Class f_MenuPrincipal

    Private Sub f_MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_Usuario2.Text = My.Forms.f_Login.tb_Username.Text.Trim()
        Dim Fecha As DateTime = DateTime.Now
        txt_Fecha2.Text = Fecha.ToString()
        txt_Cargo2.Text = Cargo
    End Sub

    Private Sub btn_Clientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clientes.Click
        f_Clientes.MdiParent = f_BackMenuPrincipal
        f_Clientes.Show()
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_Salir.Click
        Application.Exit()
    End Sub

    Private Sub btn_Inventario_Click(sender As Object, e As EventArgs) Handles btn_Inventario.Click
        f_Inventario.MdiParent = f_BackMenuPrincipal
        f_Inventario.Show()
    End Sub
End Class