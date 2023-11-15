namespace capaPresentacion
{
    partial class formVenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.fechaHastaPicker = new System.Windows.Forms.DateTimePicker();
            this.fechaDesdePicker = new System.Windows.Forms.DateTimePicker();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridVenta = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_tipo_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblFechaHasta);
            this.panel1.Controls.Add(this.lblFechaDesde);
            this.panel1.Controls.Add(this.fechaHastaPicker);
            this.panel1.Controls.Add(this.fechaDesdePicker);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridVenta);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 612);
            this.panel1.TabIndex = 0;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaHasta.ForeColor = System.Drawing.Color.White;
            this.lblFechaHasta.Location = new System.Drawing.Point(715, 88);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(73, 15);
            this.lblFechaHasta.TabIndex = 44;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFechaDesde.ForeColor = System.Drawing.Color.White;
            this.lblFechaDesde.Location = new System.Drawing.Point(482, 88);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(77, 15);
            this.lblFechaDesde.TabIndex = 43;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // fechaHastaPicker
            // 
            this.fechaHastaPicker.Location = new System.Drawing.Point(647, 106);
            this.fechaHastaPicker.Name = "fechaHastaPicker";
            this.fechaHastaPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaHastaPicker.TabIndex = 42;
            this.fechaHastaPicker.ValueChanged += new System.EventHandler(this.fechaHastaPicker_ValueChanged);
            // 
            // fechaDesdePicker
            // 
            this.fechaDesdePicker.Location = new System.Drawing.Point(416, 106);
            this.fechaDesdePicker.Name = "fechaDesdePicker";
            this.fechaDesdePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDesdePicker.TabIndex = 41;
            this.fechaDesdePicker.ValueChanged += new System.EventHandler(this.fechaDesdePicker_ValueChanged);
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
            this.txtBuscar.Location = new System.Drawing.Point(159, 108);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "DNI cliente";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(154, 22);
            this.txtBuscar.TabIndex = 33;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADO DE VENTAS (VENDEDOR)";
            // 
            // dataGridVenta
            // 
            this.dataGridVenta.AllowUserToAddRows = false;
            this.dataGridVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.id_venta,
            this.nombre_cliente,
            this.fecha_venta,
            this.total_venta,
            this.descripcion_tipo_pago,
            this.detalles});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridVenta.Location = new System.Drawing.Point(3, 136);
            this.dataGridVenta.Name = "dataGridVenta";
            this.dataGridVenta.ReadOnly = true;
            this.dataGridVenta.RowHeadersVisible = false;
            this.dataGridVenta.Size = new System.Drawing.Size(1117, 473);
            this.dataGridVenta.TabIndex = 1;
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
            this.dataGridVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVenta_CellContentClick);
            // 
            // id_venta
            // 
            this.id_venta.HeaderText = "ID_Venta";
            this.id_venta.Name = "id_venta";
            this.id_venta.ReadOnly = true;
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.HeaderText = "ID_Cliente";
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.ReadOnly = true;
            // 
            // fecha_venta
            // 
            this.fecha_venta.HeaderText = "Fecha_Venta";
            this.fecha_venta.Name = "fecha_venta";
            this.fecha_venta.ReadOnly = true;
            // 
            // total_venta
            // 
            this.total_venta.HeaderText = "Total";
            this.total_venta.Name = "total_venta";
            this.total_venta.ReadOnly = true;
            // 
            // descripcion_tipo_pago
            // 
            this.descripcion_tipo_pago.HeaderText = "Forma de pago";
            this.descripcion_tipo_pago.Name = "descripcion_tipo_pago";
            this.descripcion_tipo_pago.ReadOnly = true;
            // 
            // detalles
            // 
            this.detalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detalles.HeaderText = "Detalles Venta";
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            this.detalles.Text = "Detalles";
            this.detalles.UseColumnTextForButtonValue = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(63, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // formVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 612);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listaVentas";
            this.Load += new System.EventHandler(this.formVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridVenta;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker fechaHastaPicker;
        private System.Windows.Forms.DateTimePicker fechaDesdePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_tipo_pago;
        private System.Windows.Forms.DataGridViewButtonColumn detalles;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}