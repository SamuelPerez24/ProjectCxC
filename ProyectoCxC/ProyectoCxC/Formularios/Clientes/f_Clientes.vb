Public Class f_Clientes
#Region "Funciones privadas"
    Private Sub ClearTextboxA()
        Me.tb_CiudadA.Clear()
        Me.tb_CodigoA.Clear()
        Me.tb_CorreoA.Clear()
        Me.tb_EstadoA.Clear()
        Me.tb_NombreA.Clear()
        Me.tb_NotaA.Clear()
        Me.tb_PaisA.Clear()
        Me.tb_DireccionA.Clear()
        Me.mtb_TelefonoA.Clear()
        Me.mtb_RNC_A.Clear()
        Me.mtb_CelularA.Clear()
    End Sub
    Private Sub ClearTextboxM()
        Me.tb_CiudadM.Clear()
        Me.tb_CodigoM.Clear()
        Me.tb_CorreoM.Clear()
        Me.tb_EstadoM.Clear()
        Me.tb_NombreM.Clear()
        Me.tb_NotaM.Clear()
        Me.tb_PaisM.Clear()
        Me.tb_DireccionM.Clear()
        Me.mtb_TelefonoM.Clear()
        Me.mtb_RNC_M.Clear()
        Me.mtb_CelularM.Clear()
    End Sub
