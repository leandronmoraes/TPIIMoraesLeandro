namespace capaPresentacion
{
    partial class listaDetalleVenta
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
            this.dgvDetalleVenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtIDVenta = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_horaFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.txtDniVendedor = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.btnGuardarPDF = new FontAwesome.Sharp.IconButton();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleVenta
            // 
            this.dgvDetalleVenta.AllowUserToAddRows = false;
            this.dgvDetalleVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalleVenta.ColumnHeadersHeight = 15;
            this.dgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.cantidad,
            this.precioUnitario,
            this.subtotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalleVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleVenta.Location = new System.Drawing.Point(8, 227);
            this.dgvDetalleVenta.Name = "dgvDetalleVenta";
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.RowHeadersVisible = false;
            this.dgvDetalleVenta.Size = new System.Drawing.Size(1072, 245);
            this.dgvDetalleVenta.TabIndex = 0;
            this.dgvDetalleVenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetalleVenta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleVenta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetalleVenta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetalleVenta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetalleVenta.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvDetalleVenta.ThemeStyle.ReadOnly = true;
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDetalleVenta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.precioUnitario.HeaderText = "Precio Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(215, 102);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.ReadOnly = true;
            this.txtDniCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDniCliente.TabIndex = 1;
            // 
            // txtIDVenta
            // 
            this.txtIDVenta.Location = new System.Drawing.Point(215, 51);
            this.txtIDVenta.Name = "txtIDVenta";
            this.txtIDVenta.ReadOnly = true;
            this.txtIDVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIDVenta.TabIndex = 2;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(215, 76);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID_Venta";
            // 
            // lbl_horaFecha
            // 
            this.lbl_horaFecha.AutoSize = true;
            this.lbl_horaFecha.Location = new System.Drawing.Point(962, 53);
            this.lbl_horaFecha.Name = "lbl_horaFecha";
            this.lbl_horaFecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_horaFecha.TabIndex = 10;
            this.lbl_horaFecha.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vendedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "DNI Vendedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Dirección";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(641, 90);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.ReadOnly = true;
            this.txtNombreVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreVendedor.TabIndex = 15;
            // 
            // txtDniVendedor
            // 
            this.txtDniVendedor.Location = new System.Drawing.Point(641, 116);
            this.txtDniVendedor.Name = "txtDniVendedor";
            this.txtDniVendedor.ReadOnly = true;
            this.txtDniVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtDniVendedor.TabIndex = 16;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(975, 202);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(938, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(381, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 21);
            this.label12.TabIndex = 20;
            this.label12.Text = "ID_Vendedor";
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Location = new System.Drawing.Point(641, 55);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.ReadOnly = true;
            this.txtIdVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtIdVendedor.TabIndex = 21;
            // 
            // btnGuardarPDF
            // 
            this.btnGuardarPDF.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardarPDF.IconColor = System.Drawing.Color.Black;
            this.btnGuardarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPDF.Location = new System.Drawing.Point(809, 197);
            this.btnGuardarPDF.Name = "btnGuardarPDF";
            this.btnGuardarPDF.Size = new System.Drawing.Size(123, 29);
            this.btnGuardarPDF.TabIndex = 22;
            this.btnGuardarPDF.Text = "Guardar como PDF";
            this.btnGuardarPDF.UseVisualStyleBackColor = true;
            this.btnGuardarPDF.Click += new System.EventHandler(this.btnGuardarPDF_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1087, 38);
            this.panelTitulo.TabIndex = 23;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::capaPresentacion.Properties.Resources.minimizar_ventana;
            this.btnMinimizar.Location = new System.Drawing.Point(1014, -10);
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
            this.btnCerrar.Location = new System.Drawing.Point(1052, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(216, 135);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionCliente.TabIndex = 24;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.DragStartTransparencyValue = 1D;
            this.guna2DragControl2.TargetControl = this.panelTitulo;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // listaDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 477);
            this.Controls.Add(this.txtDireccionCliente);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.btnGuardarPDF);
            this.Controls.Add(this.txtIdVendedor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDniVendedor);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_horaFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIDVenta);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.dgvDetalleVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listaDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listaDetalleVentas";
            this.Load += new System.EventHandler(this.listaDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDetalleVenta;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtIDVenta;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_horaFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.TextBox txtDniVendedor;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdVendedor;
        private FontAwesome.Sharp.IconButton btnGuardarPDF;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}