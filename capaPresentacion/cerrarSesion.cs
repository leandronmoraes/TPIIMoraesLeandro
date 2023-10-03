using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public static class cerrarSesion
    {
        public static bool ConfirmarCerrarSesion()
        {
            DialogResult eleccion = MessageBox.Show("¿Desea Cerrar Sesión?", "Cierre de Sesión", MessageBoxButtons.YesNo);

            if (eleccion == DialogResult.Yes)
            {
                MessageBox.Show("Cierre de Sesión Correcto", "Cierre de Sesión Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            return false;
        }
    }
}


   

