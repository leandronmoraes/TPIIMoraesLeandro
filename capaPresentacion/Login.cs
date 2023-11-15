using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using capaDatos;
using capaDatos.Models;
using capaNegocio;
using Org.BouncyCastle.Crypto.Generators;
using System.Net;
using System.Security.Policy;
using BCrypt.Net;

namespace capaPresentacion
{
    public partial class Login : Form
    {
        private CN_Login cnLogin;

        public Login()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
            btnMostrarContraseña.Visible = false;
            cnLogin = new CN_Login();
        }

        int idUsuario = ContextoCompartido.UsuarioId;
       
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            eliminarErrores();

            // Obtener el usuarioDNI desde el campo de texto
            int.TryParse(txtUsuario.Text, out int usuarioDNI);

            // Obtener la contraseña desde el campo de texto
            string contraseña = txtContraseña.Text.Trim();

            // Obtener el hash de la contraseña almacenada en la base de datos
            string hashAlmacenado = ObtenerHashContraseñaDesdeBD(usuarioDNI);

            // Verificar la contraseña utilizando BCrypt
            if (hashAlmacenado != null && (cnLogin.VerificarContraseña(usuarioDNI, contraseña) || BCrypt.Net.BCrypt.Verify(contraseña, hashAlmacenado)))
            {
                // Obtener el usuario desde la base de datos si es necesario para obtener su id_rol
                int id_rol = cnLogin.ObtenerIdRol(usuarioDNI);

                // Almacena el ID del usuario en el contexto compartido
                ContextoCompartido.UsuarioId = cnLogin.ObtenerIdVendedor(usuarioDNI);

                // Abrir el formulario correspondiente según el rol del usuario
                AbrirFormularioSegunRol(id_rol);
                
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Verificar usuario y contraseña.");
                mostrarErrores();
            }
        }


        // Función para obtener el hash de la contraseña almacenada en la base de datos
        private string ObtenerHashContraseñaDesdeBD(int usuarioDNI)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var usuario = db.usuario.FirstOrDefault(u => u.DNI_usuario == usuarioDNI);
                return usuario?.contraseña_usuario;
            }
        }


        // lógica para abrir el formulario correspondiente
        private void AbrirFormularioSegunRol(int id_rol)
        {
            switch (id_rol)
            {
                case 1: // "administrador"
                    FormAdministrador formAdm = new FormAdministrador();
                    formAdm.Show();
                    this.Hide();
                    break;
                case 2: // "gerente"
                    FormGerente formGerente = new FormGerente();
                    formGerente.Show();
                    this.Hide();
                    break;
                case 3: // "vendedor"
                    FormVendedor formVendedor = new FormVendedor();
                    formVendedor.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Perfil no reconocido");
                    break;
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult eleccion = MessageBox.Show("¿Está seguro de que desea salir de la aplicación?", "Salir de la aplicación", MessageBoxButtons.YesNo);

            if (eleccion == DialogResult.Yes)
            {
                // Si el usuario elige "Sí", cerrar la aplicación
                Application.Exit();
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

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter es un número o una tecla de control (como "Borrar")
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
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

        private void btnMostrarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.PasswordChar == '\0') // Si es '\0', la contraseña está visible
            {
                txtContraseña.PasswordChar = '*'; // Cambia a '*' u otro carácter de tu elección
            }
            else
            {
                txtContraseña.PasswordChar = '\0'; // Muestra la contraseña
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtContraseña.Text))
            {
                btnMostrarContraseña.Visible = true;
            }
            else
            {
                btnMostrarContraseña.Visible = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
