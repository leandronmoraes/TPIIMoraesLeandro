using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaPresentacion;

namespace capaPresentacion
{

    public partial class FormGerente : Form
    {
        private TemporizadorHoraFecha temporizadorHoraFecha;
        private FormularioBase formularioBase;

        public FormGerente()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Configurar los Label con valores iniciales
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();

            // Crear instancia de TemporizadorHoraFecha y pasar los Label correspondientes
            temporizadorHoraFecha = new TemporizadorHoraFecha(lblHora, lblFecha);

            // Asigna los controles necesarios
            formularioBase = new FormularioBase(panelContenedor, lblHora, lblFecha, lblMensaje, pBoxInicio);

        }

        private void AbrirFormGestionProveedor(object formGestionProveedor)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formGestionProveedor as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }
        private void AbrirFormGestionPedidos(object formGestionPedidos)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formGestionPedidos as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }
        private void AbrirFormReportes(object formReportes)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formReportes as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            formularioBase.VolverAlInicio();
        }

        private void btnGestionProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormGestionProveedor(new FormProveedores());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
                if (cerrarSesion.ConfirmarCerrarSesion())
                {
                    Login ventana = new Login();
                    ventana.Show();
                    this.Hide();
                }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnReportesVentas_Click(object sender, EventArgs e)
        {
            AbrirFormReportes(new FormEstadisticas());
        }

        private void btnGestionPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormGestionPedidos(new listaPedidos());
        }

        
    }
}
