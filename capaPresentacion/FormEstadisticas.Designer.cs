
namespace capaPresentacion
{
    partial class FormEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GridCompras = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TFecha = new System.Windows.Forms.DateTimePicker();
            this.THasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarFecha = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportarPDF = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(777, 97);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart1";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(24, 97);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estadisticas y Reportes de Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mejores Vendedores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(829, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Productos Más Vendidos";
            // 
            // GridCompras
            // 
            this.GridCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.GridCompras.ColumnHeadersHeight = 25;
            this.GridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCompras.DefaultCellStyle = dataGridViewCellStyle11;
            this.GridCompras.GridColor = System.Drawing.Color.White;
            this.GridCompras.Location = new System.Drawing.Point(8, 418);
            this.GridCompras.Name = "GridCompras";
            this.GridCompras.ReadOnly = true;
            this.GridCompras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GridCompras.RowHeadersVisible = false;
            this.GridCompras.Size = new System.Drawing.Size(1075, 150);
            this.GridCompras.TabIndex = 7;
            this.GridCompras.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.GridCompras.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(199)))), ((int)(((byte)(195)))));
            this.GridCompras.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridCompras.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GridCompras.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridCompras.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridCompras.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridCompras.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.GridCompras.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.GridCompras.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridCompras.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridCompras.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridCompras.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridCompras.ThemeStyle.HeaderStyle.Height = 25;
            this.GridCompras.ThemeStyle.ReadOnly = true;
            this.GridCompras.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(217)))), ((int)(((byte)(215)))));
            this.GridCompras.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridCompras.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridCompras.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridCompras.ThemeStyle.RowsStyle.Height = 22;
            this.GridCompras.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(129)))), ((int)(((byte)(121)))));
            this.GridCompras.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // TFecha
            // 
            this.TFecha.Location = new System.Drawing.Point(340, 97);
            this.TFecha.Name = "TFecha";
            this.TFecha.Size = new System.Drawing.Size(200, 20);
            this.TFecha.TabIndex = 8;
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(571, 97);
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(200, 20);
            this.THasta.TabIndex = 9;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarFecha.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscarFecha.IconColor = System.Drawing.Color.Black;
            this.btnBuscarFecha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarFecha.Location = new System.Drawing.Point(483, 138);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(142, 40);
            this.btnBuscarFecha.TabIndex = 10;
            this.btnBuscarFecha.Text = "Filtrar por Fecha";
            this.btnBuscarFecha.UseVisualStyleBackColor = true;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mayores Ventas";
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExportarPDF.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportarPDF.IconColor = System.Drawing.Color.Black;
            this.btnExportarPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportarPDF.Location = new System.Drawing.Point(455, 212);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(198, 53);
            this.btnExportarPDF.TabIndex = 12;
            this.btnExportarPDF.Text = "Exportar gráficos como PDF";
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click_1);
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1089, 576);
            this.Controls.Add(this.btnExportarPDF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TFecha);
            this.Controls.Add(this.GridCompras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView GridCompras;
        private System.Windows.Forms.DateTimePicker TFecha;
        private System.Windows.Forms.DateTimePicker THasta;
        private FontAwesome.Sharp.IconButton btnBuscarFecha;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnExportarPDF;
    }
}