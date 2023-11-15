namespace capaPresentacion
{
    partial class listaPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblGestionClientes = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.dgvPedidos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarProducto = new FontAwesome.Sharp.IconButton();
            this.lblListaPedidos = new System.Windows.Forms.Label();
            this.btnConfirmarPedido = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionClientes
            // 
            this.lblGestionClientes.AutoSize = true;
            this.lblGestionClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClientes.ForeColor = System.Drawing.Color.White;
            this.lblGestionClientes.Location = new System.Drawing.Point(133, 29);
            this.lblGestionClientes.Name = "lblGestionClientes";
            this.lblGestionClientes.Size = new System.Drawing.Size(186, 22);
            this.lblGestionClientes.TabIndex = 33;
            this.lblGestionClientes.Text = "Gestión de Pedidos";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(212, 96);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(205, 20);
            this.txtCantidad.TabIndex = 28;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(212, 63);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(205, 20);
            this.txtNombreProducto.TabIndex = 27;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(32, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(174, 22);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre Producto";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(32, 93);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(91, 21);
            this.lblApellido.TabIndex = 22;
            this.lblApellido.Text = "Cantidad:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(32, 129);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(94, 21);
            this.lblUsuario.TabIndex = 23;
            this.lblUsuario.Text = "Proveedor:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(212, 163);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(205, 62);
            this.txtDescripcion.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Descripción:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(34, 228);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(87, 21);
            this.lblDireccion.TabIndex = 37;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(212, 231);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(205, 20);
            this.txtDireccion.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(523, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 39;
            this.label3.Text = "Fecha Pedido";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(646, 31);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(233, 20);
            this.fecha.TabIndex = 40;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.ColumnHeadersHeight = 15;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedidos.Location = new System.Drawing.Point(6, 317);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.Size = new System.Drawing.Size(1093, 291);
            this.dgvPedidos.TabIndex = 41;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPedidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPedidos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPedidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedidos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPedidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPedidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPedidos.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvPedidos.ThemeStyle.ReadOnly = true;
            this.dgvPedidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPedidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedidos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPedidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPedidos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPedidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPedidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellDoubleClick);
            // 
            // btnAñadir
            // 
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.ParachuteBox;
            this.btnAñadir.IconColor = System.Drawing.Color.Black;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 49;
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.Location = new System.Drawing.Point(896, 84);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(144, 42);
            this.btnAñadir.TabIndex = 47;
            this.btnAñadir.Text = "Agregar Pedido";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.HouseCircleXmark;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 49;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(896, 132);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 44);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "Cancelar Pedido";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.ForeColor = System.Drawing.Color.White;
            this.lblOperaciones.Location = new System.Drawing.Point(937, 66);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(67, 13);
            this.lblOperaciones.TabIndex = 44;
            this.lblOperaciones.Text = "Operaciones";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Items.AddRange(new object[] {
            "Proveedor1",
            "Proveedor2",
            "Proveedor3"});
            this.cmbProveedor.Location = new System.Drawing.Point(212, 132);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(205, 21);
            this.cmbProveedor.TabIndex = 48;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProducto.Location = new System.Drawing.Point(437, 60);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarProducto.TabIndex = 51;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpiarProducto.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarProducto.Location = new System.Drawing.Point(549, 60);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarProducto.TabIndex = 57;
            this.btnLimpiarProducto.Text = "Limpiar Producto";
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiarProducto_Click);
            // 
            // lblListaPedidos
            // 
            this.lblListaPedidos.AutoSize = true;
            this.lblListaPedidos.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPedidos.ForeColor = System.Drawing.Color.White;
            this.lblListaPedidos.Location = new System.Drawing.Point(337, 275);
            this.lblListaPedidos.Name = "lblListaPedidos";
            this.lblListaPedidos.Size = new System.Drawing.Size(450, 39);
            this.lblListaPedidos.TabIndex = 58;
            this.lblListaPedidos.Text = "Lista de Pedidos Pendientes";
            // 
            // btnConfirmarPedido
            // 
            this.btnConfirmarPedido.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            this.btnConfirmarPedido.IconColor = System.Drawing.Color.Black;
            this.btnConfirmarPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmarPedido.IconSize = 49;
            this.btnConfirmarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarPedido.Location = new System.Drawing.Point(896, 182);
            this.btnConfirmarPedido.Name = "btnConfirmarPedido";
            this.btnConfirmarPedido.Size = new System.Drawing.Size(144, 44);
            this.btnConfirmarPedido.TabIndex = 59;
            this.btnConfirmarPedido.Text = "Confirmar Pedido";
            this.btnConfirmarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarPedido.UseVisualStyleBackColor = true;
            this.btnConfirmarPedido.Click += new System.EventHandler(this.btnConfirmarPedido_Click);
            // 
            // listaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1103, 612);
            this.Controls.Add(this.btnConfirmarPedido);
            this.Controls.Add(this.lblListaPedidos);
            this.Controls.Add(this.btnLimpiarProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGestionClientes);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listaPedidos";
            this.Text = "listaPedidos";
            this.Load += new System.EventHandler(this.listaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionClientes;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha;
        private FontAwesome.Sharp.IconButton btnAñadir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Label lblOperaciones;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPedidos;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private FontAwesome.Sharp.IconButton btnLimpiarProducto;
        private System.Windows.Forms.Label lblListaPedidos;
        private FontAwesome.Sharp.IconButton btnConfirmarPedido;
    }
}