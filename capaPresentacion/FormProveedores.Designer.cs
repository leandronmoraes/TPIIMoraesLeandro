
namespace capaPresentacion
{
    partial class FormProveedores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProveedores = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblGestionClientes = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnAñadir = new FontAwesome.Sharp.IconButton();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnInscripto = new System.Windows.Forms.RadioButton();
            this.rbtnNoInscripto = new System.Windows.Forms.RadioButton();
            this.rbtnFinal = new System.Windows.Forms.RadioButton();
            this.txtBuscarCuit = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAlternarEstado = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCambiarEstado = new FontAwesome.Sharp.IconButton();
            this.lblBuscarCuit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProveedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedores.ColumnHeadersHeight = 15;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProveedores.Location = new System.Drawing.Point(3, 259);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.Size = new System.Drawing.Size(1101, 314);
            this.dgvProveedores.TabIndex = 23;
            this.dgvProveedores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProveedores.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProveedores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProveedores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProveedores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProveedores.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProveedores.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProveedores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProveedores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProveedores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProveedores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProveedores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProveedores.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvProveedores.ThemeStyle.ReadOnly = true;
            this.dgvProveedores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProveedores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProveedores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProveedores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProveedores.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProveedores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProveedores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellDoubleClick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(85, 109);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(51, 21);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "CUIT:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(58, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(80, 21);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Teléfono:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(47, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 22);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(49, 176);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(87, 21);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(81, 143);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(55, 21);
            this.lblContraseña.TabIndex = 6;
            this.lblContraseña.Text = "Email:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(152, 78);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(209, 20);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(152, 112);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(209, 20);
            this.txtCuit.TabIndex = 10;
            this.txtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.ForeColor = System.Drawing.Color.White;
            this.lblOperaciones.Location = new System.Drawing.Point(898, 32);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(67, 13);
            this.lblOperaciones.TabIndex = 19;
            this.lblOperaciones.Text = "Operaciones";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(152, 179);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(209, 20);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(152, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblGestionClientes
            // 
            this.lblGestionClientes.AutoSize = true;
            this.lblGestionClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClientes.ForeColor = System.Drawing.Color.White;
            this.lblGestionClientes.Location = new System.Drawing.Point(148, 9);
            this.lblGestionClientes.Name = "lblGestionClientes";
            this.lblGestionClientes.Size = new System.Drawing.Size(165, 22);
            this.lblGestionClientes.TabIndex = 20;
            this.lblGestionClientes.Text = "Datos Proveedor";
            // 
            // btnEliminar
            // 
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 50;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(857, 98);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 44);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar Proveedor";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAñadir.IconColor = System.Drawing.Color.Black;
            this.btnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAñadir.IconSize = 50;
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.Location = new System.Drawing.Point(857, 50);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(144, 42);
            this.btnAñadir.TabIndex = 23;
            this.btnAñadir.Text = "Añadir Proveedor";
            this.btnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTipoUsuario.Location = new System.Drawing.Point(562, 25);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(45, 22);
            this.lblTipoUsuario.TabIndex = 25;
            this.lblTipoUsuario.Text = "IVA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnInscripto);
            this.groupBox1.Controls.Add(this.rbtnNoInscripto);
            this.groupBox1.Controls.Add(this.rbtnFinal);
            this.groupBox1.Location = new System.Drawing.Point(465, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 102);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // rbtnInscripto
            // 
            this.rbtnInscripto.AutoSize = true;
            this.rbtnInscripto.Checked = true;
            this.rbtnInscripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInscripto.ForeColor = System.Drawing.Color.White;
            this.rbtnInscripto.Location = new System.Drawing.Point(5, 19);
            this.rbtnInscripto.Name = "rbtnInscripto";
            this.rbtnInscripto.Size = new System.Drawing.Size(173, 22);
            this.rbtnInscripto.TabIndex = 28;
            this.rbtnInscripto.TabStop = true;
            this.rbtnInscripto.Text = "Responsable Inscripto";
            this.rbtnInscripto.UseVisualStyleBackColor = true;
            // 
            // rbtnNoInscripto
            // 
            this.rbtnNoInscripto.AutoSize = true;
            this.rbtnNoInscripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNoInscripto.ForeColor = System.Drawing.Color.White;
            this.rbtnNoInscripto.Location = new System.Drawing.Point(5, 70);
            this.rbtnNoInscripto.Name = "rbtnNoInscripto";
            this.rbtnNoInscripto.Size = new System.Drawing.Size(194, 22);
            this.rbtnNoInscripto.TabIndex = 26;
            this.rbtnNoInscripto.Text = "Responsable no Inscripto";
            this.rbtnNoInscripto.UseVisualStyleBackColor = true;
            // 
            // rbtnFinal
            // 
            this.rbtnFinal.AutoSize = true;
            this.rbtnFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFinal.ForeColor = System.Drawing.Color.White;
            this.rbtnFinal.Location = new System.Drawing.Point(5, 47);
            this.rbtnFinal.Name = "rbtnFinal";
            this.rbtnFinal.Size = new System.Drawing.Size(138, 22);
            this.rbtnFinal.TabIndex = 27;
            this.rbtnFinal.Text = "Consumidor final";
            this.rbtnFinal.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCuit
            // 
            this.txtBuscarCuit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCuit.DefaultText = "";
            this.txtBuscarCuit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarCuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarCuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCuit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarCuit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCuit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarCuit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarCuit.Location = new System.Drawing.Point(789, 233);
            this.txtBuscarCuit.Name = "txtBuscarCuit";
            this.txtBuscarCuit.PasswordChar = '\0';
            this.txtBuscarCuit.PlaceholderText = "Filtrar por Cuit";
            this.txtBuscarCuit.SelectedText = "";
            this.txtBuscarCuit.Size = new System.Drawing.Size(154, 20);
            this.txtBuscarCuit.TabIndex = 33;
            this.txtBuscarCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarCuit.TextChanged += new System.EventHandler(this.txtBuscarCuit_TextChanged);
            this.txtBuscarCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCuit_KeyPress);
            // 
            // btnAlternarEstado
            // 
            this.btnAlternarEstado.IconChar = FontAwesome.Sharp.IconChar.ArrowsDownToPeople;
            this.btnAlternarEstado.IconColor = System.Drawing.Color.Black;
            this.btnAlternarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlternarEstado.IconSize = 50;
            this.btnAlternarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlternarEstado.Location = new System.Drawing.Point(968, 209);
            this.btnAlternarEstado.Name = "btnAlternarEstado";
            this.btnAlternarEstado.Size = new System.Drawing.Size(127, 44);
            this.btnAlternarEstado.TabIndex = 34;
            this.btnAlternarEstado.Text = "Alternar Estado";
            this.btnAlternarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlternarEstado.UseVisualStyleBackColor = true;
            this.btnAlternarEstado.Click += new System.EventHandler(this.btnAlternarEstado_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.btnCambiarEstado.IconColor = System.Drawing.Color.Black;
            this.btnCambiarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarEstado.IconSize = 50;
            this.btnCambiarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarEstado.Location = new System.Drawing.Point(857, 148);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(144, 43);
            this.btnCambiarEstado.TabIndex = 55;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Visible = false;
            // 
            // lblBuscarCuit
            // 
            this.lblBuscarCuit.AutoSize = true;
            this.lblBuscarCuit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCuit.ForeColor = System.Drawing.Color.White;
            this.lblBuscarCuit.Location = new System.Drawing.Point(718, 232);
            this.lblBuscarCuit.Name = "lblBuscarCuit";
            this.lblBuscarCuit.Size = new System.Drawing.Size(65, 21);
            this.lblBuscarCuit.TabIndex = 56;
            this.lblBuscarCuit.Text = "Buscar:";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1107, 576);
            this.Controls.Add(this.lblBuscarCuit);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.btnAlternarEstado);
            this.Controls.Add(this.txtBuscarCuit);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblGestionClientes);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedores";
            this.Text = "FormProveedores";
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblGestionClientes;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAñadir;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnInscripto;
        private System.Windows.Forms.RadioButton rbtnNoInscripto;
        private System.Windows.Forms.RadioButton rbtnFinal;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarCuit;
        public Guna.UI2.WinForms.Guna2DataGridView dgvProveedores;
        private FontAwesome.Sharp.IconButton btnAlternarEstado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnCambiarEstado;
        private System.Windows.Forms.Label lblBuscarCuit;
    }
}