#End Region

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RetornarA.Click
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_RetornarM.Click
        Me.Hide()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SalirE.Click
        Me.Hide()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        Dim Sql As String = "INSERT INTO t_Clientes(cli_IdCliente,cli_Nombre,cli_Direccion,cli_Telefono,cli_Celular,cli_Ciudad,cli_Estado,cli_Pais,cli_RNC,cli_Correo,cli_Nota) VALUES ('" + Me.tb_CodigoA.Text + "','" + Me.tb_NombreA.Text + "','" + Me.tb_DireccionA.Text + "','" + Me.mtb_TelefonoA.Text + "','" + Me.mtb_CelularA.Text + "','" + Me.tb_CiudadA.Text + "','" + Me.tb_EstadoA.Text + "','" + Me.tb_PaisA.Text + "','" + Me.mtb_RNC_A.Text + "','" + Me.tb_CorreoA.Text + "','" + Me.tb_NotaA.Text + "')"
        Conectar()
        If InsertQuery(Sql) Then
            MsgBox("Registro insertado!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            Me.dgv_Agregar.Refresh()
        Else
            MsgBox("Error al tratar de insertar el registro!", MsgBoxStyle.Critical, "ERROR 1401")
        End If
        Desconectar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuargarA.Click
        Try
            Conectar()
            SelectQuery("SELECT cli_IdCliente AS Codigo,cli_Nombre AS Nombre,cli_Direccion AS Direccion,cli_Telefono AS Telefono,cli_Celular AS Celular,cli_Ciudad AS Ciudad,cli_Estado AS Estado,cli_Pais AS Pais,cli_RNC AS RNC,cli_Correo AS Correo,cli_Nota AS Nota FROM t_Clientes", "t_Clientes")
            Desconectar()
            Me.dgv_Agregar.DataSource = DS.Tables(0)
            Me.dgv_Agregar.Refresh()

            ClearTextboxA()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Dim Campos As String = "cli_Nombre='" + Me.tb_NombreM.Text + "', cli_Direccion='" + Me.tb_DireccionM.Text + "', cli_Telefono='" + Me.mtb_TelefonoM.Text + "', cli_Celular='" + Me.mtb_CelularM.Text + "', cli_Ciudad='" + Me.tb_CiudadM.Text + "', cli_Estado='" + Me.tb_EstadoM.Text + "', cli_Pais='" + Me.tb_PaisM.Text + "', cli_RNC='" + mtb_RNC_M.Text + "', cli_Correo='" + Me.tb_CorreoM.Text + "', cli_Nota='" + Me.tb_NotaM.Text + "'"
        Conectar()
        If UpdateQuery("t_Clientes", Campos, "cli_IdCliente='" + Me.tb_CodigoM.Text + "'") Then
            MsgBox("Registro Modificado!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            Me.dgv_Modificar.Refresh()
        Else
            MsgBox("Error al tratar de modificar el registro!", MsgBoxStyle.Critical, "ERROR 1402")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_GuardarM.Click
        Try
            Conectar()
            SelectQuery("SELECT cli_IdCliente AS Codigo,cli_Nombre AS Nombre,cli_Direccion AS Direccion,cli_Telefono AS Telefono,cli_Celular AS Celular,cli_Ciudad AS Ciudad,cli_Estado AS Estado,cli_Pais AS Pais,cli_RNC AS RNC,cli_Correo AS Correo,cli_Nota AS Nota FROM t_Clientes", "t_Clientes")
            Desconectar()
            Me.dgv_Modificar.DataSource = DS.Tables("t_Clientes")
            Me.dgv_Modificar.Refresh()

            ClearTextboxM()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_GuardarE.Click
        Try
            Conectar()
            SelectQuery("SELECT cli_IdCliente AS Codigo,cli_Nombre AS Nombre,cli_Direccion AS Direccion,cli_Telefono AS Telefono,cli_Celular AS Celular,cli_Ciudad AS Ciudad,cli_Estado AS Estado,cli_Pais AS Pais,cli_RNC AS RNC,cli_Correo AS Correo,cli_Nota AS Nota FROM t_Clientes", "t_Clientes")
            Desconectar()
            Me.dgv_Eliminar.DataSource = DS.Tables("t_Clientes")
            Me.dgv_Eliminar.Refresh()

            Me.tb_CodigoE.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If DeleteQuery("t_Clientes", "cli_IdCliente='" + Me.tb_CodigoE.Text + "'") Then
            MsgBox("Registro Eliminado correctamente!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            Me.dgv_Eliminar.Refresh()
        Else
            MsgBox("Error al intentar eliminar el registro.", MsgBoxStyle.Critical, "ERROR 1402")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If rb_Codigo.Checked = True Then
            Conectar()
            SelectQuery("SELECT cli_IdCliente AS Codigo,cli_Nombre AS Nombre,cli_Direccion AS Direccion,cli_Telefono AS Telefono,cli_Celular AS Celular,cli_Ciudad AS Ciudad,cli_Estado AS Estado,cli_Pais AS Pais,cli_RNC AS RNC,cli_Correo AS Correo,cli_Nota AS Nota FROM t_Clientes WHERE cli_IdCliente='" + tb_CodigoC.Text + "'", "t_Clientes")
            Desconectar()
        End If

        If rb_Nombre.Checked = True Then
            Conectar()
            SelectQuery("SELECT cli_IdCliente AS Codigo,cli_Nombre AS Nombre,cli_Direccion AS Direccion,cli_Telefono AS Telefono,cli_Celular AS Celular,cli_Ciudad AS Ciudad,cli_Estado AS Estado,cli_Pais AS Pais,cli_RNC AS RNC,cli_Correo AS Correo,cli_Nota AS Nota FROM t_Clientes WHERE cli_Nombre='" + tb_NombreC.Text + "'", "t_Clientes")
            Desconectar()
        End If

        If rb_RNC.Checked = True Then
            Conectar()
            SelectQuery("SELECT cli_IdCliente AS Codigo,cli_Nombre AS Nombre,cli_Direccion AS Direccion,cli_Telefono AS Telefono,cli_Celular AS Celular,cli_Ciudad AS Ciudad,cli_Estado AS Estado,cli_Pais AS Pais,cli_RNC AS RNC,cli_Correo AS Correo,cli_Nota AS Nota FROM t_Clientes WHERE cli_RNC='" + mtb_RNC_C.Text + "'", "t_Clientes")
            Desconectar()
        End If

        Me.dgv_Consultar.DataSource = DS.Tables("t_Clientes")
        Me.dgv_Consultar.Refresh()


    End Sub

    Private Sub f_Clientes_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Conectar()
        SelectQuery("SELECT cli_IdCliente AS Codigo,cli_Nombre AS Nombre,cli_Direccion AS Direccion,cli_Telefono AS Telefono,cli_Celular AS Celular,cli_Ciudad AS Ciudad,cli_Estado AS Estado,cli_Pais AS Pais,cli_RNC AS RNC,cli_Correo AS Correo,cli_Nota AS Nota FROM t_Clientes", "t_Clientes")
        Desconectar()
        Me.dgv_Agregar.DataSource = DS.Tables("t_Clientes")
        Me.dgv_Agregar.Refresh()
    End Sub

    Private Sub rb_Codigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Codigo.CheckedChanged
        If rb_Codigo.Checked = True Then
            rb_Nombre.Checked = False
            rb_RNC.Checked = False
            tb_CodigoC.Visible = True
            tb_NombreC.Visible = False
            mtb_RNC_C.Visible = False
            tb_NombreC.Clear()
            mtb_RNC_C.Clear()
            tb_CodigoC.Clear()
        End If
    End Sub

    Private Sub rb_Nombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_Nombre.CheckedChanged
        If rb_Nombre.Checked = True Then
            rb_Codigo.Checked = False
            rb_RNC.Checked = False
            tb_CodigoC.Visible = False
            tb_NombreC.Visible = True
            mtb_RNC_C.Visible = False
            tb_NombreC.Clear()
            mtb_RNC_C.Clear()
            tb_CodigoC.Clear()
        End If
    End Sub

    Private Sub rb_RNC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_RNC.CheckedChanged
        If rb_RNC.Checked = True Then
            rb_Codigo.Checked = False
            rb_Nombre.Checked = False
            mtb_RNC_C.Visible = True
            tb_CodigoC.Visible = False
            tb_NombreC.Visible = False
            tb_NombreC.Clear()
            mtb_RNC_C.Clear()
            tb_CodigoC.Clear()
        End If
    End Sub
End Class