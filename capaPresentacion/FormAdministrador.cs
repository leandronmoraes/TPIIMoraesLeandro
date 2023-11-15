using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Windows.Media;
using capaPresentacion;
using capaDatos.Models;
using capaNegocio;
using System.Data.Entity;
using capaDatos;
using System.Globalization;

namespace capaPresentacion
{
    public partial class FormAdministrador : Form
    {

        private CN_Login cnLogin;
        //Clase que obtiene Hora y Fecha Actual, y los carga en su respectivo Label
        private TemporizadorHoraFecha temporizadorHoraFecha;

        //Clase mediante la cuál podemos limpiar el panelContenedor y volver al Inicio
        private FormularioBase formularioBase;

        public FormAdministrador()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Configurar los Label con valores iniciales
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();

            // Crear instancia de TemporizadorHoraFecha y pasar los Label correspondientes
            temporizadorHoraFecha = new TemporizadorHoraFecha(lblHora, lblFecha);

            // Inicializa la instancia de CN_Login
            cnLogin = new CN_Login();
            // Asigna los controles necesarios
            formularioBase = new FormularioBase(panelContenedor, lblHora, lblFecha, lblMensaje, pBoxInicio);

        }

        //Abertura Formularios

        //Para abrir el form de gestión productos
        private void AbrirFormProductos(object formProductos)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formProductos as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        //Abrir form de gestión de clientes
        private void AbrirFormClientes(object formClientes)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formClientes as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void AbrirFormClientes1(object formClientes1)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }

            Form fh = formClientes1 as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;

            if (fh is listaUsuarios)
            {
                listaUsuarios listaUsuariosForm = fh as listaUsuarios;
                listaUsuariosForm.MostrarSoloDataGridClientes();
            }

            fh.BringToFront();
            fh.Show();
        }

        

        private void AbrirFormConfiguraciones(object formConfiguraciones)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formConfiguraciones as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void AbrirFormDetallesVentas(object formDetallesVentas)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formDetallesVentas as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {


                // Formatea la fecha y hora actual en el formato deseado
                string fechaIngresoFormateada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Convierte la cadena formateada en un objeto DateTime
                DateTime fechaSalida = DateTime.ParseExact(fechaIngresoFormateada, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                int usuarioId = ContextoCompartido.UsuarioId;
                if (usuarioId > 0)
                {

                    using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                    {
                        var registro = db.RegistroUsuario
                            .Where(r => r.id_usuario == usuarioId)
                            .OrderByDescending(r => r.fecha_ingreso)
                            .FirstOrDefault();

                        if (registro != null)
                        {
                            registro.fecha_salida = fechaSalida;
                            db.SaveChanges();
                        }
                    }
                }

                // Crear una lista de formularios a cerrar
                List<Form> formulariosParaCerrar = new List<Form>();

                // Identificar los formularios a cerrar
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && (form.Name == "listaDetalleVenta"))
                    {
                        formulariosParaCerrar.Add(form);
                    }
                }

                // Cerrar los formularios en la lista
                foreach (Form form in formulariosParaCerrar)
                {
                    form.Close();
                }

                // Abre un nuevo formulario 
                Login form1 = new Login();
                form1.Show();

                // Oculta este formulario
                this.Hide();
            }
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormAdministrador_Resize(object sender, EventArgs e)
        {
            panelContenedor.Size = this.ClientSize;
        }

        private void btnGestionProducto_Click(object sender, EventArgs e)
        {
            AbrirFormProductos(new listaProductos());
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {


                // Formatea la fecha y hora actual en el formato deseado
                string fechaIngresoFormateada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Convierte la cadena formateada en un objeto DateTime
                DateTime fechaSalida = DateTime.ParseExact(fechaIngresoFormateada, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                int usuarioId = ContextoCompartido.UsuarioId;
                if (usuarioId > 0)
                {

                    using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                    {
                        var registro = db.RegistroUsuario
                            .Where(r => r.id_usuario == usuarioId)
                            .OrderByDescending(r => r.fecha_ingreso)
                            .FirstOrDefault();

                        if (registro != null)
                        {
                            registro.fecha_salida = fechaSalida;
                            db.SaveChanges();
                        }
                    }
                }

                // Crear una lista de formularios a cerrar
                List<Form> formulariosParaCerrar = new List<Form>();

                // Identificar los formularios a cerrar
                foreach (Form form in Application.OpenForms)
                {
                    if (form != this && (form.Name == "listaDetalleVenta"))
                    {
                        formulariosParaCerrar.Add(form);
                    }
                }

                // Cerrar los formularios en la lista
                foreach (Form form in formulariosParaCerrar)
                {
                    form.Close();
                }

                // Abre un nuevo formulario 
                Login form1 = new Login();
                form1.Show();

                // Oculta este formulario
                this.Hide();
            }
        }
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormConfiguraciones(new configuracionesAdmin());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            formularioBase.VolverAlInicio();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormClientes1(new listaUsuarios());
        }

        private void btnDetalleVentas_Click(object sender, EventArgs e)
        {
            AbrirFormDetallesVentas(new totalVentas());
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {

        }

  
        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormClientes(new listaUsuarios());
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            AbrirFormClientes(new listaClientes());
        }
    }
}
