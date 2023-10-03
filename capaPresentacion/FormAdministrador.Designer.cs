namespace capaPresentacion
{
    partial class FormAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panelVerticalMenu = new System.Windows.Forms.Panel();
            this.btnGestionUsuario = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtBoxLogo = new System.Windows.Forms.TextBox();
            this.btnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.btnDetalleVentas = new FontAwesome.Sharp.IconButton();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.btnGestionProducto = new FontAwesome.Sharp.IconButton();
            this.panelSeparador = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pBoxInicio = new System.Windows.Forms.PictureBox();
            this.Hora_Fecha = new System.Windows.Forms.Timer(this.components);
            this.DragControlAdm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelVerticalMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.lblAdmin);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1300, 38);
            this.panelTitulo.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1225, -10);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1265, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(12, 15);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(146, 20);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Perfil Administrador";
            // 
            // panelVerticalMenu
            // 
            this.panelVerticalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelVerticalMenu.Controls.Add(this.btnGestionUsuario);
            this.panelVerticalMenu.Controls.Add(this.panel4);
            this.panelVerticalMenu.Controls.Add(this.panel3);
            this.panelVerticalMenu.Controls.Add(this.panel2);
            this.panelVerticalMenu.Controls.Add(this.panel1);
            this.panelVerticalMenu.Controls.Add(this.panelLogo);
            this.panelVerticalMenu.Controls.Add(this.btnConfiguracion);
            this.panelVerticalMenu.Controls.Add(this.btnDetalleVentas);
            this.panelVerticalMenu.Controls.Add(this.btnEmpleados);
            this.panelVerticalMenu.Controls.Add(this.btnInicio);
            this.panelVerticalMenu.Controls.Add(this.btnCerrarSesion);
            this.panelVerticalMenu.Controls.Add(this.btnGestionProducto);
            this.panelVerticalMenu.Controls.Add(this.panelSeparador);
            this.panelVerticalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVerticalMenu.Location = new System.Drawing.Point(0, 38);
            this.panelVerticalMenu.Name = "panelVerticalMenu";
            this.panelVerticalMenu.Size = new System.Drawing.Size(197, 612);
            this.panelVerticalMenu.TabIndex = 3;
            // 
            // btnGestionUsuario
            // 
            this.btnGestionUsuario.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnGestionUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuario.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuario.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnGestionUsuario.IconColor = System.Drawing.Color.White;
            this.btnGestionUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionUsuario.IconSize = 40;
            this.btnGestionUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionUsuario.Location = new System.Drawing.Point(0, 204);
            this.btnGestionUsuario.Name = "btnGestionUsuario";
            this.btnGestionUsuario.Size = new System.Drawing.Size(194, 42);
            this.btnGestionUsuario.TabIndex = 18;
            this.btnGestionUsuario.Text = "Gestión Usuarios";
            this.btnGestionUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionUsuario.UseVisualStyleBackColor = true;
            this.btnGestionUsuario.Click += new System.EventHandler(this.btnGestionUsuario_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 1);
            this.panel4.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 1);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 1);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 1);
            this.panel1.TabIndex = 14;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pBoxLogo);
            this.panelLogo.Controls.Add(this.txtBoxLogo);
            this.panelLogo.Location = new System.Drawing.Point(0, 6);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(189, 74);
            this.panelLogo.TabIndex = 13;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLogo.Image")));
            this.pBoxLogo.Location = new System.Drawing.Point(0, 3);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(56, 72);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLogo.TabIndex = 12;
            this.pBoxLogo.TabStop = false;
            // 
            // txtBoxLogo
            // 
            this.txtBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxLogo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLogo.ForeColor = System.Drawing.Color.White;
            this.txtBoxLogo.Location = new System.Drawing.Point(55, 3);
            this.txtBoxLogo.Multiline = true;
            this.txtBoxLogo.Name = "txtBoxLogo";
            this.txtBoxLogo.ReadOnly = true;
            this.txtBoxLogo.Size = new System.Drawing.Size(132, 91);
            this.txtBoxLogo.TabIndex = 8;
            this.txtBoxLogo.Text = "Libreria - Moraes Todo a tu alcance!";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnConfiguracion.IconColor = System.Drawing.Color.White;
            this.btnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguracion.IconSize = 40;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 354);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(195, 42);
            this.btnConfiguracion.TabIndex = 11;
            this.btnConfiguracion.Text = "Configuraciones";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnDetalleVentas
            // 
            this.btnDetalleVentas.FlatAppearance.BorderSize = 0;
            this.btnDetalleVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnDetalleVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleVentas.ForeColor = System.Drawing.Color.White;
            this.btnDetalleVentas.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btnDetalleVentas.IconColor = System.Drawing.Color.White;
            this.btnDetalleVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalleVentas.IconSize = 40;
            this.btnDetalleVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleVentas.Location = new System.Drawing.Point(0, 304);
            this.btnDetalleVentas.Name = "btnDetalleVentas";
            this.btnDetalleVentas.Size = new System.Drawing.Size(197, 42);
            this.btnDetalleVentas.TabIndex = 10;
            this.btnDetalleVentas.Text = "Detalle Ventas";
            this.btnDetalleVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalleVentas.UseVisualStyleBackColor = true;
            this.btnDetalleVentas.Click += new System.EventHandler(this.btnDetalleVentas_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 40;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 254);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(197, 42);
            this.btnEmpleados.TabIndex = 9;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 40;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 100);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(194, 42);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnCerrarSesion.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarSesion.IconSize = 45;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 566);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(195, 42);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnGestionProducto
            // 
            this.btnGestionProducto.FlatAppearance.BorderSize = 0;
            this.btnGestionProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnGestionProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProducto.ForeColor = System.Drawing.Color.White;
            this.btnGestionProducto.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnGestionProducto.IconColor = System.Drawing.Color.White;
            this.btnGestionProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionProducto.IconSize = 40;
            this.btnGestionProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProducto.Location = new System.Drawing.Point(0, 154);
            this.btnGestionProducto.Name = "btnGestionProducto";
            this.btnGestionProducto.Size = new System.Drawing.Size(194, 42);
            this.btnGestionProducto.TabIndex = 2;
            this.btnGestionProducto.Text = "Gestión Productos";
            this.btnGestionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionProducto.UseVisualStyleBackColor = true;
            this.btnGestionProducto.Click += new System.EventHandler(this.btnGestionProducto_Click);
            // 
            // panelSeparador
            // 
            this.panelSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelSeparador.Location = new System.Drawing.Point(0, 150);
            this.panelSeparador.Name = "panelSeparador";
            this.panelSeparador.Size = new System.Drawing.Size(197, 1);
            this.panelSeparador.TabIndex = 5;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Controls.Add(this.lblMensaje);
            this.panelContenedor.Controls.Add(this.lblFecha);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Controls.Add(this.pBoxInicio);
            this.panelContenedor.Location = new System.Drawing.Point(197, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1103, 612);
            this.panelContenedor.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(300, 47);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(531, 49);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Bienvenido Administrador!";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.lblFecha.ForeColor = System.Drawing.Color.Purple;
            this.lblFecha.Location = new System.Drawing.Point(438, 139);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(133, 44);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblHora.Location = new System.Drawing.Point(328, 97);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(104, 44);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            // 
            // pBoxInicio
            // 
            this.pBoxInicio.Image = ((System.Drawing.Image)(resources.GetObject("pBoxInicio.Image")));
            this.pBoxInicio.Location = new System.Drawing.Point(309, 146);
            this.pBoxInicio.Name = "pBoxInicio";
            this.pBoxInicio.Size = new System.Drawing.Size(486, 421);
            this.pBoxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxInicio.TabIndex = 6;
            this.pBoxInicio.TabStop = false;
            // 
            // Hora_Fecha
            // 
            this.Hora_Fecha.Enabled = true;
            // 
            // DragControlAdm
            // 
            this.DragControlAdm.DockIndicatorTransparencyValue = 0.9D;
            this.DragControlAdm.DragStartTransparencyValue = 1D;
            this.DragControlAdm.TargetControl = this.panelTitulo;
            this.DragControlAdm.UseTransparentDrag = true;
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelVerticalMenu);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            this.SizeChanged += new System.EventHandler(this.FormAdministrador_SizeChanged);
            this.Resize += new System.EventHandler(this.FormAdministrador_Resize);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelVerticalMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelVerticalMenu;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelSeparador;
        private FontAwesome.Sharp.IconButton btnGestionProducto;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private FontAwesome.Sharp.IconButton btnDetalleVentas;
        private FontAwesome.Sharp.IconButton btnConfiguracion;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.PictureBox pBoxInicio;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TextBox txtBoxLogo;
        private System.Windows.Forms.Timer Hora_Fecha;
        private Guna.UI2.WinForms.Guna2DragControl DragControlAdm;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnGestionUsuario;
    }
}