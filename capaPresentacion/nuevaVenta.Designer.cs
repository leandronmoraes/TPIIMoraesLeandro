namespace capaPresentacion
{
    partial class nuevaVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridVenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNICliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpiarProducto = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCliente = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.btnBuscarCliente = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarCarrito = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarVenta = new FontAwesome.Sharp.IconButton();
            this.btnSumarCantidad = new FontAwesome.Sharp.IconButton();
            this.btnRestarCantidad = new FontAwesome.Sharp.IconButton();
            this.btnComprar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnCancelarVenta = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // dataGridVenta
            // 
            this.dataGridVenta.AllowUserToAddRows = false;
            this.dataGridVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridVenta.ColumnHeadersHeight = 15;
            this.dataGridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.cantidad,
            this.precioUnitario,
            this.subtotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridVenta.Location = new System.Drawing.Point(1, 274);
            this.dataGridVenta.Name = "dataGridVenta";
            this.dataGridVenta.ReadOnly = true;
            this.dataGridVenta.RowHeadersVisible = false;
            this.dataGridVenta.Size = new System.Drawing.Size(1102, 340);
            this.dataGridVenta.TabIndex = 40;
            this.dataGridVenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridVenta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridVenta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridVenta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridVenta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridVenta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridVenta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridVenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridVenta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridVenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridVenta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridVenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridVenta.ThemeStyle.HeaderStyle.Height = 15;
            this.dataGridVenta.ThemeStyle.ReadOnly = true;
            this.dataGridVenta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridVenta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridVenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridVenta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridVenta.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridVenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridVenta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precioUnitario
            // 
            this.precioUnitario.HeaderText = "PrecioUnitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(605, 86);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(182, 31);
            this.txtTotal.TabIndex = 41;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(194, 143);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(139, 20);
            this.txtCantidad.TabIndex = 42;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(433, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 42);
            this.label5.TabIndex = 47;
            this.label5.Text = "REGISTRAR VENTA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(635, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 52;
            this.label6.Text = "Total Compra";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDNICliente.DefaultText = "";
            this.txtDNICliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDNICliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDNICliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNICliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDNICliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNICliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDNICliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDNICliente.Location = new System.Drawing.Point(194, 60);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.PasswordChar = '\0';
            this.txtDNICliente.PlaceholderText = "DNI Cliente";
            this.txtDNICliente.ReadOnly = true;
            this.txtDNICliente.SelectedText = "";
            this.txtDNICliente.Size = new System.Drawing.Size(139, 23);
            this.txtDNICliente.TabIndex = 53;
            this.txtDNICliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNICliente_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProducto.DefaultText = "";
            this.txtNombreProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.Location = new System.Drawing.Point(194, 96);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.PlaceholderText = "Nombre Producto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.Size = new System.Drawing.Size(139, 23);
            this.txtNombreProducto.TabIndex = 54;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(194, 181);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(139, 20);
            this.txtPrecio.TabIndex = 57;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(50, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "Precio:";
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpiarProducto.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarProducto.Location = new System.Drawing.Point(456, 98);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarProducto.TabIndex = 56;
            this.btnLimpiarProducto.Text = "Limpiar Producto";
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiarProducto_Click);
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpiarCliente.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarCliente.Location = new System.Drawing.Point(456, 60);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCliente.TabIndex = 55;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.Location = new System.Drawing.Point(342, 98);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarProducto.TabIndex = 50;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarCliente.IconColor = System.Drawing.Color.Black;
            this.btnBuscarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarCliente.Location = new System.Drawing.Point(342, 60);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarCliente.TabIndex = 49;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnLimpiarCarrito
            // 
            this.btnLimpiarCarrito.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpiarCarrito.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarCarrito.Location = new System.Drawing.Point(619, 217);
            this.btnLimpiarCarrito.Name = "btnLimpiarCarrito";
            this.btnLimpiarCarrito.Size = new System.Drawing.Size(150, 47);
            this.btnLimpiarCarrito.TabIndex = 44;
            this.btnLimpiarCarrito.Text = "Limpiar Carrito";
            this.btnLimpiarCarrito.UseVisualStyleBackColor = true;
            this.btnLimpiarCarrito.Click += new System.EventHandler(this.btnLimpiarCarrito_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrarVenta.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(933, 217);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(160, 47);
            this.btnRegistrarVenta.TabIndex = 43;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnSumarCantidad
            // 
            this.btnSumarCantidad.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnSumarCantidad.IconColor = System.Drawing.Color.Green;
            this.btnSumarCantidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSumarCantidad.IconSize = 25;
            this.btnSumarCantidad.Location = new System.Drawing.Point(380, 144);
            this.btnSumarCantidad.Name = "btnSumarCantidad";
            this.btnSumarCantidad.Size = new System.Drawing.Size(32, 20);
            this.btnSumarCantidad.TabIndex = 39;
            this.btnSumarCantidad.UseVisualStyleBackColor = true;
            this.btnSumarCantidad.Click += new System.EventHandler(this.btnSumarCantidad_Click);
            // 
            // btnRestarCantidad
            // 
            this.btnRestarCantidad.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnRestarCantidad.IconColor = System.Drawing.Color.Red;
            this.btnRestarCantidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestarCantidad.IconSize = 25;
            this.btnRestarCantidad.Location = new System.Drawing.Point(342, 144);
            this.btnRestarCantidad.Name = "btnRestarCantidad";
            this.btnRestarCantidad.Size = new System.Drawing.Size(32, 20);
            this.btnRestarCantidad.TabIndex = 38;
            this.btnRestarCantidad.UseVisualStyleBackColor = true;
            this.btnRestarCantidad.Click += new System.EventHandler(this.btnRestarCantidad_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnComprar.IconColor = System.Drawing.Color.Green;
            this.btnComprar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComprar.IconSize = 40;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Location = new System.Drawing.Point(775, 217);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(150, 47);
            this.btnComprar.TabIndex = 37;
            this.btnComprar.Text = "Añadir al Carrito";
            this.btnComprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 60;
            this.label7.Text = "Pago:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(31, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 61;
            this.label8.Text = "$";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de crédito",
            "Tarjeta de débito",
            "6 cuotas sin intereses"});
            this.cmbTipoPago.Location = new System.Drawing.Point(194, 221);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(139, 21);
            this.cmbTipoPago.TabIndex = 62;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelarVenta.IconColor = System.Drawing.Color.Black;
            this.btnCancelarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarVenta.Location = new System.Drawing.Point(933, 164);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(160, 47);
            this.btnCancelarVenta.TabIndex = 63;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // nuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1105, 615);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnLimpiarProducto);
            this.Controls.Add(this.btnLimpiarCliente);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLimpiarCarrito);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dataGridVenta);
            this.Controls.Add(this.btnSumarCantidad);
            this.Controls.Add(this.btnRestarCantidad);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nuevaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nuevaVenta";
            this.Load += new System.EventHandler(this.nuevaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnSumarCantidad;
        private FontAwesome.Sharp.IconButton btnRestarCantidad;
        private FontAwesome.Sharp.IconButton btnComprar;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridVenta;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCantidad;
        private FontAwesome.Sharp.IconButton btnRegistrarVenta;
        private FontAwesome.Sharp.IconButton btnLimpiarCarrito;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnBuscarCliente;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtDNICliente;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreProducto;
        private FontAwesome.Sharp.IconButton btnLimpiarCliente;
        private FontAwesome.Sharp.IconButton btnLimpiarProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private FontAwesome.Sharp.IconButton btnCancelarVenta;
    }
}