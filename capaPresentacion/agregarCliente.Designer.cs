namespace capaPresentacion
{
    partial class agregarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.lblGestionClientes = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblListaClientes = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnCambiarEstado = new FontAwesome.Sharp.IconButton();
            this.btnMostrarInactivos = new FontAwesome.Sharp.IconButton();
            this.dataGridClientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAñadir.IconColor = System.Drawing.Color.Black;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 50;
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.Location = new System.Drawing.Point(887, 42);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(144, 42);
            this.btnAñadir.TabIndex = 47;
            this.btnAñadir.Text = "Añadir Cliente";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 50;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(887, 90);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(144, 43);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar Cliente";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblGestionClientes
            // 
            this.lblGestionClientes.AutoSize = true;
            this.lblGestionClientes.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClientes.ForeColor = System.Drawing.Color.White;
            this.lblGestionClientes.Location = new System.Drawing.Point(352, 2);
            this.lblGestionClientes.Name = "lblGestionClientes";
            this.lblGestionClientes.Size = new System.Drawing.Size(456, 58);
            this.lblGestionClientes.TabIndex = 44;
            this.lblGestionClientes.Text = "Gestión de Cliente";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(578, 122);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(249, 20);
            this.txtDireccion.TabIndex = 40;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(202, 119);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(249, 20);
            this.txtDNI.TabIndex = 39;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.ForeColor = System.Drawing.Color.White;
            this.lblOperaciones.Location = new System.Drawing.Point(928, 21);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(67, 13);
            this.lblOperaciones.TabIndex = 43;
            this.lblOperaciones.Text = "Operaciones";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(578, 83);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(249, 20);
            this.txtApellido.TabIndex = 37;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(202, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 20);
            this.txtNombre.TabIndex = 36;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(474, 119);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(87, 21);
            this.lblDireccion.TabIndex = 33;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(97, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 22);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(143, 116);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(43, 21);
            this.lblDNI.TabIndex = 32;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(474, 77);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 21);
            this.lblApellido.TabIndex = 30;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(202, 154);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(249, 20);
            this.txtTelefono.TabIndex = 51;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(106, 154);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(80, 21);
            this.lblTelefono.TabIndex = 50;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscar.Location = new System.Drawing.Point(88, 293);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "Filtrar por DNI";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(154, 21);
            this.txtBuscar.TabIndex = 52;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblListaClientes
            // 
            this.lblListaClientes.AutoSize = true;
            this.lblListaClientes.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaClientes.ForeColor = System.Drawing.Color.White;
            this.lblListaClientes.Location = new System.Drawing.Point(429, 277);
            this.lblListaClientes.Name = "lblListaClientes";
            this.lblListaClientes.Size = new System.Drawing.Size(267, 39);
            this.lblListaClientes.TabIndex = 55;
            this.lblListaClientes.Text = "Lista de Clientes";
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 50;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(887, 139);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 43);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "Eliminar Cliente";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.btnCambiarEstado.IconColor = System.Drawing.Color.Black;
            this.btnCambiarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarEstado.IconSize = 50;
            this.btnCambiarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarEstado.Location = new System.Drawing.Point(887, 90);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(144, 43);
            this.btnCambiarEstado.TabIndex = 57;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnMostrarInactivos
            // 
            this.btnMostrarInactivos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMostrarInactivos.IconColor = System.Drawing.Color.Black;
            this.btnMostrarInactivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarInactivos.Location = new System.Drawing.Point(995, 274);
            this.btnMostrarInactivos.Name = "btnMostrarInactivos";
            this.btnMostrarInactivos.Size = new System.Drawing.Size(96, 40);
            this.btnMostrarInactivos.TabIndex = 58;
            this.btnMostrarInactivos.Text = "Ver Inactivos";
            this.btnMostrarInactivos.UseVisualStyleBackColor = true;
            this.btnMostrarInactivos.Click += new System.EventHandler(this.btnMostrarInactivos_Click);
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridClientes.ColumnHeadersHeight = 22;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridClientes.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridClientes.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridClientes.Location = new System.Drawing.Point(9, 319);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridClientes.RowHeadersVisible = false;
            this.dataGridClientes.RowTemplate.Height = 27;
            this.dataGridClientes.Size = new System.Drawing.Size(1088, 290);
            this.dataGridClientes.TabIndex = 59;
            this.dataGridClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridClientes.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridClientes.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridClientes.ThemeStyle.HeaderStyle.Height = 22;
            this.dataGridClientes.ThemeStyle.ReadOnly = false;
            this.dataGridClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridClientes.ThemeStyle.RowsStyle.Height = 27;
            this.dataGridClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellDoubleClick);
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.lblBuscarCliente.Location = new System.Drawing.Point(24, 293);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(58, 20);
            this.lblBuscarCliente.TabIndex = 60;
            this.lblBuscarCliente.Text = "Buscar";
            // 
            // agregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1103, 612);
            this.Controls.Add(this.lblBuscarCliente);
            this.Controls.Add(this.dataGridClientes);
            this.Controls.Add(this.btnMostrarInactivos);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblListaClientes);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblGestionClientes);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agregarCliente";
            this.Load += new System.EventHandler(this.agregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAñadir;
        private FontAwesome.Sharp.IconButton btnModificar;
        private System.Windows.Forms.Label lblGestionClientes;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label lblListaClientes;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCambiarEstado;
        private FontAwesome.Sharp.IconButton btnMostrarInactivos;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridClientes;
        private System.Windows.Forms.Label lblBuscarCliente;
    }
}