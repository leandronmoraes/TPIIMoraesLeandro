using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using capaNegocio;
using capaDatos.Models;
using System.Data.Entity;
using capaDatos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.codec.wmf;
using MessageBox = System.Windows.Forms.MessageBox;


using System.Windows;
//using Microsoft.Win32;
using iText.Html2pdf;
using Aspose.Cells;
using System.Collections.ObjectModel;
using QRCoder;

namespace capaPresentacion
{
    public partial class nuevaVenta : Form
    {
        const string NombreEmpresa = "Librería Moraes";
        const string RutaLogo = "imagenes/logo.png";

        private cliente clienteSeleccionado;

        public nuevaVenta()
        {
            InitializeComponent();

            btnLimpiarCliente.Visible = false;
            btnLimpiarProducto.Visible = false;
            // Establece el valor predeterminado de txtCantidad en 1
            txtCantidad.Text = "1";

        }


        private decimal precioUnitarioActual;

        private void btnSumarCantidad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                int cantidad;
                if (int.TryParse(txtCantidad.Text, out cantidad))
                {
                    cantidad++;
                    txtCantidad.Text = cantidad.ToString();

                    // Calcula el precio total multiplicando la cantidad por el precio unitario
                    decimal precioTotal = cantidad * precioUnitarioActual;
                    txtPrecio.Text = precioTotal.ToString();
                }
                else
                {
                    MessageBox.Show("La cantidad no es un número entero válido");
                }
            }
        }

        private void btnRestarCantidad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                int cantidad;
                if (int.TryParse(txtCantidad.Text, out cantidad) && cantidad > 1)
                {
                    cantidad--;
                    txtCantidad.Text = cantidad.ToString();

                    decimal precioTotal;
                    if (decimal.TryParse(txtPrecio.Text, out precioTotal) && cantidad != 0)
                    {
                        // Calcula el precio total dividiendo el precio actual entre la cantidad
                        precioTotal = precioTotal - precioUnitarioActual;
                        txtPrecio.Text = precioTotal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El precio no es un número decimal válido o la cantidad es cero.");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad no es un número entero válido o es menor o igual a 1");
                }
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debes seleccionar un cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Debes seleccionar un producto.");
                return;
            }

            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero válido y mayor que cero.");
                return;
            }

            int stockDisponible = ObtenerStockProducto(txtNombreProducto.Text);

            if (cantidad > stockDisponible)
            {
                MessageBox.Show("La cantidad seleccionada supera el stock disponible.");
                return;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("El precio no es un número decimal válido o debe ser mayor que cero.");
                return;
            }

            // Actualizar el stock en la base de datos
            ActualizarStockProducto(txtNombreProducto.Text, cantidad);

            bool productoAgregado = false;
            foreach (DataGridViewRow row in dataGridVenta.Rows)
            {
                if (row.Cells[0].Value.ToString() == txtNombreProducto.Text)
                {
                    int cantidadEnCarrito = Convert.ToInt32(row.Cells[1].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells[3].Value);

                    cantidadEnCarrito += cantidad; // Acumula la cantidad en la fila existente
                    subtotal = cantidadEnCarrito * precio;

                    row.Cells[1].Value = cantidadEnCarrito;
                    row.Cells[3].Value = subtotal.ToString();

                    productoAgregado = true;
                    break;
                }
            }

            // Si el producto no está en el carrito, agrégalo
            if (!productoAgregado)
            {
                // Agrega una nueva fila al carrito solo si la cantidad no es cero
                if (cantidad > 0)
                {
                    // Agrega el nuevo producto al carrito
                    dataGridVenta.Rows.Add(txtNombreProducto.Text, cantidad, precio, (cantidad * precio).ToString());
                }
                else
                {
                    MessageBox.Show("La cantidad debe ser mayor que cero para agregar el producto al carrito.");
                }

                totalPorVender();
                limpiarDatos();
            }
        }


        // Métodos para actualizar y obtener el stock de un producto
        private int ObtenerStockProducto(string nombreProducto)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                producto productoSeleccionado = db.producto.FirstOrDefault(p => p.nombre_producto == nombreProducto);

                if (productoSeleccionado != null)
                {
                    // Realiza una conversión explícita de int? a int usando el operador ?? o un valor por defecto
                    return productoSeleccionado.stock_producto ?? 0;
                }

                return 0; // Retorna 0 si no se encuentra el producto
            }
        }

        private void ActualizarStockProducto(string nombreProducto, int cantidadVendida)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                producto productoSeleccionado = db.producto.FirstOrDefault(p => p.nombre_producto == nombreProducto);
                if (productoSeleccionado != null)
                {
                    productoSeleccionado.stock_producto -= cantidadVendida;
                    db.SaveChanges();
                }
            }
        }

        private void RestablecerStock(List<ProductoCarrito> productosEnCarrito)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                foreach (ProductoCarrito productoCarrito in productosEnCarrito)
                {
                    producto productoSeleccionado = db.producto.FirstOrDefault(p => p.nombre_producto == productoCarrito.NombreProducto);

                    if (productoSeleccionado != null)
                    {
                        // Restablecer el stock sumando la cantidad original
                        productoSeleccionado.stock_producto += productoCarrito.CantidadOriginal;
                    }
                }

                db.SaveChanges();
            }
        }
        private void limpiarDatos()
        {
            txtCantidad.Text = "1";
            txtPrecio.Text = " ";
            txtNombreProducto.Text = " ";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de lista de productos
            listaProductosForm listaProductosForm = new listaProductosForm();

            // Mostrar el formulario de lista de productos como un diálogo
            DialogResult result = listaProductosForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Crear una instancia del contexto de Entity Framework
                ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities();

                // Si se selecciona un producto en el formulario de lista de productos,
                // puedes obtener la información del producto seleccionado y utilizarla
                // en tu formulario actual, por ejemplo, estableciendo el nombre del producto en el campo txtNombreProducto.

                string nombreProductoSeleccionado = listaProductosForm.NombreProductoSeleccionado;
                txtNombreProducto.Text = nombreProductoSeleccionado;

                // Ahora, busca el precio del producto seleccionado en la base de datos a través de Entity Framework.
                producto productoSeleccionado = db.producto.FirstOrDefault(p => p.nombre_producto == nombreProductoSeleccionado);

                if (productoSeleccionado != null)
                {
                    // Si se encontró el producto, establece el precio en el campo txtPrecio.
                    txtPrecio.Text = (productoSeleccionado.precio_producto ?? 0).ToString();
                    precioUnitarioActual = productoSeleccionado.precio_producto ?? 0; // Actualiza el precio unitario
                }

                btnLimpiarProducto.Visible = true;
            }
            else
            {
                // El usuario canceló la selección o cerró el formulario de lista de productos.
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtDNICliente.Clear();
            btnLimpiarCliente.Visible = false;
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Text = "1";
            btnLimpiarProducto.Visible = false;
        }


        public void totalPorVender()
        {
            decimal total = 0.0m;
            foreach (DataGridViewRow row in dataGridVenta.Rows)
            {
                total += Convert.ToDecimal(row.Cells[3].Value);
            }
            txtTotal.Text = total.ToString();
        }

        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            txtDNICliente.Enabled = true;

            if (dataGridVenta.Rows.Count > 0)
            {
                // El carrito tiene al menos un elemento, se permite la limpieza.

                // Obtén la lista de productos en el carrito y sus cantidades originales
                List<ProductoCarrito> productosEnCarrito = ObtenerProductosEnCarrito();

                // Restablecer el stock de los productos antes de limpiar el carrito
                RestablecerStock(productosEnCarrito);

                // Limpia el carrito
                dataGridVenta.Rows.Clear(); // Elimina todas las filas del DataGridView
                txtTotal.Text = ""; // Limpia el campo de total (si es necesario)
                txtCantidad.Text = "1";

                MessageBox.Show("Carrito limpiado exitosamente.", "Carrito Limpiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // El carrito ya está vacío, muestra un mensaje.
                MessageBox.Show("El carrito ya está vacío, no hay elementos para limpiar.");
            }
        }

        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void nuevaVenta_Load(object sender, EventArgs e)
        {
            CargarTiposDePago(); // Asegúrate de cargar los tipos de pago al iniciar el formulario

        }

        private int GetProductIdFromDatabase(string nombreProducto)
        {
            ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities();
            producto productoSeleccionado = db.producto.FirstOrDefault(p => p.nombre_producto == nombreProducto);

            if (productoSeleccionado != null)
            {
                return productoSeleccionado.id_producto;
            }

            return -1; // Retorna -1 si el producto no se encuentra
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            // Verifica si hay elementos en el carrito
            if (dataGridVenta.Rows.Count > 0)
            {
                MessageBox.Show("No puedes cambiar de cliente con elementos en el carrito.");
                return;
            }

            // Si el carrito está vacío, permite buscar un cliente
            ListaClientesForm listaClientesForm = new ListaClientesForm();
            DialogResult result = listaClientesForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string dniClienteSeleccionado = listaClientesForm.DNIClienteSeleccionado;
                txtDNICliente.Text = dniClienteSeleccionado;
                clienteSeleccionado = BuscarClientePorDNI(dniClienteSeleccionado);
            }
        }

        private void LimpiarCampos()
        {
            // Limpia los campos del cliente
            txtDNICliente.Text = string.Empty;
            clienteSeleccionado = null;

            // Limpia los campos de producto
            txtNombreProducto.Text = string.Empty;
            txtCantidad.Text = "1";
            txtPrecio.Text = string.Empty;
            btnLimpiarProducto.Visible = false;

            // Limpia el DataGridView
            dataGridVenta.Rows.Clear();

            // Limpia el campo de total
            txtTotal.Text = string.Empty;

            // Habilita la entrada del cliente
            txtDNICliente.Enabled = true;
        }


        private cliente BuscarClientePorDNI(string dni)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                return db.cliente.FirstOrDefault(c => c.DNI_cliente == dni);
            }
        }


        public int ObtenerIdVendedor()
        {
            try
            {
                using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                {
                    int usuarioId = ContextoCompartido.UsuarioId;

                    // Buscar al usuario autenticado con el rol "vendedor"
                    var usuarioAutenticado = db.usuario.FirstOrDefault(u => u.id_usuario == usuarioId && u.id_rol == 3);

                    if (usuarioAutenticado != null)
                    {
                        return usuarioAutenticado.id_usuario;
                    }
                    else
                    {
                        MessageBox.Show("El usuario autenticado no tiene el rol de vendedor.");
                        // Puedes redirigir al usuario a la página de inicio de sesión o realizar otra acción apropiada.
                        throw new Exception("No se ha encontrado un usuario vendedor autenticado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Otra lógica si no se puede obtener el ID del vendedor
            }
        }


        private int ObtenerIdTipoPago()
        {
            if (cmbTipoPago != null && cmbTipoPago.SelectedItem != null)
            {
                // Obtén el ID del tipo de pago seleccionado del ComboBox.
                int idTipoPago = (int)cmbTipoPago.SelectedValue;
                return idTipoPago;
            }

            // Maneja la situación en la que no se ha seleccionado un tipo de pago o el ComboBox es nulo.
            // Puedes lanzar una excepción, retornar un valor por defecto o realizar la lógica adecuada.
            throw new Exception("Debes seleccionar un tipo de pago o cargar los tipos de pago en el ComboBox.");
        }

        private void CargarTiposDePago()
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var tiposDePago = db.tipo_pago.ToList();
                cmbTipoPago.DataSource = tiposDePago;
                cmbTipoPago.DisplayMember = "descripcion_tipo_pago";
                cmbTipoPago.ValueMember = "id_tipo_pago";
            }
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {


            string dniClienteSeleccionado = ObtenerDniClienteSeleccionado(); // Reemplaza con tu lógica real.

            if (!string.IsNullOrEmpty(dniClienteSeleccionado))
            {
                // Luego, puedes establecer el DNI del cliente en el campo de DNI del formulario de nueva venta.
                txtDNICliente.Text = dniClienteSeleccionado;
            }
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            // Similar a la selección de cliente, aquí debes abrir el formulario de lista de productos
            // y obtener el nombre del producto seleccionado.

            string nombreProductoSeleccionado = ObtenerNombreProductoSeleccionado(); // Reemplaza con tu lógica real.

            if (!string.IsNullOrEmpty(nombreProductoSeleccionado))
            {
                // Luego, puedes establecer el nombre del producto en el campo de producto del formulario de nueva venta.
                txtNombreProducto.Text = nombreProductoSeleccionado;
            }
        }

        // Método para obtener el DNI del cliente seleccionado desde el formulario de lista de clientes
        private string ObtenerDniClienteSeleccionado()
        {
            string dniCliente = string.Empty;

            // Abre el formulario de lista de clientes y obtén el DNI seleccionado
            using (ListaClientesForm listaClientesForm = new ListaClientesForm())
            {
                DialogResult result = listaClientesForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dniCliente = listaClientesForm.DNIClienteSeleccionado;
                }
            }

            return dniCliente;
        }

        // Método para obtener el nombre del producto seleccionado desde el formulario de lista de productos
        private string ObtenerNombreProductoSeleccionado()
        {
            string nombreProducto = string.Empty;

            // Abre el formulario de lista de productos y obtén el nombre del producto seleccionado
            using (listaProductosForm listaProductosForm = new listaProductosForm())
            {
                DialogResult result = listaProductosForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    nombreProducto = listaProductosForm.NombreProductoSeleccionado;
                }
            }

            return nombreProducto;
        }


        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {

            if (dataGridVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para registrar la venta.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show("¿Está seguro de realizar la venta?", "Confirmación de Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                {
                    try
                    {
                        // Validar que se haya seleccionado un cliente
                        if (clienteSeleccionado == null)
                        {
                            MessageBox.Show("Debes seleccionar un cliente antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Validar el tipo de pago
                        if (cmbTipoPago.SelectedItem == null)
                        {
                            MessageBox.Show("Debes seleccionar un tipo de pago antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Obtener el ID del cliente a partir del DNI
                        int idCliente = clienteSeleccionado.id_cliente; // Así lo obtienes si ya tienes el cliente seleccionado.

                        // Obtener el ID del vendedor autenticado
                        int idVendedor = ObtenerIdVendedor();

                        // Obtener el ID del tipo de pago seleccionado.
                        int idTipoPago = ObtenerIdTipoPago();

                        // Validar que se haya al menos un producto en el carrito
                        if (dataGridVenta.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay productos en el carrito. Agrega productos antes de registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Validar que la cantidad y el precio de los productos sean correctos
                        foreach (DataGridViewRow row in dataGridVenta.Rows)
                        {
                            if (!int.TryParse(row.Cells[1].Value.ToString(), out int cantidad) || cantidad <= 0)
                            {
                                MessageBox.Show("La cantidad de productos no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (!decimal.TryParse(row.Cells[2].Value.ToString(), out decimal precioUnitario) || precioUnitario <= 0)
                            {
                                MessageBox.Show("El precio unitario de un producto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        // Crear un registro de venta
                        venta nuevaVenta = new venta
                        {
                            id_cliente = idCliente,
                            fecha_venta = DateTime.Today,
                            total_venta = decimal.Parse(txtTotal.Text),
                            id_vendedor = idVendedor,
                            id_tipo_pago = idTipoPago,
                            estado = 1
                        };

                        // Agregar la venta a la base de datos
                        db.venta.Add(nuevaVenta);
                        db.SaveChanges();

                        // Guardar el ID de la venta recién creada
                        int idVenta = nuevaVenta.id_venta;

                        // Registrar los detalles de la venta
                        foreach (DataGridViewRow row in dataGridVenta.Rows)
                        {
                            int idProducto = GetProductIdFromDatabase(row.Cells[0].Value.ToString());
                            int cantidad = Convert.ToInt32(row.Cells[1].Value);
                            decimal precioUnitario = Convert.ToDecimal(row.Cells[2].Value);
                            decimal subTotal = Convert.ToDecimal(row.Cells[3].Value);

                            // Crear un registro de venta_detalle
                            venta_detalle detalleVenta = new venta_detalle
                            {
                                id_venta = idVenta,
                                id_producto = idProducto,
                                cantidad = cantidad,
                                precioUnitario = precioUnitario,
                                subTotal = subTotal
                            };

                            // Agregar el detalle de la venta a la base de datos
                            db.venta_detalle.Add(detalleVenta);
                        }

                        // Guardar los detalles de la venta en la base de datos
                        db.SaveChanges();

                        // Generar y guardar la factura PDF
                        GenerarFacturaPDF(idVenta);

                        LimpiarCampos();

                        MessageBox.Show("Venta registrada con éxito.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar la venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // caso en donde no se confirme la venta
                MessageBox.Show("La venta ha sido cancelada.", "Venta Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void GenerarFacturaPDF(int idVenta)
        {
            // Obtener la fecha actual y formatearla como "yyyyMMdd_HHmmss"
            string fechaActual = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            // Agregar la fecha al nombre del archivo
            string nombreArchivo = "Factura_" + idVenta + "_" + fechaActual + ".pdf";
            string rutaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string rutaGuardado = Path.Combine(rutaDescargas, nombreArchivo);
            string telefonoEmpresa = "123-456-789";
            string emailEmpresa = "info@libreriamoraes.com";
            string webEmpresa = "www.libreriamoraes.com";
            string direccionEmpresa = "Junin 632";

            try
            {

                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaGuardado, FileMode.Create));


                doc.Open();
                // Ajustar los márgenes del documento
                doc.SetMargins(10f, 10f, 10f, 10f); //

                // Encabezado de la factura
                iTextSharp.text.Font fontEncabezado = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                Paragraph encabezado = new Paragraph("Factura de Venta", fontEncabezado);
                encabezado.Alignment = Element.ALIGN_CENTER;
                doc.Add(encabezado);

                // ID de Venta centrado en la parte inferior del encabezado
                iTextSharp.text.Font fontIDVenta = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);
                Paragraph idVentaParagraph = new Paragraph($"ID de Venta: {idVenta}", fontIDVenta);
                idVentaParagraph.Alignment = Element.ALIGN_CENTER;
                doc.Add(idVentaParagraph);

                // Texto "Libreria - Moraes" a la izquierda del logo
                iTextSharp.text.Font fontLibreriaMoraes = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE);
                Paragraph libreriaMoraes = new Paragraph("Libreria - Moraes", fontLibreriaMoraes);
                libreriaMoraes.Alignment = Element.ALIGN_RIGHT;
                doc.Add(libreriaMoraes);

                // Ruta de la imagen de fondo
                string rutaImagenFondo = Path.Combine(System.Windows.Forms.Application.StartupPath, "imagenes/logo.png");
                iTextSharp.text.Image imagenFondo = iTextSharp.text.Image.GetInstance(rutaImagenFondo);
                imagenFondo.ScaleToFit(80, 80); // Tamaño ajustado del logo
                imagenFondo.SetAbsolutePosition(20, doc.PageSize.Height - 100); // Posición ajustada del logo
                doc.Add(imagenFondo);

                // Línea separadora
                doc.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()));

                // Información de la empresa y contacto
                PdfPTable infoTable = new PdfPTable(2);
                infoTable.WidthPercentage = 80; // Ajuste del ancho de la tabla

                PdfPCell empresaCell = new PdfPCell(new Phrase($"Nombre de la empresa: Librería Moraes\nUbicación: Argentina, Corrientes\nDirección: {direccionEmpresa}"));
                empresaCell.Border = PdfPCell.NO_BORDER;

                PdfPCell contactoCell = new PdfPCell(new Phrase($"Teléfono: {telefonoEmpresa}\nEmail: {emailEmpresa}\nWeb: {webEmpresa}"));
                contactoCell.Border = PdfPCell.NO_BORDER;
                contactoCell.HorizontalAlignment = Element.ALIGN_RIGHT;

                infoTable.AddCell(empresaCell);
                infoTable.AddCell(contactoCell);

                doc.Add(infoTable);

                // Línea separadora
                doc.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator()));


                // Fecha de la factura generada arriba de la información del cliente y centrada
                Paragraph fechaGenerada = new Paragraph($"Fecha de la Factura Generada: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
                fechaGenerada.Alignment = Element.ALIGN_CENTER;
                doc.Add(fechaGenerada);

                // Información del cliente
                //doc.Add(new Paragraph("\nInformación del Cliente:", fontEncabezado));
                //doc.Add(new Paragraph($"Nombre del Cliente: {txtNombreCliente.Text}"));
                //doc.Add(new Paragraph($"DNI del Cliente: {txtDniCliente.Text}"));
                //doc.Add(new Paragraph($"Dirección del Cliente: {txtDireccionCliente.Text}"));

                // Detalles de pago (puedes personalizar esta sección según tus necesidades)
                doc.Add(new Paragraph("\nDetalles de Compra:", fontEncabezado));



                // Espacio antes de la tabla para centrarla
                doc.Add(new Paragraph("\n\n"));

                // Agregar una tabla para los detalles de la venta
                PdfPTable table = new PdfPTable(4);
                table.WidthPercentage = 80; // Porcentaje del ancho de la página que ocupará la tabla

                // Configurar estilo de celda
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = new BaseColor(57, 167, 255); // Color de fondo

                // Encabezados de la tabla
                cell.Phrase = new Phrase("Nombre del Producto", fontEncabezado);
                table.AddCell(cell);

                cell.Phrase = new Phrase("Cantidad", fontEncabezado);
                table.AddCell(cell);

                cell.Phrase = new Phrase("Precio Unitario", fontEncabezado);
                table.AddCell(cell);

                cell.Phrase = new Phrase("Importe", fontEncabezado);
                table.AddCell(cell);

                // Agregar filas con detalles de productos
                foreach (DataGridViewRow row in dataGridVenta.Rows)
                {
                    table.AddCell(new PdfPCell(new Phrase(row.Cells[0].Value.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(row.Cells[1].Value.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(row.Cells[2].Value.ToString())));
                    table.AddCell(new PdfPCell(new Phrase(row.Cells[3].Value.ToString())));
                }

                // Agregar la tabla al documento
                doc.Add(table);



                // Agregar código QR para el ID de la venta
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(idVenta.ToString(), QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(2); // Ajusta el tamaño según tus necesidades

                // Convertir la imagen del código QR a formato iTextSharp
                iTextSharp.text.Image imagenQR = iTextSharp.text.Image.GetInstance(qrCodeImage, System.Drawing.Imaging.ImageFormat.Png);
                imagenQR.Alignment = Element.ALIGN_CENTER;

                // Insertar el código QR en el documento
                doc.Add(imagenQR);

                // Pie de página
                PdfPTable footer = new PdfPTable(1);
                footer.TotalWidth = 300;
                footer.AddCell(new PdfPCell(new Phrase($"\nTotal a Pagar: {txtTotal.Text} ")));
                doc.Add(footer);


                // Cerrar el documento
                doc.Close();
                writer.Close();
                MessageBox.Show($"Factura PDF generada y guardada en {rutaGuardado}");
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Error: No se encontró la imagen. Verifica la ruta: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar la factura PDF: {ex.Message}");
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            if (dataGridVenta.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos en el carrito para cancelar la venta.", "Carrito Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Pregunta al usuario si está seguro de cancelar la venta
            DialogResult confirmResult = MessageBox.Show("¿Está seguro de cancelar la venta?", "Confirmación de Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Obtén la lista de productos en el carrito y sus cantidades originales
                List<ProductoCarrito> productosEnCarrito = ObtenerProductosEnCarrito();

                // Restablecer el stock de los productos antes de cancelar la venta
                RestablecerStock(productosEnCarrito);

                // Limpiar campos y cancelar la venta
                LimpiarCampos();
                MessageBox.Show("Venta cancelada exitosamente.", "Venta Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // El usuario ha decidido no cancelar la venta
                MessageBox.Show("La venta no ha sido cancelada.", "Venta no Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public class ProductoCarrito
        {
            public string NombreProducto { get; set; }
            public int CantidadOriginal { get; set; }
            // Otros atributos necesarios según tu aplicación

            public ProductoCarrito(string nombreProducto, int cantidadOriginal)
            {
                NombreProducto = nombreProducto;
                CantidadOriginal = cantidadOriginal;
            }
        }

        private List<ProductoCarrito> ObtenerProductosEnCarrito()
        {
            List<ProductoCarrito> productosEnCarrito = new List<ProductoCarrito>();

            foreach (DataGridViewRow row in dataGridVenta.Rows)
            {
                string nombreProducto = row.Cells[0].Value.ToString();
                int cantidadOriginal = Convert.ToInt32(row.Cells[1].Value);

                productosEnCarrito.Add(new ProductoCarrito(nombreProducto, cantidadOriginal));
            }

            return productosEnCarrito;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un número o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni la tecla de retroceso, cancelar la entrada del usuario
                e.Handled = true;
            }

            // Verificar si el primer carácter es un cero
            if (txtCantidad.Text.Length == 0 && e.KeyChar == '0')
            {
                // Si el primer carácter es un cero, cancelar la entrada del usuario
                e.Handled = true;
            }
        }
    }
}

