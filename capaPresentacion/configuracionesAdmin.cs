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
    public partial class configuracionesAdmin : Form
    {
        public configuracionesAdmin()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Backup Generado Exitosamente! implementar segunda entrega");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha restaurado con Exito! Implementar segunda entrega");
        }
    }
}
