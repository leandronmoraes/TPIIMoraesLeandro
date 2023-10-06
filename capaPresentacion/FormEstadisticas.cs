using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //Los vectores con los datos
            string[] seriesVendedor = { "Leandro", "Santiago", "Jorge" };
            int[] puntosVendedor = { 23, 10, 70 };

            //Modificar los colores
            chart2.Palette = ChartColorPalette.BrightPastel;

            chart2.Titles.Add("Vendedores con mayor venta");
            for (int i = 0; i < seriesVendedor.Length; i++)
            {
                //Titulos
                Series serie = chart2.Series.Add(seriesVendedor[i]);

                //Cantidades
                serie.Label = puntosVendedor[i].ToString();

                serie.Points.Add(puntosVendedor[i]);
            }


            //Los vectores con los datos
            string[] seriesProducto= { "Producto1", "Producto2", "Producto3" };
            int[] puntosProducto = { 40, 60, 82 };

            //Modificar los colores
            chart1.Palette = ChartColorPalette.Fire;

            chart1.Titles.Add("Productos Más Vendidos");
            for (int i = 0; i < seriesVendedor.Length; i++)
            {
                //Titulos
                Series serie = chart1.Series.Add(seriesProducto[i]);

                //Cantidades
                serie.Label = puntosProducto[i].ToString();

                serie.Points.Add(puntosProducto[i]);
            }

            // Configura chart3 como un gráfico de torta
            chart3.ChartAreas.Add(new ChartArea("TortaArea"));
            chart3.Series.Clear();
            chart3.Series.Add(new Series("TortaSeries"));
            chart3.Series["TortaSeries"].ChartType = SeriesChartType.Pie;



            // Los vectores con los datos
            string[] seriesClientes = { "Corrientes", "Chaco", "Formosa" };
            int[] puntosClientes = { 100, 60, 82 };

            // Modificar los colores
            chart3.Palette = ChartColorPalette.Pastel;

            chart3.Titles.Add("Clientes Provincias");

            // Configurar el gráfico de torta
            chart3.Series["TortaSeries"].Points.DataBindXY(seriesClientes, puntosClientes);

            // Opcionalmente, puedes agregar etiquetas a las partes del gráfico de torta
            for (int i = 0; i < seriesClientes.Length; i++)
            {
                chart3.Series["TortaSeries"].Points[i].Label = seriesClientes[i] + ": " + puntosClientes[i].ToString();
            }


        }
    }
}
 