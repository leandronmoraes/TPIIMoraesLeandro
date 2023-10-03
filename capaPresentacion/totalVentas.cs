using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{

    public partial class totalVentas : Form
    {
        public totalVentas()
        {
            InitializeComponent();
        }

    
        // Declara una variable para realizar un seguimiento del formulario de detalles abierto.
        private listaDetalleVenta detallesAbiertos = null;

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVentas.Columns[e.ColumnIndex].Name == "detalle_venta")
            {
                // Verifica si el formulario de detalles ya está abierto.
                if (detallesAbiertos == null || detallesAbiertos.IsDisposed)
                {
                    // Si no está abierto o se ha cerrado, crea una nueva instancia y ábrela.
                    detallesAbiertos = new listaDetalleVenta();
                    detallesAbiertos.Show();
                }
                else
                {
                    // Si ya está abierto, trae el formulario al frente.
                    detallesAbiertos.BringToFront();
                }
            }
        }


        private void totalVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.Rows.Add("Leandro morales", "42743277", "Raul Alfonzin", "99999", "23/09/2023", "10","Detalles Venta");
            dgvVentas.Rows.Add("Leandro morales", "11111", "Raul Alfonzin", "99999", "23/09/2023", "10", "Detalles Venta");
            dgvVentas.Rows.Add("Leandro morales", "22222", "Raul Alfonzin", "99999", "23/09/2023", "10", "Detalles Venta");
            dgvVentas.Rows.Add("Leandro morales", "33333", "Raul Alfonzin", "99999", "23/09/2023", "10", "Detalles Venta");
            dgvVentas.Rows.Add("Leandro morales", "424242", "Raul Alfonzin", "99999", "23/09/2023", "10", "Detalles Venta");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string encontrarVendedor = txtBuscar.Text;
            bool encontrado = false;

            foreach (DataGridViewRow recorrer in dgvVentas.Rows)
            {
                if (recorrer.Cells[0].Value.ToString().IndexOf(encontrarVendedor, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    recorrer.Cells[1].Value.ToString().IndexOf(encontrarVendedor, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    recorrer.Visible = true;
                    encontrado = true;
                }
                else
                {
                    recorrer.Visible = false;
                }
            }

            if (!encontrado)
            {
               
                // Si no se encuentra ningún vendedor, muestra todas las filas
                foreach (DataGridViewRow recorrer in dgvVentas.Rows)
                {
                    recorrer.Visible = true;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string encontrarVendedor = txtBuscar.Text;
            bool encontrado = false;

            if (!string.IsNullOrEmpty(encontrarVendedor))
            {
                foreach (DataGridViewRow recorrer in dgvVentas.Rows)
                {
                    if (recorrer.Cells[0].Value.ToString().Equals(encontrarVendedor, StringComparison.OrdinalIgnoreCase) ||
                        recorrer.Cells[1].Value.ToString().Equals(encontrarVendedor, StringComparison.OrdinalIgnoreCase))
                    {
                        recorrer.Visible = true;
                        encontrado = true;
                    }
                    else
                    {
                        recorrer.Visible = false;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("Vendedor no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Si no se encuentra ningún vendedor, muestra todas las filas
                    foreach (DataGridViewRow recorrer in dgvVentas.Rows)
                    {
                        recorrer.Visible = true;
                    }
                }
            }
        }
    }
}
