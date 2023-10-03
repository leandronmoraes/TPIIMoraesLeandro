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
    public partial class formVenta : Form
    {
        public formVenta()
        {
            InitializeComponent();
        }

        // Declara una variable para realizar un seguimiento del formulario de detalles abierto.
        private listaDetalleVenta detallesAbiertos = null;
        private void dataGridVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridVenta.Columns[e.ColumnIndex].Name == "detalles")
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

        private void formVenta_Load(object sender, EventArgs e)
        {
            dataGridVenta.Rows.Add("Leandro morales", "42743277", "Raul Alfonzin", "Detalles");
            dataGridVenta.Rows.Add("Leandro morales", "2323", "Raul Alfonzin", "Detalles");
            dataGridVenta.Rows.Add("Leandro morales", "4343", "Raul Alfonzin", "Detalles");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string encontrarCliente  = txtBuscar.Text;
            bool encontrado = false;

            foreach (DataGridViewRow recorrer in dataGridVenta.Rows)
            {
                if (recorrer.Cells[1].Value.ToString().IndexOf(encontrarCliente, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    recorrer.Visible = true;
                    encontrado = true;
                }
                else
                {
                    recorrer.Visible = false;
                }
            }

            if(!encontrado)
            {
                foreach(DataGridViewRow recorrer in dataGridVenta.Rows)
                {
                    recorrer.Visible = true;
                }
            }
        }
    }
}
