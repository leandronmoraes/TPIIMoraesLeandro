namespace capaPresentacion
{
    partial class listaProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblGestionProductos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.cmbBoxCategorias = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelContenedorProductos = new System.Windows.Forms.Panel();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.cmbFiltrarCategorias = new System.Windows.Forms.ComboBox();
            this.btnCambiarEstado = new FontAwesome.Sharp.IconButton();
            this.btnVerInactivos = new FontAwesome.Sharp.IconButton();
            this.dataGridProductos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.btnModificarProducto = new FontAwesome.Sharp.IconButton();
            this.btnEliminarProducto = new FontAwesome.Sharp.IconButton();
            this.pBoxImagenProducto = new System.Windows.Forms.PictureBox();
            this.panelContenedorProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(48, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(30, 85);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(95, 21);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 112);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 21);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(64, 189);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 21);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(68, 219);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(57, 21);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            // 
            // lblGestionProductos
            // 
            this.lblGestionProductos.AutoSize = true;
            this.lblGestionProductos.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblGestionProductos.ForeColor = System.Drawing.Color.White;
            this.lblGestionProductos.Location = new System.Drawing.Point(171, 23);
            this.lblGestionProductos.Name = "lblGestionProductos";
            this.lblGestionProductos.Size = new System.Drawing.Size(207, 22);
            this.lblGestionProductos.TabIndex = 9;
            this.lblGestionProductos.Text = "Gestión de Productos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 56);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(137, 112);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(265, 37);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(137, 219);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(265, 20);
            this.txtStock.TabIndex = 12;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(137, 189);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(265, 20);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.White;
            this.lblImagen.Location = new System.Drawing.Point(523, 23);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(205, 22);
            this.lblImagen.TabIndex = 16;
            this.lblImagen.Text = "Imagen del Producto";
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(562, 175);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(124, 41);
            this.btnImagen.TabIndex = 17;
            this.btnImagen.Text = "Seleccionar Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // cmbBoxCategorias
            // 
            this.cmbBoxCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCategorias.FormattingEnabled = true;
            this.cmbBoxCategorias.Items.AddRange(new object[] {
            "Comics",
            "Libros",
            "Mangas"});
            this.cmbBoxCategorias.Location = new System.Drawing.Point(137, 85);
            this.cmbBoxCategorias.Name = "cmbBoxCategorias";
            this.cmbBoxCategorias.Size = new System.Drawing.Size(265, 21);
            this.cmbBoxCategorias.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelContenedorProductos
            // 
            this.panelContenedorProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedorProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedorProductos.Controls.Add(this.lblFiltroCategoria);
            this.panelContenedorProductos.Controls.Add(this.cmbFiltrarCategorias);
            this.panelContenedorProductos.Controls.Add(this.btnCambiarEstado);
            this.panelContenedorProductos.Controls.Add(this.btnVerInactivos);
            this.panelContenedorProductos.Controls.Add(this.dataGridProductos);
            this.panelContenedorProductos.Controls.Add(this.cmbProveedor);
            this.panelContenedorProductos.Controls.Add(this.lblUsuario);
            this.panelContenedorProductos.Controls.Add(this.label1);
            this.panelContenedorProductos.Controls.Add(this.txtBuscarProducto);
            this.panelContenedorProductos.Controls.Add(this.btnAgregarProducto);
            this.panelContenedorProductos.Controls.Add(this.btnModificarProducto);
            this.panelContenedorProductos.Controls.Add(this.btnEliminarProducto);
            this.panelContenedorProductos.Controls.Add(this.lblGestionProductos);
            this.panelContenedorProductos.Controls.Add(this.lblStock);
            this.panelContenedorProductos.Controls.Add(this.cmbBoxCategorias);
            this.panelContenedorProductos.Controls.Add(this.lblPrecio);
            this.panelContenedorProductos.Controls.Add(this.txtPrecio);
            this.panelContenedorProductos.Controls.Add(this.lblDescripcion);
            this.panelContenedorProductos.Controls.Add(this.lblCategoria);
            this.panelContenedorProductos.Controls.Add(this.txtStock);
            this.panelContenedorProductos.Controls.Add(this.lblNombre);
            this.panelContenedorProductos.Controls.Add(this.btnImagen);
            this.panelContenedorProductos.Controls.Add(this.txtDescripcion);
            this.panelContenedorProductos.Controls.Add(this.txtNombre);
            this.panelContenedorProductos.Controls.Add(this.lblImagen);
            this.panelContenedorProductos.Controls.Add(this.pBoxImagenProducto);
            this.panelContenedorProductos.Location = new System.Drawing.Point(0, 0);
            this.panelContenedorProductos.Name = "panelContenedorProductos";
            this.panelContenedorProductos.Size = new System.Drawing.Size(1103, 612);
            this.panelContenedorProductos.TabIndex = 20;
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFiltroCategoria.ForeColor = System.Drawing.Color.White;
            this.lblFiltroCategoria.Location = new System.Drawing.Point(402, 260);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(86, 21);
            this.lblFiltroCategoria.TabIndex = 55;
            this.lblFiltroCategoria.Text = "Filtrar por:";
            // 
            // cmbFiltrarCategorias
            // 
            this.cmbFiltrarCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarCategorias.FormattingEnabled = true;
            this.cmbFiltrarCategorias.Items.AddRange(new object[] {
            "Comics",
            "Libros",
            "Mangas"});
            this.cmbFiltrarCategorias.Location = new System.Drawing.Point(494, 260);
            this.cmbFiltrarCategorias.Name = "cmbFiltrarCategorias";
            this.cmbFiltrarCategorias.Size = new System.Drawing.Size(218, 21);
            this.cmbFiltrarCategorias.TabIndex = 54;
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.IconChar = FontAwesome.Sharp.IconChar.UserClock;
            this.btnCambiarEstado.IconColor = System.Drawing.Color.Black;
            this.btnCambiarEstado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCambiarEstado.IconSize = 50;
            this.btnCambiarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarEstado.Location = new System.Drawing.Point(892, 86);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(144, 43);
            this.btnCambiarEstado.TabIndex = 53;
            this.btnCambiarEstado.Text = "Cambiar Estado";
            this.btnCambiarEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Visible = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // btnVerInactivos
            // 
            this.btnVerInactivos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerInactivos.IconColor = System.Drawing.Color.Black;
            this.btnVerInactivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerInactivos.Location = new System.Drawing.Point(991, 252);
            this.btnVerInactivos.Name = "btnVerInactivos";
            this.btnVerInactivos.Size = new System.Drawing.Size(100, 41);
            this.btnVerInactivos.TabIndex = 52;
            this.btnVerInactivos.Text = "Alternar Productos";
            this.btnVerInactivos.UseVisualStyleBackColor = true;
            this.btnVerInactivos.Click += new System.EventHandler(this.btnAlternarInactivos_Click);
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProductos.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridProductos.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridProductos.Location = new System.Drawing.Point(8, 307);
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.ReadOnly = true;
            this.dataGridProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridProductos.RowHeadersVisible = false;
            this.dataGridProductos.RowTemplate.Height = 40;
            this.dataGridProductos.Size = new System.Drawing.Size(1088, 300);
            this.dataGridProductos.TabIndex = 51;
            this.dataGridProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridProductos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridProductos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridProductos.ThemeStyle.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridProductos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridProductos.ThemeStyle.HeaderStyle.Height = 30;
            this.dataGridProductos.ThemeStyle.ReadOnly = true;
            this.dataGridProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridProductos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridProductos.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductos_CellDoubleClick);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Items.AddRange(new object[] {
            "Proveedor1",
            "Proveedor2",
            "Proveedor3"});
            this.cmbProveedor.Location = new System.Drawing.Point(137, 160);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(265, 21);
            this.cmbProveedor.TabIndex = 50;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(30, 160);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(94, 21);
            this.lblUsuario.TabIndex = 49;
            this.lblUsuario.Text = "Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarProducto.DefaultText = "";
            this.txtBuscarProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarProducto.Location = new System.Drawing.Point(137, 260);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.PlaceholderText = "Nombre Producto";
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.Size = new System.Drawing.Size(218, 21);
            this.txtBuscarProducto.TabIndex = 33;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnAgregarProducto.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProducto.IconSize = 40;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(892, 35);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(144, 42);
            this.btnAgregarProducto.TabIndex = 26;
            this.btnAgregarProducto.Text = "Añadir Producto";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnModificarProducto.IconColor = System.Drawing.Color.Black;
            this.btnModificarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarProducto.IconSize = 50;
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.Location = new System.Drawing.Point(892, 138);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(144, 43);
            this.btnModificarProducto.TabIndex = 25;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.btnEliminarProducto.IconColor = System.Drawing.Color.Black;
            this.btnEliminarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProducto.IconSize = 50;
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(892, 86);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(144, 44);
            this.btnEliminarProducto.TabIndex = 24;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // pBoxImagenProducto
            // 
            this.pBoxImagenProducto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pBoxImagenProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxImagenProducto.Location = new System.Drawing.Point(510, 48);
            this.pBoxImagenProducto.Name = "pBoxImagenProducto";
            this.pBoxImagenProducto.Size = new System.Drawing.Size(231, 121);
            this.pBoxImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImagenProducto.TabIndex = 15;
            this.pBoxImagenProducto.TabStop = false;
            // 
            // listaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 612);
            this.Controls.Add(this.panelContenedorProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "listaProductos";
            this.Text = "Gestión Productos";
            this.Load += new System.EventHandler(this.listaProductos_Load);
            this.panelContenedorProductos.ResumeLayout(false);
            this.panelContenedorProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImagenProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblGestionProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.PictureBox pBoxImagenProducto;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.ComboBox cmbBoxCategorias;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelContenedorProductos;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private FontAwesome.Sharp.IconButton btnModificarProducto;
        private FontAwesome.Sharp.IconButton btnEliminarProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridProductos;
        
        private FontAwesome.Sharp.IconButton btnVerInactivos;
        private FontAwesome.Sharp.IconButton btnCambiarEstado;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.ComboBox cmbFiltrarCategorias;
    }
}