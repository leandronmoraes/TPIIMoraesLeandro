using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; //Agregamos para poder utilizar los elementos Chart




namespace capaPresentacion
{
    public partial class FormEstadisticas : Form
    {
        public FormEstadisticas()
        {
            InitializeComponent();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {

            VentasClientes();
            //Los vectores con los datos
            string[] seriesVendedor = { "Leandro", "Santiago", "Jorge" };
            int[] puntosVendedor = { 23, 10, 70 };

            //Modificar los colores
            chart1.Palette = ChartColorPalette.BrightPastel;

            chart1.Titles.Add("Vendedores con mayor venta");
            for (int i = 0; i < seriesVendedor.Length; i++)
            {
                //Titulos
                Series serie = chart1.Series.Add(seriesVendedor[i]);

                //Cantidades
                serie.Label = puntosVendedor[i].ToString();

                serie.Points.Add(puntosVendedor[i]);
            }


            //Los vectores con los datos
            string[] seriesProducto = { "Producto1", "Producto2", "Producto3" };
            int[] puntosProducto = { 40, 60, 82 };

            //Modificar los colores
            chart2.Palette = ChartColorPalette.Fire;

            chart2.Titles.Add("Productos Más Vendidos");
            for (int i = 0; i < seriesVendedor.Length; i++)
            {
                //Titulos
                Series serie = chart2.Series.Add(seriesProducto[i]);

                //Cantidades
                serie.Label = puntosProducto[i].ToString();

                serie.Points.Add(puntosProducto[i]);
            }
        }



        private void VentasClientes()
        {
            string consulta = "SELECT TOP 5 V.id_Venta, " +
            "CONCAT(C.nombre_cliente, ' ', C.apellido_cliente) AS cliente, C.DNI_cliente AS DNI, " +
            "V.total_venta, V.fecha_venta " +
            "FROM venta V " +
            "INNER JOIN cliente C ON V.id_cliente = C.id_cliente " +
            "ORDER BY V.total_venta DESC";

            using (SqlConnection conexion = new SqlConnection("Server=.; Database=ProyectoTPII_MoraesLeandro; Integrated Security=True;"))
            using (SqlDataAdapter lista = new SqlDataAdapter(consulta, conexion))
            {

                DataTable dt = new DataTable();
                lista.Fill(dt);
                GridCompras.DataSource = dt;
            }
        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = TFecha.Value.Date;
            DateTime fechaHasta = THasta.Value.Date;

            if (fechaDesde > DateTime.Now || fechaHasta < fechaDesde)
            {
                TFecha.Value = DateTime.Now;
                THasta.Value = DateTime.Now;

                MessageBox.Show("Las fechas son inválidas", "Error en fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MostrarTopProductos(fechaDesde, fechaHasta);
                MostrarTopVendedores(fechaDesde, fechaHasta);
            }
        }

        private void MostrarTopProductos(DateTime fechaDesde, DateTime fechaHasta)
        {
            string connectionString = "Server=.; Database=ProyectoTPII_MoraesLeandro; Integrated Security=True;"; // Reemplaza esto con tu cadena de conexión

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT TOP 3
                                 P.nombre_producto,
                                 SUM(VD.cantidad) AS TotalVentas
                             FROM
                                 venta_detalle VD
                             INNER JOIN
                                 producto P ON VD.id_producto = P.id_producto
                             INNER JOIN
                                 venta V ON VD.id_venta = V.id_venta
                             WHERE
                                 V.fecha_venta BETWEEN @FechaDesde AND @FechaHasta
                             GROUP BY
                                 P.nombre_producto
                             ORDER BY
                                 TotalVentas DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        command.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Limpiar el Chart antes de agregar nuevos datos
                            chart2.Series.Clear();

                            // Crear una nueva serie
                            Series series = new Series("Ventas por Producto");
                            series.ChartType = SeriesChartType.Column;

                            while (reader.Read())
                            {
                                string nombreProducto = reader["nombre_producto"].ToString();
                                int totalVentas = Convert.ToInt32(reader["TotalVentas"]);

                                // Agregar puntos de datos a la serie
                                series.Points.AddXY(nombreProducto, totalVentas);
                            }

                            // Agregar la serie al Chart
                            chart2.Series.Add(series);

                            // Personalizar ejes y leyendas según sea necesario
                            chart2.ChartAreas[0].AxisX.Title = "Productos";
                            chart2.ChartAreas[0].AxisY.Title = "Ventas";
                            chart2.ChartAreas[0].AxisX.Interval = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarTopVendedores(DateTime fechaDesde, DateTime fechaHasta)
        {
            string connectionString = "Server=.; Database=ProyectoTPII_MoraesLeandro; Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT TOP 5 
                                   E.nombre_usuario + ' ' + E.apellido_usuario AS NombreVendedor,
                                   COUNT(V.id_venta) AS CantidadVentas
                               FROM
                                   venta V
                               INNER JOIN
                                   usuario E ON V.id_vendedor = E.id_usuario
                               WHERE
                                   V.fecha_venta BETWEEN @FechaDesde AND @FechaHasta
                              GROUP BY E.id_usuario, E.nombre_usuario, E.apellido_usuario
                               ORDER BY
                                   CantidadVentas DESC;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                        command.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Limpiar el Chart antes de agregar nuevos datos
                            chart1.Series.Clear();
                            chart1.ChartAreas.Clear();

                            // Agregar una nueva área
                            ChartArea chartArea = new ChartArea("Vendedores");
                            chart1.ChartAreas.Add(chartArea);

                            // Crear la serie de tipo pastel solo si hay datos
                            if (dt.Rows.Count > 0)
                            {
                                Series series = new Series
                                {
                                    Name = "Ventas",
                                    ChartType = SeriesChartType.Pie,
                                    IsVisibleInLegend = true,
                                };

                                foreach (DataRow row in dt.Rows)
                                {
                                    string nombreVendedor = row["NombreVendedor"].ToString();
                                    int cantidadVentas = Convert.ToInt32(row["CantidadVentas"]);

                                    DataPoint dataPoint = new DataPoint
                                    {
                                        LegendText = $"{nombreVendedor}",
                                        Label = $"{nombreVendedor} ({cantidadVentas})",
                                        YValues = new double[] { cantidadVentas }
                                    };
                                    series.Points.Add(dataPoint);
                                }

                                // Agregar la serie al gráfico
                                chart1.Series.Add(series);
                            }
                            else
                            {
                                // Si no hay datos, crea una serie vacía y agrega un punto de datos ficticio
                                Series emptySeries = new Series
                                {
                                    Name = "Ventas",
                                    ChartType = SeriesChartType.Pie,
                                    IsVisibleInLegend = true,
                                };

                                DataPoint chartVacio = new DataPoint
                                {
                                    YValues = new double[] { 100 },
                                    Label = "Sin datos"
                                };
                                emptySeries.Points.Add(chartVacio);

                                chart1.Series.Add(emptySeries);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void btnExportarPDF_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"reportes_{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        // Crear un documento PDF
                        iTextSharp.text.Document doc = new iTextSharp.text.Document();
                        iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                        doc.Open();

                        // Añadir título al documento
                        iTextSharp.text.Font titleFont = iTextSharp.text.FontFactory.GetFont("Helvetica", 18, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph("Reporte de Estadísticas", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        doc.Add(title);

                        // Añadir espacio en blanco
                        doc.Add(new iTextSharp.text.Paragraph(" "));

                        // Agregar imágenes de los gráficos
                        MemoryStream chart1Stream = new MemoryStream();
                        chart1.SaveImage(chart1Stream, ChartImageFormat.Png);
                        iTextSharp.text.Image chart1Image = iTextSharp.text.Image.GetInstance(chart1Stream.GetBuffer());
                        chart1Image.ScalePercent(75f);
                        chart1Image.Alignment = Element.ALIGN_LEFT;

                        MemoryStream chart2Stream = new MemoryStream();
                        chart2.SaveImage(chart2Stream, ChartImageFormat.Png);
                        iTextSharp.text.Image chart2Image = iTextSharp.text.Image.GetInstance(chart2Stream.GetBuffer());
                        chart2Image.ScalePercent(75f);
                        chart2Image.Alignment = Element.ALIGN_RIGHT;

                        // Crear una tabla para organizar las imágenes
                        PdfPTable imageTable = new PdfPTable(2);
                        imageTable.WidthPercentage = 100;
                        imageTable.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                        // Añadir las imágenes a la tabla
                        imageTable.AddCell(new PdfPCell(chart1Image));
                        imageTable.AddCell(new PdfPCell(chart2Image));

                        // Añadir la tabla al documento
                        doc.Add(imageTable);

                        // Añadir espacio en blanco
                        doc.Add(new iTextSharp.text.Paragraph(" "));

                        // Agregar el datagrid al documento
                        PdfPTable table = new PdfPTable(GridCompras.Columns.Count);

                        // Añadir encabezados de columnas al PDF
                        for (int i = 0; i < GridCompras.Columns.Count; i++)
                        {
                            PdfPCell headerCell = new PdfPCell(new iTextSharp.text.Phrase(GridCompras.Columns[i].HeaderText));
                            headerCell.BackgroundColor = new iTextSharp.text.BaseColor(200, 200, 200); // Cambia el color de fondo si lo deseas
                            table.AddCell(headerCell);
                        }

                        // Añadir filas de datos al PDF
                        for (int i = 0; i < GridCompras.Rows.Count; i++)
                        {
                            for (int j = 0; j < GridCompras.Columns.Count; j++)
                            {
                                if (GridCompras[j, i].Value != null)
                                {
                                    table.AddCell(new iTextSharp.text.Phrase(GridCompras[j, i].Value.ToString()));
                                }
                            }
                        }

                        // Añadir la tabla al documento
                        doc.Add(table);

                        // Cerrar el documento
                        doc.Close();

                        MessageBox.Show("Exportación exitosa a PDF", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar a PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






    }
}
 