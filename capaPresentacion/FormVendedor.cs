﻿using System;
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
    
    public partial class FormVendedor : Form
    {
        private TemporizadorHoraFecha temporizadorHoraFecha;
        //Clase mediante la cuál podemos limpiar el panelContenedor y volver al Inicio
        private FormularioBase formularioBase;

        public FormVendedor()
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

        private void AbrirFormRealizarVenta(object formRealizarVenta)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formRealizarVenta as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void AbrirFormListaVenta(object formListaVenta)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formListaVenta as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void AbrirFormGestionCliente(object formGestionCliente)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formGestionCliente as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
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



        private void btnInicio_Click(object sender, EventArgs e)
        {
            formularioBase.VolverAlInicio();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormRealizarVenta(new nuevaVenta());
        }

        private void btnListaVentas_Click(object sender, EventArgs e)
        {
            AbrirFormListaVenta(new formVenta());
        }

        private void btnGestionClientes_Click(object sender, EventArgs e)
        {
            AbrirFormGestionCliente(new agregarCliente());
        }
    }
}
