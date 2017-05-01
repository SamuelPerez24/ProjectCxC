<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_Inventario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(f_Inventario))
        Me.tbc_Clientes = New System.Windows.Forms.TabControl()
        Me.tbpage_Agregar = New System.Windows.Forms.TabPage()
        Me.gb_PreciosVentasA = New System.Windows.Forms.GroupBox()
        Me.tb_UtilidadA = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tb_PrecioVentaA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_Precio2A = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_Precio1A = New System.Windows.Forms.TextBox()
        Me.gb_DatosProductoA = New System.Windows.Forms.GroupBox()
        Me.tb_CantidadMinimaA = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tb_CantidadAlmacenA = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.datetp_FechaA = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tb_CodigoA = New System.Windows.Forms.TextBox()
        Me.tb_DescripcionA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_CostoA = New System.Windows.Forms.TextBox()
        Me.btn_RetornarA = New System.Windows.Forms.Button()
        Me.btn_GuargarA = New System.Windows.Forms.Button()
        Me.dgv_Agregar = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.tbpage_Modificar = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_UtilidadM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_PrecioVentaM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_Precio2M = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_Precio1M = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tb_CantidadMinimaM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_CantidadAlmacenM = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.datetp_FechaM = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tb_CodigoM = New System.Windows.Forms.TextBox()
        Me.tb_DescripcionM = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tb_CostoM = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgv_Modificar = New System.Windows.Forms.DataGridView()
        Me.btn_RetornarM = New System.Windows.Forms.Button()
        Me.btn_GuardarM = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.tbpage_Eliminar = New System.Windows.Forms.TabPage()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tb_CodigoE = New System.Windows.Forms.TextBox()
        Me.dgv_Eliminar = New System.Windows.Forms.DataGridView()
        Me.btn_SalirE = New System.Windows.Forms.Button()
        Me.btn_GuardarE = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.tbpage_Consultar = New System.Windows.Forms.TabPage()
        Me.gb_Seleccion = New System.Windows.Forms.GroupBox()
        Me.datetp_FechaC = New System.Windows.Forms.DateTimePicker()
        Me.rb_Fecha = New System.Windows.Forms.RadioButton()
        Me.rb_Codigo = New System.Windows.Forms.RadioButton()
        Me.tb_CodigoC = New System.Windows.Forms.TextBox()
        Me.dgv_Consultar = New System.Windows.Forms.DataGridView()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.tbc_Clientes.SuspendLayout()
        Me.tbpage_Agregar.SuspendLayout()
        Me.gb_PreciosVentasA.SuspendLayout()
        Me.gb_DatosProductoA.SuspendLayout()
        CType(Me.dgv_Agregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpage_Modificar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_Modificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpage_Eliminar.SuspendLayout()
        CType(Me.dgv_Eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpage_Consultar.SuspendLayout()
        Me.gb_Seleccion.SuspendLayout()
        CType(Me.dgv_Consultar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbc_Clientes
        '
        Me.tbc_Clientes.Controls.Add(Me.tbpage_Agregar)
        Me.tbc_Clientes.Controls.Add(Me.tbpage_Modificar)
        Me.tbc_Clientes.Controls.Add(Me.tbpage_Eliminar)
        Me.tbc_Clientes.Controls.Add(Me.tbpage_Consultar)
        Me.tbc_Clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc_Clientes.Location = New System.Drawing.Point(6, 8)
        Me.tbc_Clientes.Name = "tbc_Clientes"
        Me.tbc_Clientes.SelectedIndex = 0
        Me.tbc_Clientes.Size = New System.Drawing.Size(801, 450)
        Me.tbc_Clientes.TabIndex = 1
        '
        'tbpage_Agregar
        '
        Me.tbpage_Agregar.Controls.Add(Me.gb_PreciosVentasA)
        Me.tbpage_Agregar.Controls.Add(Me.gb_DatosProductoA)
        Me.tbpage_Agregar.Controls.Add(Me.tb_CostoA)
        Me.tbpage_Agregar.Controls.Add(Me.btn_RetornarA)
        Me.tbpage_Agregar.Controls.Add(Me.btn_GuargarA)
        Me.tbpage_Agregar.Controls.Add(Me.dgv_Agregar)
        Me.tbpage_Agregar.Controls.Add(Me.Label6)
        Me.tbpage_Agregar.Controls.Add(Me.btn_Agregar)
        Me.tbpage_Agregar.ForeColor = System.Drawing.Color.Navy
        Me.tbpage_Agregar.Location = New System.Drawing.Point(4, 25)
        Me.tbpage_Agregar.Name = "tbpage_Agregar"
        Me.tbpage_Agregar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpage_Agregar.Size = New System.Drawing.Size(793, 421)
        Me.tbpage_Agregar.TabIndex = 0
        Me.tbpage_Agregar.Text = "Añadir"
        Me.tbpage_Agregar.UseVisualStyleBackColor = True
        '
        'gb_PreciosVentasA
        '
        Me.gb_PreciosVentasA.BackColor = System.Drawing.Color.White
        Me.gb_PreciosVentasA.Controls.Add(Me.tb_UtilidadA)
        Me.gb_PreciosVentasA.Controls.Add(Me.Label24)
        Me.gb_PreciosVentasA.Controls.Add(Me.tb_PrecioVentaA)
        Me.gb_PreciosVentasA.Controls.Add(Me.Label9)
        Me.gb_PreciosVentasA.Controls.Add(Me.Label7)
        Me.gb_PreciosVentasA.Controls.Add(Me.tb_Precio2A)
        Me.gb_PreciosVentasA.Controls.Add(Me.Label4)
        Me.gb_PreciosVentasA.Controls.Add(Me.tb_Precio1A)
        Me.gb_PreciosVentasA.ForeColor = System.Drawing.Color.Navy
        Me.gb_PreciosVentasA.Location = New System.Drawing.Point(397, 115)
        Me.gb_PreciosVentasA.Name = "gb_PreciosVentasA"
        Me.gb_PreciosVentasA.Size = New System.Drawing.Size(283, 139)
        Me.gb_PreciosVentasA.TabIndex = 59
        Me.gb_PreciosVentasA.TabStop = False
        Me.gb_PreciosVentasA.Text = "Precio de ventas"
        '
        'tb_UtilidadA
        '
        Me.tb_UtilidadA.BackColor = System.Drawing.Color.Navy
        Me.tb_UtilidadA.ForeColor = System.Drawing.Color.White
        Me.tb_UtilidadA.Location = New System.Drawing.Point(143, 87)
        Me.tb_UtilidadA.Name = "tb_UtilidadA"
        Me.tb_UtilidadA.Size = New System.Drawing.Size(125, 23)
        Me.tb_UtilidadA.TabIndex = 62
        Me.tb_UtilidadA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(140, 67)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 17)
        Me.Label24.TabIndex = 63
        Me.Label24.Text = "Utilidad %"
        '
        'tb_PrecioVentaA
        '
        Me.tb_PrecioVentaA.BackColor = System.Drawing.Color.Navy
        Me.tb_PrecioVentaA.ForeColor = System.Drawing.Color.White
        Me.tb_PrecioVentaA.Location = New System.Drawing.Point(143, 38)
        Me.tb_PrecioVentaA.Name = "tb_PrecioVentaA"
        Me.tb_PrecioVentaA.Size = New System.Drawing.Size(125, 23)
        Me.tb_PrecioVentaA.TabIndex = 60
        Me.tb_PrecioVentaA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(140, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 17)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Precio de Venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(6, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Precio 1"
        '
        'tb_Precio2A
        '
        Me.tb_Precio2A.BackColor = System.Drawing.Color.Navy
        Me.tb_Precio2A.ForeColor = System.Drawing.Color.White
        Me.tb_Precio2A.Location = New System.Drawing.Point(9, 87)
        Me.tb_Precio2A.Name = "tb_Precio2A"
        Me.tb_Precio2A.Size = New System.Drawing.Size(125, 23)
        Me.tb_Precio2A.TabIndex = 55
        Me.tb_Precio2A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(6, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Precio 2"
        '
        'tb_Precio1A
        '
        Me.tb_Precio1A.BackColor = System.Drawing.Color.Navy
        Me.tb_Precio1A.ForeColor = System.Drawing.Color.White
        Me.tb_Precio1A.Location = New System.Drawing.Point(9, 38)
        Me.tb_Precio1A.Name = "tb_Precio1A"
        Me.tb_Precio1A.Size = New System.Drawing.Size(125, 23)
        Me.tb_Precio1A.TabIndex = 58
        Me.tb_Precio1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gb_DatosProductoA
        '
        Me.gb_DatosProductoA.BackColor = System.Drawing.Color.White
        Me.gb_DatosProductoA.Controls.Add(Me.tb_CantidadMinimaA)
        Me.gb_DatosProductoA.Controls.Add(Me.Label26)
        Me.gb_DatosProductoA.Controls.Add(Me.tb_CantidadAlmacenA)
        Me.gb_DatosProductoA.Controls.Add(Me.Label25)
        Me.gb_DatosProductoA.Controls.Add(Me.datetp_FechaA)
        Me.gb_DatosProductoA.Controls.Add(Me.Label21)
        Me.gb_DatosProductoA.Controls.Add(Me.tb_CodigoA)
        Me.gb_DatosProductoA.Controls.Add(Me.tb_DescripcionA)
        Me.gb_DatosProductoA.Controls.Add(Me.Label11)
        Me.gb_DatosProductoA.Controls.Add(Me.Label3)
        Me.gb_DatosProductoA.ForeColor = System.Drawing.Color.Navy
        Me.gb_DatosProductoA.Location = New System.Drawing.Point(13, 88)
        Me.gb_DatosProductoA.Name = "gb_DatosProductoA"
        Me.gb_DatosProductoA.Size = New System.Drawing.Size(361, 166)
        Me.gb_DatosProductoA.TabIndex = 58
        Me.gb_DatosProductoA.TabStop = False
        Me.gb_DatosProductoA.Text = "Datos del producto"
        '
        'tb_CantidadMinimaA
        '
        Me.tb_CantidadMinimaA.BackColor = System.Drawing.Color.Navy
        Me.tb_CantidadMinimaA.ForeColor = System.Drawing.Color.White
        Me.tb_CantidadMinimaA.Location = New System.Drawing.Point(187, 133)
        Me.tb_CantidadMinimaA.MaxLength = 3
        Me.tb_CantidadMinimaA.Name = "tb_CantidadMinimaA"
        Me.tb_CantidadMinimaA.Size = New System.Drawing.Size(158, 23)
        Me.tb_CantidadMinimaA.TabIndex = 61
        Me.tb_CantidadMinimaA.Text = "000"
        Me.tb_CantidadMinimaA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(184, 116)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(127, 17)
        Me.Label26.TabIndex = 60
        Me.Label26.Text = "Cantidad minima"
        '
        'tb_CantidadAlmacenA
        '
        Me.tb_CantidadAlmacenA.BackColor = System.Drawing.Color.Navy
        Me.tb_CantidadAlmacenA.ForeColor = System.Drawing.Color.White
        Me.tb_CantidadAlmacenA.Location = New System.Drawing.Point(187, 87)
        Me.tb_CantidadAlmacenA.MaxLength = 3
        Me.tb_CantidadAlmacenA.Name = "tb_CantidadAlmacenA"
        Me.tb_CantidadAlmacenA.Size = New System.Drawing.Size(158, 23)
        Me.tb_CantidadAlmacenA.TabIndex = 59
        Me.tb_CantidadAlmacenA.Text = "000"
        Me.tb_CantidadAlmacenA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(184, 70)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(161, 17)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "Cantidad en Almacen"
        '
        'datetp_FechaA
        '
        Me.datetp_FechaA.CalendarForeColor = System.Drawing.Color.Navy
        Me.datetp_FechaA.CalendarMonthBackground = System.Drawing.Color.Navy
        Me.datetp_FechaA.CalendarTitleBackColor = System.Drawing.Color.White
        Me.datetp_FechaA.CalendarTitleForeColor = System.Drawing.Color.White
        Me.datetp_FechaA.CalendarTrailingForeColor = System.Drawing.Color.Navy
        Me.datetp_FechaA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetp_FechaA.Location = New System.Drawing.Point(187, 41)
        Me.datetp_FechaA.Name = "datetp_FechaA"
        Me.datetp_FechaA.Size = New System.Drawing.Size(142, 23)
        Me.datetp_FechaA.TabIndex = 57
        Me.datetp_FechaA.Value = New Date(2013, 5, 6, 0, 0, 0, 0)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(17, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(150, 17)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "Codigo de producto"
        '
        'tb_CodigoA
        '
        Me.tb_CodigoA.BackColor = System.Drawing.Color.Navy
        Me.tb_CodigoA.ForeColor = System.Drawing.Color.White
        Me.tb_CodigoA.Location = New System.Drawing.Point(20, 44)
        Me.tb_CodigoA.Name = "tb_CodigoA"
        Me.tb_CodigoA.Size = New System.Drawing.Size(147, 23)
        Me.tb_CodigoA.TabIndex = 55
        '
        'tb_DescripcionA
        '
        Me.tb_DescripcionA.BackColor = System.Drawing.Color.Navy
        Me.tb_DescripcionA.ForeColor = System.Drawing.Color.White
        Me.tb_DescripcionA.Location = New System.Drawing.Point(20, 88)
        Me.tb_DescripcionA.Multiline = True
        Me.tb_DescripcionA.Name = "tb_DescripcionA"
        Me.tb_DescripcionA.Size = New System.Drawing.Size(144, 68)
        Me.tb_DescripcionA.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(187, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Fecha de creacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(17, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'tb_CostoA
        '
        Me.tb_CostoA.BackColor = System.Drawing.Color.Navy
        Me.tb_CostoA.ForeColor = System.Drawing.Color.White
        Me.tb_CostoA.Location = New System.Drawing.Point(449, 88)
        Me.tb_CostoA.Name = "tb_CostoA"
        Me.tb_CostoA.Size = New System.Drawing.Size(153, 23)
        Me.tb_CostoA.TabIndex = 14
        Me.tb_CostoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_RetornarA
        '
        Me.btn_RetornarA.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.Crystal_Clear_action_exit_svg
        Me.btn_RetornarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_RetornarA.FlatAppearance.BorderSize = 0
        Me.btn_RetornarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RetornarA.Location = New System.Drawing.Point(695, 6)
        Me.btn_RetornarA.Name = "btn_RetornarA"
        Me.btn_RetornarA.Size = New System.Drawing.Size(91, 89)
        Me.btn_RetornarA.TabIndex = 25
        Me.btn_RetornarA.UseVisualStyleBackColor = True
        '
        'btn_GuargarA
        '
        Me.btn_GuargarA.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.filesave
        Me.btn_GuargarA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_GuargarA.FlatAppearance.BorderSize = 0
        Me.btn_GuargarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_GuargarA.Location = New System.Drawing.Point(134, 8)
        Me.btn_GuargarA.Name = "btn_GuargarA"
        Me.btn_GuargarA.Size = New System.Drawing.Size(73, 74)
        Me.btn_GuargarA.TabIndex = 24
        Me.btn_GuargarA.UseVisualStyleBackColor = True
        '
        'dgv_Agregar
        '
        Me.dgv_Agregar.BackgroundColor = System.Drawing.Color.Navy
        Me.dgv_Agregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Agregar.GridColor = System.Drawing.Color.White
        Me.dgv_Agregar.Location = New System.Drawing.Point(6, 260)
        Me.dgv_Agregar.Name = "dgv_Agregar"
        Me.dgv_Agregar.Size = New System.Drawing.Size(780, 155)
        Me.dgv_Agregar.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(394, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Costo"
        '
        'btn_Agregar
        '
        Me.btn_Agregar.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.user_add_5006
        Me.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Agregar.FlatAppearance.BorderSize = 0
        Me.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Agregar.Location = New System.Drawing.Point(18, 8)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(79, 70)
        Me.btn_Agregar.TabIndex = 1
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'tbpage_Modificar
        '
        Me.tbpage_Modificar.Controls.Add(Me.GroupBox1)
        Me.tbpage_Modificar.Controls.Add(Me.GroupBox2)
        Me.tbpage_Modificar.Controls.Add(Me.tb_CostoM)
        Me.tbpage_Modificar.Controls.Add(Me.Label16)
        Me.tbpage_Modificar.Controls.Add(Me.dgv_Modificar)
        Me.tbpage_Modificar.Controls.Add(Me.btn_RetornarM)
        Me.tbpage_Modificar.Controls.Add(Me.btn_GuardarM)
        Me.tbpage_Modificar.Controls.Add(Me.btn_Modificar)
        Me.tbpage_Modificar.ForeColor = System.Drawing.Color.Navy
        Me.tbpage_Modificar.Location = New System.Drawing.Point(4, 25)
        Me.tbpage_Modificar.Name = "tbpage_Modificar"
        Me.tbpage_Modificar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpage_Modificar.Size = New System.Drawing.Size(793, 421)
        Me.tbpage_Modificar.TabIndex = 1
        Me.tbpage_Modificar.Text = "Modificar"
        Me.tbpage_Modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Navy
        Me.GroupBox1.Controls.Add(Me.tb_UtilidadM)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_PrecioVentaM)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tb_Precio2M)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tb_Precio1M)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(403, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 139)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Precio de ventas"
        '
        'tb_UtilidadM
        '
        Me.tb_UtilidadM.BackColor = System.Drawing.Color.Navy
        Me.tb_UtilidadM.ForeColor = System.Drawing.Color.White
        Me.tb_UtilidadM.Location = New System.Drawing.Point(143, 87)
        Me.tb_UtilidadM.Name = "tb_UtilidadM"
        Me.tb_UtilidadM.Size = New System.Drawing.Size(125, 23)
        Me.tb_UtilidadM.TabIndex = 62
        Me.tb_UtilidadM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(140, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Utilidad %"
        '
        'tb_PrecioVentaM
        '
        Me.tb_PrecioVentaM.BackColor = System.Drawing.Color.Navy
        Me.tb_PrecioVentaM.ForeColor = System.Drawing.Color.White
        Me.tb_PrecioVentaM.Location = New System.Drawing.Point(143, 38)
        Me.tb_PrecioVentaM.Name = "tb_PrecioVentaM"
        Me.tb_PrecioVentaM.Size = New System.Drawing.Size(125, 23)
        Me.tb_PrecioVentaM.TabIndex = 60
        Me.tb_PrecioVentaM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(140, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 17)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Precio de Venta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Precio 1"
        '
        'tb_Precio2M
        '
        Me.tb_Precio2M.BackColor = System.Drawing.Color.Navy
        Me.tb_Precio2M.ForeColor = System.Drawing.Color.White
        Me.tb_Precio2M.Location = New System.Drawing.Point(9, 87)
        Me.tb_Precio2M.Name = "tb_Precio2M"
        Me.tb_Precio2M.Size = New System.Drawing.Size(125, 23)
        Me.tb_Precio2M.TabIndex = 55
        Me.tb_Precio2M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(6, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Precio 2"
        '
        'tb_Precio1M
        '
        Me.tb_Precio1M.BackColor = System.Drawing.Color.Navy
        Me.tb_Precio1M.ForeColor = System.Drawing.Color.White
        Me.tb_Precio1M.Location = New System.Drawing.Point(9, 38)
        Me.tb_Precio1M.Name = "tb_Precio1M"
        Me.tb_Precio1M.Size = New System.Drawing.Size(125, 23)
        Me.tb_Precio1M.TabIndex = 58
        Me.tb_Precio1M.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Navy
        Me.GroupBox2.Controls.Add(Me.tb_CantidadMinimaM)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.tb_CantidadAlmacenM)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.datetp_FechaM)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tb_CodigoM)
        Me.GroupBox2.Controls.Add(Me.tb_DescripcionM)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(19, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 166)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del producto"
        '
        'tb_CantidadMinimaM
        '
        Me.tb_CantidadMinimaM.BackColor = System.Drawing.Color.Navy
        Me.tb_CantidadMinimaM.ForeColor = System.Drawing.Color.White
        Me.tb_CantidadMinimaM.Location = New System.Drawing.Point(187, 133)
        Me.tb_CantidadMinimaM.MaxLength = 3
        Me.tb_CantidadMinimaM.Name = "tb_CantidadMinimaM"
        Me.tb_CantidadMinimaM.Size = New System.Drawing.Size(158, 23)
        Me.tb_CantidadMinimaM.TabIndex = 61
        Me.tb_CantidadMinimaM.Text = "000"
        Me.tb_CantidadMinimaM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(184, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 17)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Cantidad minima"
        '
        'tb_CantidadAlmacenM
        '
        Me.tb_CantidadAlmacenM.BackColor = System.Drawing.Color.Navy
        Me.tb_CantidadAlmacenM.ForeColor = System.Drawing.Color.White
        Me.tb_CantidadAlmacenM.Location = New System.Drawing.Point(187, 87)
        Me.tb_CantidadAlmacenM.MaxLength = 3
        Me.tb_CantidadAlmacenM.Name = "tb_CantidadAlmacenM"
        Me.tb_CantidadAlmacenM.Size = New System.Drawing.Size(158, 23)
        Me.tb_CantidadAlmacenM.TabIndex = 59
        Me.tb_CantidadAlmacenM.Text = "000"
        Me.tb_CantidadAlmacenM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(184, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 17)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Cantidad en Almacen"
        '
        'datetp_FechaM
        '
        Me.datetp_FechaM.CalendarForeColor = System.Drawing.Color.Navy
        Me.datetp_FechaM.CalendarMonthBackground = System.Drawing.Color.Navy
        Me.datetp_FechaM.CalendarTitleBackColor = System.Drawing.Color.White
        Me.datetp_FechaM.CalendarTitleForeColor = System.Drawing.Color.White
        Me.datetp_FechaM.CalendarTrailingForeColor = System.Drawing.Color.Navy
        Me.datetp_FechaM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetp_FechaM.Location = New System.Drawing.Point(187, 41)
        Me.datetp_FechaM.Name = "datetp_FechaM"
        Me.datetp_FechaM.Size = New System.Drawing.Size(142, 23)
        Me.datetp_FechaM.TabIndex = 57
        Me.datetp_FechaM.Value = New Date(2013, 5, 6, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(17, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 17)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Codigo de producto"
        '
        'tb_CodigoM
        '
        Me.tb_CodigoM.BackColor = System.Drawing.Color.Navy
        Me.tb_CodigoM.ForeColor = System.Drawing.Color.White
        Me.tb_CodigoM.Location = New System.Drawing.Point(20, 44)
        Me.tb_CodigoM.Name = "tb_CodigoM"
        Me.tb_CodigoM.Size = New System.Drawing.Size(147, 23)
        Me.tb_CodigoM.TabIndex = 55
        '
        'tb_DescripcionM
        '
        Me.tb_DescripcionM.BackColor = System.Drawing.Color.Navy
        Me.tb_DescripcionM.ForeColor = System.Drawing.Color.White
        Me.tb_DescripcionM.Location = New System.Drawing.Point(20, 88)
        Me.tb_DescripcionM.Multiline = True
        Me.tb_DescripcionM.Name = "tb_DescripcionM"
        Me.tb_DescripcionM.Size = New System.Drawing.Size(144, 68)
        Me.tb_DescripcionM.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(187, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Fecha de creacion"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(17, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 17)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Descripcion"
        '
        'tb_CostoM
        '
        Me.tb_CostoM.BackColor = System.Drawing.Color.Navy
        Me.tb_CostoM.ForeColor = System.Drawing.Color.White
        Me.tb_CostoM.Location = New System.Drawing.Point(455, 90)
        Me.tb_CostoM.Name = "tb_CostoM"
        Me.tb_CostoM.Size = New System.Drawing.Size(153, 23)
        Me.tb_CostoM.TabIndex = 61
        Me.tb_CostoM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(400, 93)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 17)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Costo"
        '
        'dgv_Modificar
        '
        Me.dgv_Modificar.BackgroundColor = System.Drawing.Color.Navy
        Me.dgv_Modificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Modificar.GridColor = System.Drawing.Color.White
        Me.dgv_Modificar.Location = New System.Drawing.Point(2, 265)
        Me.dgv_Modificar.Name = "dgv_Modificar"
        Me.dgv_Modificar.Size = New System.Drawing.Size(788, 150)
        Me.dgv_Modificar.TabIndex = 26
        '
        'btn_RetornarM
        '
        Me.btn_RetornarM.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.Crystal_Clear_action_exit_svg
        Me.btn_RetornarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_RetornarM.FlatAppearance.BorderSize = 0
        Me.btn_RetornarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_RetornarM.Location = New System.Drawing.Point(699, 3)
        Me.btn_RetornarM.Name = "btn_RetornarM"
        Me.btn_RetornarM.Size = New System.Drawing.Size(91, 89)
        Me.btn_RetornarM.TabIndex = 51
        Me.btn_RetornarM.UseVisualStyleBackColor = True
        '
        'btn_GuardarM
        '
        Me.btn_GuardarM.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.filesave
        Me.btn_GuardarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_GuardarM.FlatAppearance.BorderSize = 0
        Me.btn_GuardarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_GuardarM.Location = New System.Drawing.Point(134, 10)
        Me.btn_GuardarM.Name = "btn_GuardarM"
        Me.btn_GuardarM.Size = New System.Drawing.Size(73, 74)
        Me.btn_GuardarM.TabIndex = 50
        Me.btn_GuardarM.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.alt_editar_icono_5470_128
        Me.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Modificar.FlatAppearance.BorderSize = 0
        Me.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Modificar.Location = New System.Drawing.Point(19, 10)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(68, 70)
        Me.btn_Modificar.TabIndex = 27
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'tbpage_Eliminar
        '
        Me.tbpage_Eliminar.Controls.Add(Me.Label23)
        Me.tbpage_Eliminar.Controls.Add(Me.tb_CodigoE)
        Me.tbpage_Eliminar.Controls.Add(Me.dgv_Eliminar)
        Me.tbpage_Eliminar.Controls.Add(Me.btn_SalirE)
        Me.tbpage_Eliminar.Controls.Add(Me.btn_GuardarE)
        Me.tbpage_Eliminar.Controls.Add(Me.btn_Eliminar)
        Me.tbpage_Eliminar.ForeColor = System.Drawing.Color.Navy
        Me.tbpage_Eliminar.Location = New System.Drawing.Point(4, 25)
        Me.tbpage_Eliminar.Name = "tbpage_Eliminar"
        Me.tbpage_Eliminar.Size = New System.Drawing.Size(793, 421)
        Me.tbpage_Eliminar.TabIndex = 2
        Me.tbpage_Eliminar.Text = "Eliminar"
        Me.tbpage_Eliminar.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(18, 118)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(154, 17)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "Codigo del producto"
        '
        'tb_CodigoE
        '
        Me.tb_CodigoE.BackColor = System.Drawing.Color.Navy
        Me.tb_CodigoE.ForeColor = System.Drawing.Color.White
        Me.tb_CodigoE.Location = New System.Drawing.Point(18, 136)
        Me.tb_CodigoE.Name = "tb_CodigoE"
        Me.tb_CodigoE.Size = New System.Drawing.Size(154, 23)
        Me.tb_CodigoE.TabIndex = 57
        '
        'dgv_Eliminar
        '
        Me.dgv_Eliminar.BackgroundColor = System.Drawing.Color.Navy
        Me.dgv_Eliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Eliminar.GridColor = System.Drawing.Color.White
        Me.dgv_Eliminar.Location = New System.Drawing.Point(2, 181)
        Me.dgv_Eliminar.Name = "dgv_Eliminar"
        Me.dgv_Eliminar.Size = New System.Drawing.Size(787, 220)
        Me.dgv_Eliminar.TabIndex = 26
        '
        'btn_SalirE
        '
        Me.btn_SalirE.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.Crystal_Clear_action_exit_svg
        Me.btn_SalirE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_SalirE.FlatAppearance.BorderSize = 0
        Me.btn_SalirE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SalirE.Location = New System.Drawing.Point(699, 5)
        Me.btn_SalirE.Name = "btn_SalirE"
        Me.btn_SalirE.Size = New System.Drawing.Size(91, 89)
        Me.btn_SalirE.TabIndex = 51
        Me.btn_SalirE.UseVisualStyleBackColor = True
        '
        'btn_GuardarE
        '
        Me.btn_GuardarE.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.filesave
        Me.btn_GuardarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_GuardarE.FlatAppearance.BorderSize = 0
        Me.btn_GuardarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_GuardarE.Location = New System.Drawing.Point(147, 23)
        Me.btn_GuardarE.Name = "btn_GuardarE"
        Me.btn_GuardarE.Size = New System.Drawing.Size(73, 74)
        Me.btn_GuardarE.TabIndex = 50
        Me.btn_GuardarE.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.delete_x_red_globe_89
        Me.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Eliminar.Location = New System.Drawing.Point(21, 20)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(79, 74)
        Me.btn_Eliminar.TabIndex = 27
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'tbpage_Consultar
        '
        Me.tbpage_Consultar.Controls.Add(Me.gb_Seleccion)
        Me.tbpage_Consultar.Controls.Add(Me.dgv_Consultar)
        Me.tbpage_Consultar.Controls.Add(Me.Button10)
        Me.tbpage_Consultar.Controls.Add(Me.Button12)
        Me.tbpage_Consultar.ForeColor = System.Drawing.Color.Navy
        Me.tbpage_Consultar.Location = New System.Drawing.Point(4, 25)
        Me.tbpage_Consultar.Name = "tbpage_Consultar"
        Me.tbpage_Consultar.Size = New System.Drawing.Size(793, 421)
        Me.tbpage_Consultar.TabIndex = 3
        Me.tbpage_Consultar.Text = "Consultar"
        Me.tbpage_Consultar.UseVisualStyleBackColor = True
        '
        'gb_Seleccion
        '
        Me.gb_Seleccion.Controls.Add(Me.datetp_FechaC)
        Me.gb_Seleccion.Controls.Add(Me.rb_Fecha)
        Me.gb_Seleccion.Controls.Add(Me.rb_Codigo)
        Me.gb_Seleccion.Controls.Add(Me.tb_CodigoC)
        Me.gb_Seleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_Seleccion.ForeColor = System.Drawing.Color.Navy
        Me.gb_Seleccion.Location = New System.Drawing.Point(18, 17)
        Me.gb_Seleccion.Name = "gb_Seleccion"
        Me.gb_Seleccion.Size = New System.Drawing.Size(560, 84)
        Me.gb_Seleccion.TabIndex = 59
        Me.gb_Seleccion.TabStop = False
        Me.gb_Seleccion.Text = "Seleccione una de las siguientes opciones:"
        '
        'datetp_FechaC
        '
        Me.datetp_FechaC.CalendarForeColor = System.Drawing.Color.Navy
        Me.datetp_FechaC.CalendarMonthBackground = System.Drawing.Color.Navy
        Me.datetp_FechaC.CalendarTitleBackColor = System.Drawing.Color.White
        Me.datetp_FechaC.CalendarTitleForeColor = System.Drawing.Color.White
        Me.datetp_FechaC.CalendarTrailingForeColor = System.Drawing.Color.Navy
        Me.datetp_FechaC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetp_FechaC.Location = New System.Drawing.Point(374, 53)
        Me.datetp_FechaC.Name = "datetp_FechaC"
        Me.datetp_FechaC.Size = New System.Drawing.Size(142, 23)
        Me.datetp_FechaC.TabIndex = 59
        Me.datetp_FechaC.Value = New Date(2013, 5, 6, 0, 0, 0, 0)
        Me.datetp_FechaC.Visible = False
        '
        'rb_Fecha
        '
        Me.rb_Fecha.AutoSize = True
        Me.rb_Fecha.ForeColor = System.Drawing.Color.Navy
        Me.rb_Fecha.Location = New System.Drawing.Point(356, 28)
        Me.rb_Fecha.Name = "rb_Fecha"
        Me.rb_Fecha.Size = New System.Drawing.Size(160, 21)
        Me.rb_Fecha.TabIndex = 57
        Me.rb_Fecha.TabStop = True
        Me.rb_Fecha.Text = "Fecha de creacion"
        Me.rb_Fecha.UseVisualStyleBackColor = True
        '
        'rb_Codigo
        '
        Me.rb_Codigo.AutoSize = True
        Me.rb_Codigo.ForeColor = System.Drawing.Color.Navy
        Me.rb_Codigo.Location = New System.Drawing.Point(27, 28)
        Me.rb_Codigo.Name = "rb_Codigo"
        Me.rb_Codigo.Size = New System.Drawing.Size(172, 21)
        Me.rb_Codigo.TabIndex = 56
        Me.rb_Codigo.TabStop = True
        Me.rb_Codigo.Text = "Codigo del producto"
        Me.rb_Codigo.UseVisualStyleBackColor = True
        '
        'tb_CodigoC
        '
        Me.tb_CodigoC.BackColor = System.Drawing.Color.Navy
        Me.tb_CodigoC.ForeColor = System.Drawing.Color.White
        Me.tb_CodigoC.Location = New System.Drawing.Point(27, 55)
        Me.tb_CodigoC.Name = "tb_CodigoC"
        Me.tb_CodigoC.Size = New System.Drawing.Size(172, 23)
        Me.tb_CodigoC.TabIndex = 53
        Me.tb_CodigoC.Visible = False
        '
        'dgv_Consultar
        '
        Me.dgv_Consultar.BackgroundColor = System.Drawing.Color.Navy
        Me.dgv_Consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Consultar.GridColor = System.Drawing.Color.White
        Me.dgv_Consultar.Location = New System.Drawing.Point(3, 162)
        Me.dgv_Consultar.Name = "dgv_Consultar"
        Me.dgv_Consultar.Size = New System.Drawing.Size(787, 238)
        Me.dgv_Consultar.TabIndex = 26
        '
        'Button10
        '
        Me.Button10.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.Crystal_Clear_action_exit_svg
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(699, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(91, 89)
        Me.Button10.TabIndex = 51
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = Global.ProyectoCxC.My.Resources.Resources.icono_buscar
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(594, 3)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(90, 89)
        Me.Button12.TabIndex = 27
        Me.Button12.UseVisualStyleBackColor = True
        '
        'f_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(816, 470)
        Me.Controls.Add(Me.tbc_Clientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "f_Inventario"
        Me.Text = "Inventario de productos"
        Me.tbc_Clientes.ResumeLayout(False)
        Me.tbpage_Agregar.ResumeLayout(False)
        Me.tbpage_Agregar.PerformLayout()
        Me.gb_PreciosVentasA.ResumeLayout(False)
        Me.gb_PreciosVentasA.PerformLayout()
        Me.gb_DatosProductoA.ResumeLayout(False)
        Me.gb_DatosProductoA.PerformLayout()
        CType(Me.dgv_Agregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpage_Modificar.ResumeLayout(False)
        Me.tbpage_Modificar.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_Modificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpage_Eliminar.ResumeLayout(False)
        Me.tbpage_Eliminar.PerformLayout()
        CType(Me.dgv_Eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpage_Consultar.ResumeLayout(False)
        Me.gb_Seleccion.ResumeLayout(False)
        Me.gb_Seleccion.PerformLayout()
        CType(Me.dgv_Consultar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbc_Clientes As System.Windows.Forms.TabControl
    Friend WithEvents tbpage_Agregar As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tb_CodigoA As System.Windows.Forms.TextBox
    Friend WithEvents tb_CostoA As System.Windows.Forms.TextBox
    Friend WithEvents tb_DescripcionA As System.Windows.Forms.TextBox
    Friend WithEvents btn_RetornarA As System.Windows.Forms.Button
    Friend WithEvents btn_GuargarA As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgv_Agregar As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents tbpage_Modificar As System.Windows.Forms.TabPage
    Friend WithEvents dgv_Modificar As System.Windows.Forms.DataGridView
    Friend WithEvents btn_RetornarM As System.Windows.Forms.Button
    Friend WithEvents btn_GuardarM As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents tbpage_Eliminar As System.Windows.Forms.TabPage
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tb_CodigoE As System.Windows.Forms.TextBox
    Friend WithEvents dgv_Eliminar As System.Windows.Forms.DataGridView
    Friend WithEvents btn_SalirE As System.Windows.Forms.Button
    Friend WithEvents btn_GuardarE As System.Windows.Forms.Button
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents tbpage_Consultar As System.Windows.Forms.TabPage
    Friend WithEvents gb_Seleccion As System.Windows.Forms.GroupBox
    Friend WithEvents rb_Fecha As System.Windows.Forms.RadioButton
    Friend WithEvents rb_Codigo As System.Windows.Forms.RadioButton
    Friend WithEvents tb_CodigoC As System.Windows.Forms.TextBox
    Friend WithEvents dgv_Consultar As System.Windows.Forms.DataGridView
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents gb_PreciosVentasA As System.Windows.Forms.GroupBox
    Friend WithEvents tb_UtilidadA As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents tb_PrecioVentaA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_Precio2A As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tb_Precio1A As System.Windows.Forms.TextBox
    Friend WithEvents gb_DatosProductoA As System.Windows.Forms.GroupBox
    Friend WithEvents tb_CantidadMinimaA As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tb_CantidadAlmacenA As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents datetp_FechaA As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_UtilidadM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_PrecioVentaM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tb_Precio2M As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_Precio1M As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tb_CantidadMinimaM As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_CantidadAlmacenM As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents datetp_FechaM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tb_CodigoM As System.Windows.Forms.TextBox
    Friend WithEvents tb_DescripcionM As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tb_CostoM As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents datetp_FechaC As System.Windows.Forms.DateTimePicker
End Class
