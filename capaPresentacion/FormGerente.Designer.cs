namespace capaPresentacion
{
    partial class FormGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerente));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSeparador = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.txtBoxLogo = new System.Windows.Forms.TextBox();
            this.btnGestionPedidos = new FontAwesome.Sharp.IconButton();
            this.btnReportesVentas = new FontAwesome.Sharp.IconButton();
            this.btnGestionProveedor = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.btnCerrarSesion = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pBoxInicio = new System.Windows.Forms.PictureBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelMenuLateral.SuspendLayout();
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
            this.panelTitulo.Controls.Add(this.lblVendedor);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1300, 38);
            this.panelTitulo.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::capaPresentacion.Properties.Resources.minimizar_ventana;
            this.btnMinimizar.Location = new System.Drawing.Point(1225, -10);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 32);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::capaPresentacion.Properties.Resources.cruz;
            this.btnCerrar.Location = new System.Drawing.Point(1265, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVendedor.Location = new System.Drawing.Point(12, 15);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(147, 20);
            this.lblVendedor.TabIndex = 0;
            this.lblVendedor.Text = "Formulario Gerente";
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenuLateral.Controls.Add(this.panel3);
            this.panelMenuLateral.Controls.Add(this.panel2);
            this.panelMenuLateral.Controls.Add(this.panel1);
            this.panelMenuLateral.Controls.Add(this.panelSeparador);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Controls.Add(this.btnGestionPedidos);
            this.panelMenuLateral.Controls.Add(this.btnReportesVentas);
            this.panelMenuLateral.Controls.Add(this.btnGestionProveedor);
            this.panelMenuLateral.Controls.Add(this.btnInicio);
            this.panelMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 38);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(197, 612);
            this.panelMenuLateral.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 1);
            this.panel1.TabIndex = 6;
            // 
            // panelSeparador
            // 
            this.panelSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelSeparador.Location = new System.Drawing.Point(0, 150);
            this.panelSeparador.Name = "panelSeparador";
            this.panelSeparador.Size = new System.Drawing.Size(196, 1);
            this.panelSeparador.TabIndex = 25;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pBoxLogo);
            this.panelLogo.Controls.Add(this.txtBoxLogo);
            this.panelLogo.Location = new System.Drawing.Point(0, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(197, 74);
            this.panelLogo.TabIndex = 24;
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
            // btnGestionPedidos
            // 
            this.btnGestionPedidos.FlatAppearance.BorderSize = 0;
            this.btnGestionPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnGestionPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPedidos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPedidos.ForeColor = System.Drawing.Color.White;
            this.btnGestionPedidos.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnGestionPedidos.IconColor = System.Drawing.Color.White;
            this.btnGestionPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionPedidos.IconSize = 40;
            this.btnGestionPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionPedidos.Location = new System.Drawing.Point(1, 204);
            this.btnGestionPedidos.Name = "btnGestionPedidos";
            this.btnGestionPedidos.Size = new System.Drawing.Size(196, 42);
            this.btnGestionPedidos.TabIndex = 23;
            this.btnGestionPedidos.Text = "Gestión Pedidos";
            this.btnGestionPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionPedidos.UseVisualStyleBackColor = true;
            this.btnGestionPedidos.Click += new System.EventHandler(this.btnGestionPedidos_Click);
            // 
            // btnReportesVentas
            // 
            this.btnReportesVentas.FlatAppearance.BorderSize = 0;
            this.btnReportesVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnReportesVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesVentas.ForeColor = System.Drawing.Color.White;
            this.btnReportesVentas.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.btnReportesVentas.IconColor = System.Drawing.Color.White;
            this.btnReportesVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportesVentas.IconSize = 40;
            this.btnReportesVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesVentas.Location = new System.Drawing.Point(3, 254);
            this.btnReportesVentas.Name = "btnReportesVentas";
            this.btnReportesVentas.Size = new System.Drawing.Size(197, 42);
            this.btnReportesVentas.TabIndex = 19;
            this.btnReportesVentas.Text = "Reportes Ventas";
            this.btnReportesVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportesVentas.UseVisualStyleBackColor = true;
            this.btnReportesVentas.Click += new System.EventHandler(this.btnReportesVentas_Click);
            // 
            // btnGestionProveedor
            // 
            this.btnGestionProveedor.FlatAppearance.BorderSize = 0;
            this.btnGestionProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnGestionProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionProveedor.ForeColor = System.Drawing.Color.White;
            this.btnGestionProveedor.IconChar = FontAwesome.Sharp.IconChar.PeopleCarryBox;
            this.btnGestionProveedor.IconColor = System.Drawing.Color.White;
            this.btnGestionProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGestionProveedor.IconSize = 40;
            this.btnGestionProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionProveedor.Location = new System.Drawing.Point(0, 154);
            this.btnGestionProveedor.Name = "btnGestionProveedor";
            this.btnGestionProveedor.Size = new System.Drawing.Size(196, 42);
            this.btnGestionProveedor.TabIndex = 17;
            this.btnGestionProveedor.Text = "Gestión Proveedor";
            this.btnGestionProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestionProveedor.UseVisualStyleBackColor = true;
            this.btnGestionProveedor.Click += new System.EventHandler(this.btnGestionProveedor_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 40;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 100);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(198, 42);
            this.btnInicio.TabIndex = 10;
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
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 569);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(196, 43);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Controls.Add(this.pBoxInicio);
            this.panelContenedor.Controls.Add(this.lblMensaje);
            this.panelContenedor.Controls.Add(this.lblFecha);
            this.panelContenedor.Controls.Add(this.lblHora);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(197, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1103, 612);
            this.panelContenedor.TabIndex = 4;
            // 
            // pBoxInicio
            // 
            this.pBoxInicio.Image = ((System.Drawing.Image)(resources.GetObject("pBoxInicio.Image")));
            this.pBoxInicio.Location = new System.Drawing.Point(241, 158);
            this.pBoxInicio.Name = "pBoxInicio";
            this.pBoxInicio.Size = new System.Drawing.Size(560, 391);
            this.pBoxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxInicio.TabIndex = 6;
            this.pBoxInicio.TabStop = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(298, 12);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(503, 58);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Bienvenido Gerente!";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.lblFecha.ForeColor = System.Drawing.Color.Purple;
            this.lblFecha.Location = new System.Drawing.Point(316, 70);
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
            this.lblHora.Location = new System.Drawing.Point(455, 111);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(104, 44);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.DragStartTransparencyValue = 1D;
            this.guna2DragControl1.TargetControl = this.panelTitulo;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 1);
            this.panel3.TabIndex = 6;
            // 
            // FormGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGerente";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelMenuLateral.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Panel panelMenuLateral;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnCerrarSesion;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private FontAwesome.Sharp.IconButton btnGestionProveedor;
        private FontAwesome.Sharp.IconButton btnReportesVentas;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox pBoxInicio;
        private System.Windows.Forms.Timer HoraFecha;
        private FontAwesome.Sharp.IconButton btnGestionPedidos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pBoxLogo;
        private System.Windows.Forms.TextBox txtBoxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSeparador;
        private System.Windows.Forms.Panel panel3;
    }
}