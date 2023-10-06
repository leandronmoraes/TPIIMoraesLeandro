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
        public static void ConfirmarCerrarSesion()
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                // Copiar la lista de formularios abiertos a una nueva lista
                List<Form> formulariosParaCerrar = Application.OpenForms.OfType<Form>().Where(f => f.Name == "listaDetalleVenta").ToList();

                // Cerrar los formularios en la lista copiada
                foreach (Form form in formulariosParaCerrar)
                {
                    form.Close();
                }

                // Abre un nuevo formulario de inicio de sesión
                Login form1 = new Login();
                form1.Show();
            }
        }
    }
}
