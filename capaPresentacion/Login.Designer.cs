namespace capaPresentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBoxLibreria = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBiblioteca = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.pBoxContraseña = new System.Windows.Forms.PictureBox();
            this.pBoxUsuario = new System.Windows.Forms.PictureBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMostrarContraseña = new FontAwesome.Sharp.IconButton();
            this.txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.errorInicioUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorInicioContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLibreria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUsuario)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInicioUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInicioContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pBoxLibreria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBiblioteca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 278);
            this.panel1.TabIndex = 0;
            // 
            // pBoxLibreria
            // 
            this.pBoxLibreria.Image = ((System.Drawing.Image)(resources.GetObject("pBoxLibreria.Image")));
            this.pBoxLibreria.Location = new System.Drawing.Point(30, 84);
            this.pBoxLibreria.Name = "pBoxLibreria";
            this.pBoxLibreria.Size = new System.Drawing.Size(184, 139);
            this.pBoxLibreria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLibreria.TabIndex = 2;
            this.pBoxLibreria.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TODO A TU ALCANCE!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBiblioteca
            // 
            this.lblBiblioteca.AutoSize = true;
            this.lblBiblioteca.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiblioteca.ForeColor = System.Drawing.Color.White;
            this.lblBiblioteca.Location = new System.Drawing.Point(44, 19);
            this.lblBiblioteca.Name = "lblBiblioteca";
            this.lblBiblioteca.Size = new System.Drawing.Size(161, 24);
            this.lblBiblioteca.TabIndex = 0;
            this.lblBiblioteca.Text = "Libreria Moraes";
            this.lblBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.Location = new System.Drawing.Point(455, 100);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 22);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "DNI";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.White;
            this.lblContraseña.Location = new System.Drawing.Point(405, 154);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(119, 22);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // pBoxContraseña
            // 
            this.pBoxContraseña.Image = ((System.Drawing.Image)(resources.GetObject("pBoxContraseña.Image")));
            this.pBoxContraseña.Location = new System.Drawing.Point(307, 136);
            this.pBoxContraseña.Name = "pBoxContraseña";
            this.pBoxContraseña.Size = new System.Drawing.Size(80, 48);
            this.pBoxContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxContraseña.TabIndex = 6;
            this.pBoxContraseña.TabStop = false;
            // 
            // pBoxUsuario
            // 
            this.pBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pBoxUsuario.Image")));
            this.pBoxUsuario.Location = new System.Drawing.Point(307, 74);
            this.pBoxUsuario.Name = "pBoxUsuario";
            this.pBoxUsuario.Size = new System.Drawing.Size(80, 48);
            this.pBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxUsuario.TabIndex = 5;
            this.pBoxUsuario.TabStop = false;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(401, 18);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(254, 44);
            this.lblBienvenido.TabIndex = 7;
            this.lblBienvenido.Text = "Iniciar Sesión";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.LightGray;
            this.btnIngresar.Location = new System.Drawing.Point(459, 222);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(133, 33);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.TabStop = false;
            this.btnIngresar.Text = "Acceder";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMostrarContraseña);
            this.panel2.Controls.Add(this.txtContraseña);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.lblBienvenido);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.lblContraseña);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 278);
            this.panel2.TabIndex = 11;
            // 
            // btnMostrarContraseña
            // 
            this.btnMostrarContraseña.FlatAppearance.BorderSize = 0;
            this.btnMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnMostrarContraseña.IconColor = System.Drawing.Color.White;
            this.btnMostrarContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarContraseña.IconSize = 30;
            this.btnMostrarContraseña.Location = new System.Drawing.Point(733, 149);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(42, 31);
            this.btnMostrarContraseña.TabIndex = 16;
            this.btnMostrarContraseña.UseVisualStyleBackColor = true;
            this.btnMostrarContraseña.Click += new System.EventHandler(this.btnMostrarContraseña_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderThickness = 0;
            this.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContraseña.DefaultText = "";
            this.txtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContraseña.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.txtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtContraseña.ForeColor = System.Drawing.Color.White;
            this.txtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContraseña.Location = new System.Drawing.Point(530, 149);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtContraseña.PlaceholderText = "Ingrese Contraseña";
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.Size = new System.Drawing.Size(200, 30);
            this.txtContraseña.TabIndex = 15;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.BorderThickness = 0;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Location = new System.Drawing.Point(530, 100);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUsuario.PlaceholderText = "Ingrese DNI";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(200, 30);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 40;
            this.btnSalir.Location = new System.Drawing.Point(701, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 48);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorInicioUsuario
            // 
            this.errorInicioUsuario.ContainerControl = this;
            // 
            // errorInicioContraseña
            // 
            this.errorInicioContraseña.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(780, 278);
            this.Controls.Add(this.pBoxContraseña);
            this.Controls.Add(this.pBoxUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLibreria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUsuario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorInicioUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInicioContraseña)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBiblioteca;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.PictureBox pBoxUsuario;
        private System.Windows.Forms.PictureBox pBoxContraseña;
        private System.Windows.Forms.PictureBox pBoxLibreria;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.ErrorProvider errorInicioUsuario;
        private System.Windows.Forms.ErrorProvider errorInicioContraseña;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private FontAwesome.Sharp.IconButton btnMostrarContraseña;
    }
}