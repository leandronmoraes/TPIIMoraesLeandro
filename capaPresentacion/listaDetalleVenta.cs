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
    public partial class listaDetalleVenta : Form
    {
        public listaDetalleVenta()
        {
            InitializeComponent();
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
