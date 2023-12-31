﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos.Models;
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
