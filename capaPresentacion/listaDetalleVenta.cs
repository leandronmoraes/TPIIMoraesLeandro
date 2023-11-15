using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.codec.wmf;
using QRCoder;

namespace capaPresentacion
{
    public partial class listaDetalleVenta : Form
    {
        // Agrega campos para almacenar los detalles de la venta
        private int idVenta;

        const string NombreEmpresa = "Librería Moraes";
        const string RutaLogo = "imagenes/logo.png";


        public listaDetalleVenta(int idVenta)
        {
            InitializeComponent();
            this.idVenta = idVenta;
            CargarDetallesVenta(idVenta);
            // Mostrar la fecha y hora actual en el Label
            lbl_horaFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CargarDetallesVenta(int idVenta)
        {

            // Limpiar las filas existentes en dgvDetalleVenta
            dgvDetalleVenta.Rows.Clear();
            using (var db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var venta = db.venta
                    .Include("cliente")
                    .Include("usuario")
                    .FirstOrDefault(v => v.id_venta == idVenta);

                if (venta != null)
                {
                    // Cargar datos de la venta
                    txtIDVenta.Text = venta.id_venta.ToString();
                    txtNombreCliente.Text = venta.cliente.nombre_cliente;
                    txtDniCliente.Text = venta.cliente.DNI_cliente;
                    txtDireccionCliente.Text = venta.cliente.direccion;
                    txtIdVendedor.Text = venta.usuario.id_usuario.ToString();
                    txtNombreVendedor.Text = venta.usuario.nombre_usuario;
                    txtDniVendedor.Text = venta.usuario.DNI_usuario.ToString();

                    // Calcular y cargar el total de la venta
                    decimal totalVenta = 0;

                    var detallesVenta = db.venta_detalle
                        .Where(d => d.id_venta == idVenta)
                        .ToList();

                    foreach (var detalle in detallesVenta)
                    {
                        dgvDetalleVenta.Rows.Add(
                            detalle.producto.nombre_producto,
                            detalle.cantidad,
                            detalle.precioUnitario,
                            detalle.subTotal ?? 0m // Valor predeterminado 0 en caso de nulo
                        );

                        totalVenta += detalle.subTotal ?? 0m; // Valor predeterminado 0 en caso de nulo
                    }

                    txtTotal.Text = totalVenta.ToString("C"); // Mostrar el total como moneda
                }
                else
                {
                    MessageBox.Show("Venta no encontrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void listaDetalleVenta_Load(object sender, EventArgs e)
        {

            // Llama a la función para cargar los detalles de la venta
            CargarDetallesVenta(idVenta);
        }

 

        private void btnGuardarPDF_Click(int idVenta)
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
                string rutaImagenFondo = Path.Combine(Application.StartupPath, "imagenes/logo.png");
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
                doc.Add(new Paragraph("\nInformación del Cliente:", fontEncabezado));
                doc.Add(new Paragraph($"Nombre del Cliente: {txtNombreCliente.Text}"));
                doc.Add(new Paragraph($"DNI del Cliente: {txtDniCliente.Text}"));
                doc.Add(new Paragraph($"Dirección del Cliente: {txtDireccionCliente.Text}"));

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
                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
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

        private void btnGuardarPDF_Click(object sender, EventArgs e)
        {
            btnGuardarPDF_Click(idVenta);
        }
    }
   }

