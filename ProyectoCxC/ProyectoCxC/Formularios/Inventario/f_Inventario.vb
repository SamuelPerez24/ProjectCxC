Public Class f_Inventario
#Region "Funciones Privadas"
    Private Sub LimpiarTextBoxA()
        tb_CodigoA.Clear()
        tb_DescripcionA.Clear()
        tb_CantidadAlmacenA.Clear()
        tb_CantidadMinimaA.Clear()
        datetp_FechaA.Refresh()
        tb_CostoA.Clear()
        tb_Precio1A.Clear()
        tb_Precio2A.Clear()
        tb_PrecioVentaA.Clear()
        tb_UtilidadA.Clear()
    End Sub
    Private Sub LimpiarTextBoxM()
        tb_CodigoM.Clear()
        tb_DescripcionM.Clear()
        tb_CantidadAlmacenM.Clear()
        tb_CantidadMinimaM.Clear()
        tb_CostoM.Clear()
        tb_Precio1M.Clear()
        tb_Precio2M.Clear()
        tb_PrecioVentaM.Clear()
        tb_UtilidadM.Clear()
    End Sub
#End Region

    Private Sub btn_RetornarA_Click(sender As Object, e As EventArgs) Handles btn_RetornarA.Click
        Me.Hide()
    End Sub

    Private Sub btn_RetornarM_Click(sender As Object, e As EventArgs) Handles btn_RetornarM.Click
        Me.Hide()
    End Sub

    Private Sub btn_SalirE_Click(sender As Object, e As EventArgs) Handles btn_SalirE.Click
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
    End Sub

    Private Sub btn_GuargarA_Click(sender As Object, e As EventArgs) Handles btn_GuargarA.Click
        Try
            Conectar()
            SelectQuery("SELECT inv_IdInventario AS Codigo,inv_Descripcion AS Descripcion,inv_Fecha AS Fecha,inv_Costo AS Costo,inv_Precio1 AS Precio1,inv_Precio2 AS Precio2,inv_PrecioVenta AS PrecioVenta,inv_CantidadAlmacen AS CantidadAlmacen,inv_CantidadMinima AS CantidadMinima,inv_Utilidad AS Utilidad FROM t_Inventaio", "t_Inventario")
            Desconectar()
            Me.dgv_Agregar.DataSource = DS.Tables("t_Inventario")
            Me.dgv_Agregar.Refresh()

            LimpiarTextBoxA()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Dim Sql As String = "INSERT INTO t_Inventario(inv_IdInventario,inv_Descripcion,inv_Fecha,inv_Costo,inv_Precio1,inv_Precio2,inv_PrecioVenta,inv_CantidadAlmacen,inv_CantidadMinima,inv_Utilidad) VALUES ('" + Me.tb_CodigoA.Text + "','" + Me.tb_DescripcionA.Text + "','" + Me.datetp_FechaA.Text + "','" + Me.tb_CostoA.Text + "','" + Me.tb_Precio1A.Text + "','" + Me.tb_Precio2A.Text + "','" + Me.tb_PrecioVentaA.Text + "','" + Me.tb_CantidadAlmacenA.Text + "','" + Me.tb_CantidadMinimaA.Text + "','" + Me.tb_UtilidadA.Text + "')"
        Conectar()
        If (InsertQuery(Sql)) Then
            MsgBox("Registro insertado!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            Me.dgv_Agregar.Refresh()
            LimpiarTextBoxA()
        Else
            MsgBox("Error al tratar de insertar el registro!", MsgBoxStyle.Critical, "ERROR 1402")
        End If
        Desconectar()
    End Sub

    Private Sub f_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conectar()
            SelectQuery("SELECT inv_IdInventario AS Codigo,inv_Descripcion AS Descripcion,inv_Fecha AS Fecha,inv_Costo AS Costo,inv_Precio1 AS Precio1,inv_Precio2 AS Precio2,inv_PrecioVenta AS PrecioVenta,inv_CantidadAlmacen AS CantidadAlmacen,inv_CantidadMinima AS CantidadMinima,inv_Utilidad AS Utilidad FROM t_Inventaio", "t_Inventario")
            Desconectar()
            Me.dgv_Modificar.DataSource = DS.Tables("t_Inventario")
            Me.dgv_Modificar.Refresh()

            LimpiarTextBoxA()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Dim Campos As String = "inv_Descripcion='" + Me.tb_DescripcionM.Text + "', inv_Fecha='" + Me.datetp_FechaM.Text + "', inv_Costo='" + Me.tb_CostoM.Text + "', inv_Precio1='" + Me.tb_Precio1M.Text + "', inv_Precio2='" + Me.tb_Precio2M.Text + "', inv_CantidadAlmacen='" + Me.tb_CantidadAlmacenM.Text + "', inv_CantidadMinima='" + Me.tb_CantidadMinimaM.Text + "', inv_Utilidad='" + Me.tb_UtilidadM.Text + "'"
        Conectar()
        If UpdateQuery("t_Inventario", Campos, "inv_IdInventario='" + Me.tb_CodigoM.Text + "'") Then
            MsgBox("Registro Modificado!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            Me.dgv_Modificar.Refresh()
            LimpiarTextBoxM()
        Else
            MsgBox("Error al tratar de modificar el registro!", MsgBoxStyle.Critical, "ERROR 1403")
        End If
        Desconectar()
    End Sub

    Private Sub btn_GuardarM_Click(sender As Object, e As EventArgs) Handles btn_GuardarM.Click
        '---------------------------------> DGV Modificar  <------------------------------------------
        Try
            Conectar()
            SelectQuery("SELECT inv_IdInventario AS Codigo,inv_Descripcion AS Descripcion,inv_Fecha AS Fecha,inv_Costo AS Costo,inv_Precio1 AS Precio1,inv_Precio2 AS Precio2,inv_PrecioVenta AS PrecioVenta,inv_CantidadAlmacen AS CantidadAlmacen,inv_CantidadMinima AS CantidadMinima,inv_Utilidad AS Utilidad FROM t_Inventaio", "t_Inventario")
            Desconectar()
            Me.dgv_Modificar.DataSource = DS.Tables("t_Inventario")
            Me.dgv_Modificar.Refresh()

            LimpiarTextBoxM()
        Catch ex As Exception
        End Try
        '---------------------------------------------------------------------------------------------
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If DeleteQuery("t_Inventario", "inv_IdInventario='" + Me.tb_CodigoE.Text + "'") Then
            MsgBox("Registro Eliminado correctamente!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            Me.dgv_Eliminar.Refresh()
        Else
            MsgBox("Error al intentar eliminar el registro.", MsgBoxStyle.Critical, "ERROR 1403")
        End If
    End Sub

    Private Sub btn_GuardarE_Click(sender As Object, e As EventArgs) Handles btn_GuardarE.Click
        Try
            Conectar()
            SelectQuery("SELECT inv_IdInventario AS Codigo,inv_Descripcion AS Descripcion,inv_Fecha AS Fecha,inv_Costo AS Costo,inv_Precio1 AS Precio1,inv_Precio2 AS Precio2,inv_PrecioVenta AS PrecioVenta,inv_CantidadAlmacen AS CantidadAlmacen,inv_CantidadMinima AS CantidadMinima,inv_Utilidad AS Utilidad FROM t_Inventaio", "t_Inventario")
            Desconectar()
            Me.dgv_Eliminar.DataSource = DS.Tables("t_Inventario")
            Me.dgv_Eliminar.Refresh()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rb_Codigo_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Codigo.CheckedChanged
        If rb_Codigo.Checked = True Then
            rb_Fecha.Checked = False
            tb_CodigoC.Visible = True
            datetp_FechaC.Visible = True
        End If
    End Sub

    Private Sub rb_Fecha_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Fecha.CheckedChanged
        If rb_Fecha.Checked = True Then
            rb_Codigo.Checked = False
            tb_CodigoC.Visible = False
            datetp_FechaC.Visible = True
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If rb_Codigo.Checked = True Then
            Conectar()
            SelectQuery("SELECT inv_IdInventario AS Codigo,inv_Descripcion AS Descripcion,inv_Fecha AS Fecha,inv_Costo AS Costo,inv_Precio1 AS Precio1,inv_Precio2 AS Precio2,inv_PrecioVenta AS PrecioVenta,inv_CantidadAlmacen AS CantidadAlmacen,inv_CantidadMinima AS CantidadMinima,inv_Utilidad AS Utilidad FROM t_Inventaio WHERE inv_IdInventario='" + Me.tb_CodigoC.Text + "'", "t_Inventario")
            Desconectar()
        End If
        If rb_Fecha.Checked = True Then
            Conectar()
            SelectQuery("SELECT inv_IdInventario AS Codigo,inv_Descripcion AS Descripcion,inv_Fecha AS Fecha,inv_Costo AS Costo,inv_Precio1 AS Precio1,inv_Precio2 AS Precio2,inv_PrecioVenta AS PrecioVenta,inv_CantidadAlmacen AS CantidadAlmacen,inv_CantidadMinima AS CantidadMinima,inv_Utilidad AS Utilidad FROM t_Inventaio WHERE inv_Fecha='" + Me.datetp_FechaC.Text + "'", "t_Inventario")
            Desconectar()
        End If
        dgv_Consultar.Refresh()
        dgv_Consultar.DataSource = DS.Tables("t_Inventario")
    End Sub
End Class