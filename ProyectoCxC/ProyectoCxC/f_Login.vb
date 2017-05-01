Imports System.Data.SqlClient
Public Class f_Login

    Private Sub f_Login_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

    End Sub

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Try
            'Conectando de la base de datos
            Conectar()
            SelectQuery("SELECT count (*) FROM t_Login WHERE ", "t_Login")
            Desconectar()
        Catch
        End Try
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        MsgBox("Hasta pronto!", MsgBoxStyle.OkOnly, "Despedida")
        f_Back.Close()
    End Sub
End Class