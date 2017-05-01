Public Class f_Facturas
#Region "Funciones privadas"
    Private Sub ClearTextboxA()
        Me.tb_VendedorA.Clear()
        Me.tb_NroFactA.Clear()
        Me.tb_DescuentoA.Clear()
        Me.tb_SubTotalA.Clear()
        Me.tb_NombreClienteA.Clear()
        Me.tb_CodigoClienteA.Clear()
        Me.tb_TotalA.Clear()
        Me.tb_ComentarioA.Clear()
        Me.tb_Precio1A.Clear()
        Me.tb_Precio2A.Clear()
        Me.tb_PrecioVentaA.Clear()
        Me.tb_TotalA.Clear()
    End Sub
    Private Sub ClearTextboxM()
        Me.tb_VendedorM.Clear()
        Me.tb_NroFactM.Clear()
        Me.tb_DescuentoM.Clear()
        Me.tb_SubtotalM.Clear()
        Me.tb_NombreClienteM.Clear()
        Me.tb_CodigoClienteM.Clear()
        Me.tb_TotalM.Clear()
        Me.tb_ComentarioM.Clear()
        Me.tb_Precio1M.Clear()
        Me.tb_Precio2M.Clear()
        Me.tb_PrecioVentaM.Clear()
        Me.tb_TotalM.Clear()
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
        Dim Sql As String = "INSERT INTO t_Facturas(fact_IdFacturas,fact_IdCliente,fact_NombreCliente,fact_FormaPago,fact_Vendedor,fact_Fecha,fact_IdProducto,fact_Producto,fact_Precio1Prod,fact_Precio2Prod,fact_PrecioVentaProd,fact_Descuento,fact_Impuesto,fact_Subtotal,fact_Total,fact_Comentario) VALUES ('" + Me.tb_NroFactA.Text + "','" + Me.tb_CodigoClienteA.Text + "','" + Me.tb_NombreClienteA.Text + "','" + Me.cb_FormaPagoA.Text + "','" + Me.tb_VendedorA.Text + "','" + Me.datetp_FechaA.Text + "','" + Me.tb_CodigoProductoA.Text + "','" + Me.tb_ProductoA.Text + "','" + Me.tb_Precio1A.Text + "','" + Me.tb_Precio2A.Text + "','" + Me.tb_PrecioVentaA.Text + "','" + Me.tb_DescuentoA.Text + "','" + Me.tb_ImpuestoA.Text + "','" + Me.tb_SubTotalA.Text + "','" + Me.tb_TotalA.Text + "','" + Me.tb_ComentarioA.Text + "')"
        Conectar()
        If InsertQuery(Sql) Then
            MsgBox("Registro insertado!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            Me.dgv_Agregar.Refresh()
            ClearTextboxA()
        Else
            MsgBox("Error al tratar de insertar el registro!", MsgBoxStyle.Critical, "ERROR 1404")
        End If
        Desconectar()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuargarA.Click
        Try
            Conectar()
            SelectQuery("SELECT fact_IdFactura AS Nro.Factura,fact_IdCliente AS CodigoCliente,fact_NombreCliente AS NombreCliente,fact_FormaPago AS FormaPago,fact_Vendedor AS Vendedor,fact_Fecha AS Fecha,fact_IdProducto AS CodigoProducto,fact_Producto AS Producto,fact_Precio1Prod AS Precio1,fact_Precio2Prod AS Precio2,fact_PrecioVentaProd AS PrecioVenta, fact_Descuento AS Descuento, fact_Impuesto AS Impuestos, fact_Subtotal AS Sub-Total,fact_Total AS TOTAL, fact_Comentario AS Comentario FROM t_Facturas", "t_Facturas")
            Desconectar()
            Me.dgv_Agregar.DataSource = DS.Tables("t_Facturas")
            Me.dgv_Agregar.Refresh()
            ClearTextboxA()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Dim Campos As String = "fact_IdCliente='" + Me.tb_CodigoClienteM.Text + "', fact_NombreCliente='" + Me.tb_NombreClienteM.Text + "', fact_FormaPago='" + Me.cb_FormaPagoM.Text + "', fact_Vendedor='" + Me.tb_VendedorM.Text + "', fact_Fecha='" + Me.datetp_FechaM.Text + "', fact_IdProducto='" + Me.tb_CodigoProductoM.Text + "', fact_Producto='" + Me.tb_ProductoM.Text + "', fac_Precio1Prod='" + Me.tb_Precio1M.Text + "', fact_Precio2Prod='" + Me.tb_Precio2M.Text + "', fact_PrecioVenta='" + Me.tb_PrecioVentaM.Text + "',fact_Descuento='" + Me.tb_DescuentoM.Text + "', fact_Impuesto='" + Me.tb_ImpuestoM.Text + "',fact_Subtotal='" + Me.tb_SubtotalM.Text + "',fact_Total='" + Me.tb_TotalM.Text + "',fact_Comentario='" + tb_ComentarioM.Text + "'"
        Conectar()
        If UpdateQuery("t_Clientes", Campos, "fact_IdFacturas='" + Me.tb_NroFactM.Text + "'") Then
            MsgBox("Registro Modificado!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            Me.dgv_Modificar.Refresh()
            ClearTextboxM()
        Else
            MsgBox("Error al tratar de modificar el registro!", MsgBoxStyle.Critical, "ERROR 1402")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_GuardarM.Click
        Try
            Conectar()
            SelectQuery("SELECT fact_IdFactura AS Nro.Factura,fact_IdCliente AS CodigoCliente,fact_NombreCliente AS NombreCliente,fact_FormaPago AS FormaPago,fact_Vendedor AS Vendedor,fact_Fecha AS Fecha,fact_IdProducto AS CodigoProducto,fact_Producto AS Producto,fact_Precio1Prod AS Precio1,fact_Precio2Prod AS Precio2,fact_PrecioVentaProd AS PrecioVenta, fact_Descuento AS Descuento, fact_Impuesto AS Impuestos, fact_SubTotal AS Sub-Total,fact_Total AS TOTAL, fact_Comentario AS Comentario FROM t_Facturas", "t_Facturas")
            Desconectar()
            Me.dgv_Modificar.DataSource = DS.Tables("t_Facturas")
            Me.dgv_Modificar.Refresh()

            ClearTextboxM()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_GuardarE.Click
        Try
            Conectar()
            SelectQuery("SELECT fact_IdFactura AS Nro.Factura,fact_IdCliente AS CodigoCliente,fact_NombreCliente AS NombreCliente,fact_FormaPago AS FormaPago,fact_Vendedor AS Vendedor,fact_Fecha AS Fecha,fact_IdProducto AS CodigoProducto,fact_Producto AS Producto,fact_Precio1Prod AS Precio1,fact_Precio2Prod AS Precio2,fact_PrecioVentaProd AS PrecioVenta, fact_Descuento AS Descuento, fact_Impuesto AS Impuestos, fact_Subtotal AS Sub-Total,fact_Total AS TOTAL, fact_Comentario AS Comentario FROM t_Facturas", "t_Facturas")
            Desconectar()
            Me.dgv_Eliminar.DataSource = DS.Tables("t_Facturas")
            Me.dgv_Eliminar.Refresh()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If DeleteQuery("t_Facturas", "fact_IdFacturas='" + Me.tb_NroFactM.Text + "'") Then
            MsgBox("Registro Eliminado correctamente!", MsgBoxStyle.Information, MsgBoxStyle.OkOnly)
            Me.dgv_Eliminar.Refresh()
            ClearTextboxM()
        Else
            MsgBox("Error al intentar eliminar el registro.", MsgBoxStyle.Critical, "ERROR 1403")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If rb_NroFactura.Checked = True Then
            Conectar()
            SelectQuery("SELECT fact_IdFactura AS Nro.Factura,fact_IdCliente AS CodigoCliente,fact_NombreCliente AS NombreCliente,fact_FormaPago AS FormaPago,fact_Vendedor AS Vendedor,fact_Fecha AS Fecha,fact_IdProducto AS CodigoProducto,fact_Producto AS Producto,fact_Precio1Prod AS Precio1,fact_Precio2Prod AS Precio2,fact_PrecioVentaProd AS PrecioVenta, fact_Descuento AS Descuento, fact_Impuesto AS Impuestos, fact_Subtotal AS Sub-Total,fact_Total AS TOTAL, fact_Comentario AS Comentario FROM t_Facturas WHERE fact_IdFacturas='" + Me.tb_NroFactC.Text + "'", "t_Facturas")
            Desconectar()
        End If

        If rb_Fecha.Checked = True Then
            Conectar()
            SelectQuery("SELECT fact_IdFactura AS Nro.Factura,fact_IdCliente AS CodigoCliente,fact_NombreCliente AS NombreCliente,fact_FormaPago AS FormaPago,fact_Vendedor AS Vendedor,fact_Fecha AS Fecha,fact_IdProducto AS CodigoProducto,fact_Producto AS Producto,fact_Precio1Prod AS Precio1,fact_Precio2Prod AS Precio2,fact_PrecioVentaProd AS PrecioVenta, fact_Descuento AS Descuento, fact_Impuesto AS Impuestos, fact_Subtotal AS Sub-Total,fact_Total AS TOTAL, fact_Comentario AS Comentario FROM t_Facturas WHERE fact_Fecha='" + Me.datetp_FechaC.Text + "'", "t_Facturas")
            Desconectar()
        End If

        Me.dgv_Consultar.DataSource = DS.Tables("t_Facturas")
        Me.dgv_Consultar.Refresh()


    End Sub

    Private Sub f_Clientes_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        '-----------------------------------> DGV Modificar <--------------------------------------
        Try
            Conectar()
            SelectQuery("SELECT fact_IdFactura AS Nro.Factura,fact_IdCliente AS CodigoCliente,fact_NombreCliente AS NombreCliente,fact_FormaPago AS FormaPago,fact_Vendedor AS Vendedor,fact_Fecha AS Fecha,fact_IdProducto AS CodigoProducto,fact_Producto AS Producto,fact_Precio1Prod AS Precio1,fact_Precio2Prod AS Precio2,fact_PrecioVentaProd AS PrecioVenta, fact_Descuento AS Descuento, fact_Impuesto AS Impuestos, fact_Subtotal AS Sub-Total,fact_Total AS TOTAL, fact_Comentario AS Comentario FROM t_Facturas", "t_Facturas")
            Desconectar()
            Me.dgv_Modificar.DataSource = DS.Tables("t_Facturas")
            Me.dgv_Modificar.Refresh()
        Catch ex As Exception
        End Try
        '------------------------------------------------------------------------------------------

        '-----------------------------------> DGV Eliminar <---------------------------------------
        Try
            Conectar()
            SelectQuery("SELECT fact_IdFactura AS Nro.Factura,fact_IdCliente AS CodigoCliente,fact_NombreCliente AS NombreCliente,fact_FormaPago AS FormaPago,fact_Vendedor AS Vendedor,fact_Fecha AS Fecha,fact_IdProducto AS CodigoProducto,fact_Producto AS Producto,fact_Precio1Prod AS Precio1,fact_Precio2Prod AS Precio2,fact_PrecioVentaProd AS PrecioVenta, fact_Descuento AS Descuento, fact_Impuesto AS Impuestos, fact_Subtotal AS Sub-Total,fact_Total AS TOTAL, fact_Comentario AS Comentario FROM t_Facturas", "t_Facturas")
            Desconectar()
            Me.dgv_Eliminar.DataSource = DS.Tables("t_Facturas")
            Me.dgv_Eliminar.Refresh()
        Catch ex As Exception
        End Try
        '------------------------------------------------------------------------------------------
    End Sub

    Private Sub rb_Codigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_NroFactura.CheckedChanged
        If rb_NroFactura.Checked = True Then
            rb_Fecha.Checked = False
            tb_NroFactC.Visible = True
            datetp_FechaC.Visible = False
        End If
    End Sub
End Class