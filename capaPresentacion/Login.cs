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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text.Contains(" "))
            {
                errorInicioUsuario.SetError(textBox, "No se permiten espacios en este campo.");
            }
            else
            {
                errorInicioUsuario.SetError(textBox, ""); // Limpia el mensaje de error si no hay espacios.
            }
        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            eliminarErrores();
            if (txtContraseña.Text.Length > 0 && txtUsuario.Text.Length > 0)
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;

                switch (usuario)
                {
                    case "admin":
                        if (contraseña == "admin")
                        {
                            Form formAdm = new FormAdministrador();
                            formAdm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta para el perfil de administrador.");
                        }
                        break;

                    case "gerente":
                        if (contraseña == "gerente")
                        {

                            Form formGerente = new FormGerente();
                            formGerente.Show();
                            this.Hide();
                            MessageBox.Show("¡Bienvenido, Gerente!");
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta para el perfil de Gerente.");
                        }
                        break;

                    case "vendedor":
                        if (contraseña == "vendedor")
                        {
                            Form formVendedor = new FormVendedor();
                            formVendedor.Show();
                            this.Hide();
                            MessageBox.Show("¡Bienvenido, vendedor!");
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta para el perfil de vendedor.");
                        }
                        break;

                    default:
                        MessageBox.Show("Usuario Inexistente");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
                mostrarErrores();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validación para que no se pueda agregar espacios
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                // Llamar a la función de inicio de sesión
                btnIngresar_Click(sender, e);
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult eleccion = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Salir de la aplicación", MessageBoxButtons.YesNo);

            if (eleccion == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", cerrar la aplicación
                Close();
            }
            // Si el usuario elige "No", no hacer nada y la aplicación continuará en ejecución
        }


        //Error Providers

        //Esta función nos permite mostrar los errores
        private bool mostrarErrores()
        {
            bool campoCorrecto = true;
            if (txtUsuario.Text == "")
            {
                errorInicioUsuario.SetError(txtUsuario, "Ingrese usuario");
                campoCorrecto = false;
            }
            if (txtContraseña.Text == "")
            {
                errorInicioContraseña.SetError(txtContraseña, "Ingrese contraseña");
                campoCorrecto = false;
            }
            return campoCorrecto;
        }

        //Esta función nos permite quitar los errores asignandolo a vacio.
        private void eliminarErrores()
        {
            errorInicioUsuario.SetError(txtUsuario, "");
            errorInicioContraseña.SetError(txtContraseña, "");
        }
    }
}
