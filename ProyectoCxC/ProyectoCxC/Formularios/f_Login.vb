Imports System.Data.SqlClient
Public Class f_Login
    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Try
            'Conectando de la base de datos
            Conectar()
            Dim Com As New SqlCommand("SELECT * FROM t_Login WHERE log_User='" & tb_Username.Text & "' AND log_Password= '" & tb_Password.Text & "' ", Conexion)
            Dim Reader As SqlDataReader
            Reader = Com.ExecuteReader()

            'Se verifica si los datos introducidos por el usuario esten igual con relacion a la base de datos.
            If Reader.HasRows = True Then
                Do While Reader.Read()
                    Cargo = CStr(Reader("log_TipoUser"))
                    MsgBox("Bienvenido Sr. " + tb_Username.Text.Trim(), MsgBoxStyle.Information, "Bienvenida")
                    Me.Hide()
                    f_BackMenuPrincipal.Show()
                Loop
            Else
                Select Case MsgBox("Usuario/Password no registrado!, Por favor introduzca datos validos.", MsgBoxStyle.YesNo, "Credenciales invalidas")
                    Case DialogResult.Yes
                        tb_Username.Clear()
                        tb_Password.Clear()
                    Case DialogResult.No
                        MsgBox("Hasta luego!", MsgBoxStyle.Exclamation, "Credenciales invalidas")
                        Application.Exit()
                End Select
            End If

            'Desconectando de la base de datos.
            Desconectar()

        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos, intentelo de nuevo mas tarde.", MsgBoxStyle.Critical, "ERROR 1400")
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        MsgBox("Hasta pronto!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
        Application.Exit()
    End Sub
End Class