using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaPresentacion;

namespace capaPresentacion
{
    public class FormularioBase
    {
        public Panel panelContenedor;
        public Label lblHora;
        public Label lblFecha;
        public Label lblMensaje;
        public PictureBox pBoxInicio;

        public FormularioBase(Panel contenedor, Label hora, Label fecha, Label mensaje, PictureBox inicio)
        {
            panelContenedor = contenedor;
            lblHora = hora;
            lblFecha = fecha;
            lblMensaje = mensaje;
            pBoxInicio = inicio;
        }

        public void VolverAlInicio()
        {
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(lblHora);
            panelContenedor.Controls.Add(lblFecha);
            panelContenedor.Controls.Add(lblMensaje);
            panelContenedor.Controls.Add(pBoxInicio);
        }
    }
}



