using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos.Models;
using capaNegocio;


namespace capaPresentacion
{
    public partial class listaProductos : Form
    {

        private Image imagenPorDefecto;
        private CN_Producto cnProducto; // Capa de negocio para productos
        private List<producto> productos;

        public listaProductos()
        {
            InitializeComponent();
            btnEliminarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
            // Establecer SelectedIndex en -1 para ambos ComboBox para que no tenga nada seleccionado
            cmbBoxCategorias.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            imagenPorDefecto = Properties.Resources.producto_pbox;

            // Inicializa la capa de negocio de productos
            cnProducto = new CN_Producto();

            // Carga la lista de proveedores en el ComboBox al cargar el formulario
            
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
            // Agregar el evento SelectedIndexChanged al ComboBox
            cmbFiltrarCategorias.SelectedIndexChanged += CmbFiltrarCategorias_SelectedIndexChanged;

        }
        private void CmbFiltrarCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para filtrar el DataGridView por la categoría seleccionada
            FiltrarProductosPorCategoria();


        }
        private void FiltrarProductosPorCategoria()
        {
            // Obtén la categoría seleccionada en el ComboBox
            string categoriaSeleccionada = cmbFiltrarCategorias.Text;

            // Filtra la fuente de datos actual en base a la categoría seleccionada
            var productosFiltrados = fuenteDatosActual
                .Where(p => ObtenerNombreCategoria(p.id_categoria).Equals(categoriaSeleccionada, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Muestra los productos filtrados en el DataGridView
            dataGridProductos.DataSource = productosFiltrados;

            // Ajusta el tamaño de la columna de la imagen después de cargar los productos
            AjustarColumnaImagen();

            dataGridProductos.Columns["pedido"].Visible = false;
            dataGridProductos.Columns["venta_detalle"].Visible = false;
            dataGridProductos.Columns["categoria"].Visible = false;
            dataGridProductos.Columns["proveedor"].Visible = false;

            dataGridProductos.Columns["id_producto"].HeaderText = "ID";
            dataGridProductos.Columns["nombre_producto"].HeaderText = "Nombre";
            dataGridProductos.Columns["descripcion_producto"].HeaderText = "Descripción";
            dataGridProductos.Columns["Categoria"].HeaderText = "Categoría";
            dataGridProductos.Columns["Proveedor"].HeaderText = "Proveedor";
            dataGridProductos.Columns["precio_producto"].HeaderText = "Precio";
            dataGridProductos.Columns["stock_producto"].HeaderText = "Stock";
            dataGridProductos.Columns["imagen_producto"].HeaderText = "Imagen";

          
        }
        //Método Load
        private void listaProductos_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            cmbBoxCategorias.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            // Configura la propiedad WrapMode para permitir el ajuste de texto
            dataGridProductos.Columns["descripcion_producto"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void CargarCategorias()
        {
            using (ProyectoTPII_MoraesLeandroEntities dbContext = new ProyectoTPII_MoraesLeandroEntities())
            {
                var categorias = dbContext.categoria.Select(c => new { c.descripcion_categoria, c.id_categoria }).ToList();
                cmbBoxCategorias.DisplayMember = "descripcion_categoria";
                cmbBoxCategorias.ValueMember = "id_categoria";
                cmbBoxCategorias.DataSource = categorias;
            }
        }

        private void CargarProveedores()
        {
            using (ProyectoTPII_MoraesLeandroEntities dbContext = new ProyectoTPII_MoraesLeandroEntities())
            {
                var proveedores = dbContext.proveedor.Select(p => new { p.nombre_proveedor }).ToList();
                cmbProveedor.DisplayMember = "nombre_proveedor";
                cmbProveedor.ValueMember = "nombre_proveedor";
                cmbProveedor.DataSource = proveedores;
            }
        }

        private void CargarProductos()
        {
            productos = cnProducto.ObtenerProductos();
            fuenteDatosActual = productos;


            // Redimensiona las imágenes antes de asignarlas al DataGridView
            foreach (var producto in productos)
            {
                if (producto.imagen_producto != null)
                {
                    // Redimensiona la imagen solo al cargarla inicialmente
                    producto.imagen_producto = ImageToByteArray(RedimensionarImagen(ByteArrayToImage(producto.imagen_producto), 50, 50), ImageFormat.Jpeg);
                }
            }


            // Mapear el ID de la categoría y del proveedor a sus nombres correspondientes
            var productosConNombres = productos.Select(p => new
            {
                p.id_producto,
                p.imagen_producto,
                p.nombre_producto,
                p.descripcion_producto,
                p.categoria.descripcion_categoria,
                p.proveedor.nombre_proveedor,
                p.precio_producto,
                p.stock_producto,
                
                
            }).ToList();

            
            dataGridProductos.DataSource = productosConNombres;

            // Después de cargar los productos en el DataGridView
            dataGridProductos.Columns["id_producto"].Width = 50; // Ajusta el valor según tus necesidades
            dataGridProductos.Columns["descripcion_producto"].Width = 400;
             // Ajustar específicamente la columna de imagen
             dataGridProductos.Columns["imagen_producto"].Width = 100; // Ajusta según tus necesidades
            dataGridProductos.Columns["id_producto"].HeaderText = "ID";
            dataGridProductos.Columns["nombre_producto"].HeaderText = "Nombre";
            dataGridProductos.Columns["descripcion_producto"].HeaderText = "Descripción";
            dataGridProductos.Columns["descripcion_categoria"].HeaderText = "Categoría";
            dataGridProductos.Columns["nombre_proveedor"].HeaderText = "Proveedor";
            dataGridProductos.Columns["precio_producto"].HeaderText = "Precio";
            dataGridProductos.Columns["stock_producto"].HeaderText = "Stock";
            dataGridProductos.Columns["imagen_producto"].HeaderText = "Imagen";

            // Obtén el ancho disponible para las imágenes en el DataGridView
            int anchoDisponible = dataGridProductos.Columns["imagen_producto"].Width;
            // Ajusta la columna de la imagen después de cargar los productos
            AjustarColumnaImagen();
            // Ajusta el tamaño de la columna de la imagen para que la imagen ocupe todo el ancho disponible
            AjustarAnchoColumnaImagen(anchoDisponible);

        }

        private void AjustarAnchoColumnaImagen(int anchoDisponible)
        {
            // Asegúrate de que haya al menos una fila en el DataGridView
            if (dataGridProductos.Rows.Count > 0)
            {
                // Obtén la primera fila y la primera celda de la columna de imágenes
                DataGridViewImageCell cell = (DataGridViewImageCell)dataGridProductos.Rows[0].Cells["imagen_producto"];

                // Calcula el nuevo tamaño de la imagen para que ocupe todo el ancho disponible
                int nuevoAncho = anchoDisponible - cell.OwningColumn.DividerWidth;

                // Ajusta el valor de la propiedad DefaultCellStyle.NullValue para que la imagen se ajuste al PictureBox
                cell.OwningColumn.DefaultCellStyle.NullValue = null;

                // Ajusta el tamaño de la columna para que coincida con el tamaño de la imagen
                cell.OwningColumn.Width = nuevoAncho;
            }
        }

        private string ObtenerNombreCategoria(int? idCategoria)
        {
            if (idCategoria.HasValue)
            {
                using (ProyectoTPII_MoraesLeandroEntities dbContext = new ProyectoTPII_MoraesLeandroEntities())
                {
                    var categoria = dbContext.categoria.FirstOrDefault(c => c.id_categoria == idCategoria);
                    return categoria?.descripcion_categoria ?? "Categoría no encontrada";
                }
            }
            else
            {
                return "Sin categoría"; // O cualquier valor por defecto que desees mostrar para IDs de categoría nulos
            }
        }

        private string ObtenerNombreProveedor(int? idProveedor)
        {
            if (idProveedor.HasValue)
            {
                using (ProyectoTPII_MoraesLeandroEntities dbContext = new ProyectoTPII_MoraesLeandroEntities())
                {
                    var proveedor = dbContext.proveedor.FirstOrDefault(p => p.id_proveedor == idProveedor);
                    return proveedor?.nombre_proveedor ?? "Proveedor no encontrado";
                }
            }
            else
            {
                return "Sin proveedor"; // O cualquier valor por defecto que desees mostrar para IDs de proveedor nulos
            }
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string categoria = cmbBoxCategorias.Text;
            string descripcion = txtDescripcion.Text;
            string proveedor = cmbProveedor.Text;
            decimal precio;
            int stock;

            if (decimal.TryParse(txtPrecio.Text, out precio) && precio > 0 &&
            int.TryParse(txtStock.Text, out stock) && stock > 0)
            {
                try
                {
                    byte[] imagenBytes = null;
                    if (pBoxImagenProducto.Image != null)
                    {
                        // Ajusta la calidad al guardar la imagen en formato JPEG
                        imagenBytes = ImageToByteArrayWithQuality(pBoxImagenProducto.Image, 90);
                    }

                    producto nuevoProducto = new producto
                    {
                        nombre_producto = nombre,
                        descripcion_producto = descripcion,
                        precio_producto = precio,
                        stock_producto = stock,
                        imagen_producto = imagenBytes

                    };

                    cnProducto.AgregarProducto(nuevoProducto, categoria, proveedor);

                    // Después de cargar los productos en el DataGridView
                    //dataGridProductos.Columns["imagen_producto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                    // Ajusta el tamaño de la columna de la imagen para que la imagen sea más grande
                    dataGridProductos.Columns["imagen_producto"].Width = 60; // Puedes ajustar este valor según tus necesidades

                    // Ajusta la columna de la imagen después de cargar los productos
                    AjustarColumnaImagen();

                    // Limpiar campos y recargar la lista de productos
                    LimpiarCampos();
                    CargarProductos();
                    cmbBoxCategorias.SelectedIndex = -1;
                    cmbProveedor.SelectedIndex = -1;

                    MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, comprobar los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtNombre.Text;
            string categoria = cmbBoxCategorias.Text;
            string descripcion = txtDescripcion.Text;
            string proveedor = cmbProveedor.Text;
            decimal precio;
            int stock;
            int productoId;

            if (int.TryParse(dataGridProductos.CurrentRow.Cells["id_producto"].Value.ToString(), out productoId) &&
                decimal.TryParse(txtPrecio.Text, out precio) && int.TryParse(txtStock.Text, out stock))
            {
                try
                {
                    byte[] imagenBytes = null;
                    if (pBoxImagenProducto.Image != null)
                    {
                        imagenBytes = ImageToByteArrayWithQuality(pBoxImagenProducto.Image, 90);
                    }

                    producto productoModificado = new producto
                    {
                        id_producto = productoId,
                        nombre_producto = nombre,
                        descripcion_producto = descripcion,
                        precio_producto = precio,
                        stock_producto = stock,
                        imagen_producto = imagenBytes
                    };

                    // Modificar el producto usando la capa de negocio
                    cnProducto.ModificarProducto(productoModificado, categoria, proveedor);

                    // Ajusta el tamaño de la columna de la imagen para que la imagen sea más grande
                    dataGridProductos.Columns["imagen_producto"].Width = 100; // Puedes ajustar este valor según tus necesidades

                    // Ajusta la columna de la imagen después de cargar los productos
                    AjustarColumnaImagen();

                    // Limpiar campos y recargar la lista de productos
                    LimpiarCampos();
                    CargarProductos();  // Aquí es donde cargas nuevamente los productos después de la modificación

                    MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un precio y stock válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto antes de intentar eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int productoId;
                if (int.TryParse(dataGridProductos.CurrentRow.Cells["id_producto"].Value.ToString(), out productoId))
                {
                    try
                    {
                        cnProducto.DarDeBajaProducto(productoId);

                        // Limpiar campos y recargar la lista de productos
                        LimpiarCampos();
                        CargarProductos();

                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID de producto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //KeyPress
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras (mayúsculas y minúsculas), números y espacios
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //

        // Método para convertir una imagen a un arreglo de bytes con calidad ajustable
        private byte[] ImageToByteArrayWithQuality(Image image, long quality)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                System.Drawing.Imaging.EncoderParameters encoderParameters = new System.Drawing.Imaging.EncoderParameters(1);
                encoderParameters.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

                // Guarda la imagen en formato JPEG con la calidad especificada
                ImageCodecInfo jpegCodec = GetEncoderInfo(ImageFormat.Jpeg);
                image.Save(ms, jpegCodec, encoderParameters);

                return ms.ToArray();
            }
        }

        // Método para obtener el ImageCodecInfo para un formato de imagen específico
        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageEncoders().FirstOrDefault(codec => codec.FormatID == format.Guid);
        }


        //
        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagenProd = new OpenFileDialog();

            if (imagenProd.ShowDialog() == DialogResult.OK)
            {
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
                string selectedExtension = Path.GetExtension(imagenProd.FileName);

                if (Array.Exists(allowedExtensions, ext => ext.Equals(selectedExtension, StringComparison.OrdinalIgnoreCase)))
                {
                    pBoxImagenProducto.BackgroundImage = null;
                    pBoxImagenProducto.Image = Image.FromFile(imagenProd.FileName);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un archivo de imagen válido (jpg, jpeg, png, gif o bmp).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridProductos.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridProductos.Rows[e.RowIndex];

                int productoId = (int)selectedRow.Cells["id_producto"].Value;

                using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                {
                    var productoSeleccionado = db.producto.FirstOrDefault(p => p.id_producto == productoId);

                    if (productoSeleccionado != null)
                    {
                        // Obtén la imagen original desde la base de datos
                        Image imagenOriginal = ByteArrayToImage(productoSeleccionado.imagen_producto);

                        // Muestra la imagen original en el PictureBox sin redimensionar
                        pBoxImagenProducto.Image = imagenOriginal;

                        pBoxImagenProducto.Image = imagenOriginal;
                        txtNombre.Text = productoSeleccionado.nombre_producto;
                        txtDescripcion.Text = productoSeleccionado.descripcion_producto;
                        cmbBoxCategorias.SelectedValue = productoSeleccionado.id_categoria;
                        txtPrecio.Text = productoSeleccionado.precio_producto.ToString();
                        txtStock.Text = productoSeleccionado.stock_producto.ToString();

                        var proveedor = db.proveedor.FirstOrDefault(p => p.id_proveedor == productoSeleccionado.id_proveedor);
                        if (proveedor != null)
                        {
                            cmbProveedor.Text = proveedor.nombre_proveedor;
                        }

                        btnEliminarProducto.Enabled = true;
                        btnModificarProducto.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El producto seleccionado no se encuentra en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        // Método para convertir un byte array en una imagen
        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            return null;
        }

        //Método para convertir una imagen a un arreglo de bytes.
        private byte[] ImageToByteArray(Image image, ImageFormat format)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Guarda la imagen en el formato especificado
                    image.Save(ms, format);
                    return ms.ToArray();
                }
            }
            return null;
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            pBoxImagenProducto.Image = imagenPorDefecto;
            btnEliminarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;

            // Habilita la edición de los campos del formulario
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            cmbBoxCategorias.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;
            cmbProveedor.Enabled = true;
        }

        private Image RedimensionarImagen(Image originalImage, int nuevoAncho, int nuevoAlto)
        {
            Bitmap imagenRedimensionada = new Bitmap(nuevoAncho, nuevoAlto);

            using (Graphics graficos = Graphics.FromImage(imagenRedimensionada))
            {
                graficos.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graficos.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graficos.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                graficos.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                graficos.DrawImage(originalImage, 0, 0, nuevoAncho, nuevoAlto);
            }

            return imagenRedimensionada;
        }

        private void AjustarColumnaImagen()
        {
            // Asegúrate de que haya al menos una fila en el DataGridView
            if (dataGridProductos.Rows.Count > 0)
            {
                // Obtén la primera fila y la primera celda de la columna de imágenes
                DataGridViewImageCell cell = (DataGridViewImageCell)dataGridProductos.Rows[0].Cells["imagen_producto"];

                // Ajusta el valor de la propiedad DefaultCellStyle.NullValue para que la imagen se ajuste al PictureBox
                cell.OwningColumn.DefaultCellStyle.NullValue = null;

                // Ajusta el tamaño de la columna para que coincida con el tamaño del PictureBox
                cell.OwningColumn.Width = pBoxImagenProducto.Width;
            }
        }


        private bool mostrarInactivos = false;

        private void btnAlternarInactivos_Click(object sender, EventArgs e)
        {

            btnCambiarEstado.Visible = true;
            btnAgregarProducto.Visible = false;
            btnEliminarProducto.Visible = false;
            btnModificarProducto.Visible = false;

            mostrarInactivos = !mostrarInactivos;

            if (mostrarInactivos)
            {
                
                productos = cnProducto.ObtenerProductosInactivos();


                // Redimensiona las imágenes antes de asignarlas al DataGridView
                foreach (var producto in productos)
                {
                    if (producto.imagen_producto != null)
                    {
                        // Redimensionar la imagen antes de asignarla al DataGridView
                        producto.imagen_producto = ImageToByteArray(RedimensionarImagen(ByteArrayToImage(producto.imagen_producto), 50, 50), ImageFormat.Jpeg);
                    }
                }

                // Mapear el ID de la categoría y del proveedor a sus nombres correspondientes
                var productosInactivos = productos.Select(p => new
                {
                    p.id_producto,
                    p.nombre_producto,
                    p.descripcion_producto,
                    p.categoria.descripcion_categoria,
                    p.proveedor.nombre_proveedor,
                    p.precio_producto,
                    p.stock_producto,
                    p.imagen_producto,
                    p.estado,
                    
                }).ToList();

                // Ajusta el tamaño de la columna de la imagen para que la imagen sea más grande
                dataGridProductos.Columns["imagen_producto"].Width = 100; // Puedes ajustar este valor según tus necesidades

                // Ajusta la columna de la imagen después de cargar los productos
               
                AjustarColumnaImagen();
                dataGridProductos.DataSource = productosInactivos;

            }
            else
            {
                // Mostrar todos los productos activos
                btnCambiarEstado.Visible = false;
                fuenteDatosActual = productos;
                CargarProductos();
                btnAgregarProducto.Visible = true;
                btnEliminarProducto.Visible = true;
                btnModificarProducto.Visible = true;
            }
        }


        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si se ha seleccionado un producto en el DataGridView
                if (dataGridProductos.SelectedRows.Count > 0)
                {
                    // Obtener el ID del producto seleccionado
                    int productoId = (int)dataGridProductos.CurrentRow.Cells["id_producto"].Value;

                    // Obtener el estado actual del producto
                    int estadoActual = (int)dataGridProductos.CurrentRow.Cells["estado"].Value;

                    // Calcular el nuevo estado
                    int nuevoEstado = (estadoActual == 1) ? 0 : 1;

                    // Mostrar un cuadro de diálogo de confirmación
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas cambiar el estado del producto?", "Confirmar Cambio de Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verificar la respuesta del usuario
                    if (result == DialogResult.Yes)
                    {
                        // Cambiar el estado del producto
                        cnProducto.CambiarEstadoProducto(productoId, nuevoEstado);

                        // Recargar la lista de productos después de cambiar el estado
                        if (mostrarInactivos)
                        {
                            List<producto> productosInactivos = cnProducto.ObtenerProductosInactivos();
                            dataGridProductos.DataSource = productosInactivos;
                            // Ajusta el tamaño de la columna de la imagen para que la imagen sea más grande
                            dataGridProductos.Columns["imagen_producto"].Width = 100; // Puedes ajustar este valor según tus necesidades

                            // Ajusta la columna de la imagen después de cargar los productos
                            AjustarColumnaImagen();
                        }
                        else
                        {
                            CargarProductos();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para cambiar su estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar el estado del producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<producto> fuenteDatosActual;

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void RealizarBusqueda()
        {
            // Obtén el texto de búsqueda desde el TextBox
            string textoBusqueda = txtBuscarProducto.Text.ToLower();

            // Filtra la fuente de datos actual en base al texto de búsqueda y al estado de los productos
            var productosFiltrados = fuenteDatosActual
                .Where(p =>
                    (mostrarInactivos ? p.estado == 0 : p.estado == 1) &&
                    p.nombre_producto.ToLower().Contains(textoBusqueda))
                .ToList();

            // Muestra los productos filtrados en el DataGridView
            dataGridProductos.DataSource = productosFiltrados;

            dataGridProductos.Columns["pedido"].Visible = false;
            dataGridProductos.Columns["venta_detalle"].Visible = false;
            dataGridProductos.Columns["categoria"].Visible = false;
            dataGridProductos.Columns["proveedor"].Visible = false;

            dataGridProductos.Columns["id_producto"].HeaderText = "ID";
            dataGridProductos.Columns["nombre_producto"].HeaderText = "Nombre";
            dataGridProductos.Columns["descripcion_producto"].HeaderText = "Descripción";
            //dataGridProductos.Columns["descripcion_categoria"].HeaderText = "Categoría";
            //dataGridProductos.Columns["nombre_proveedor"].HeaderText = "Proveedor";
            dataGridProductos.Columns["precio_producto"].HeaderText = "Precio";
            dataGridProductos.Columns["stock_producto"].HeaderText = "Stock";
            dataGridProductos.Columns["imagen_producto"].HeaderText = "Imagen";
            // Ajusta el tamaño de la columna de la imagen para que la imagen sea más grande
            dataGridProductos.Columns["imagen_producto"].Width = 100; // Puedes ajustar este valor según tus necesidades

            

            // Alinear la imagen a la izquierda
            dataGridProductos.Columns["imagen_producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            // Ajusta la columna de la imagen después de cargar los productos
            AjustarColumnaImagen();
        }



    }
}






