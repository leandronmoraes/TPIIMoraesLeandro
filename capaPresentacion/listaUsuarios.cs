using capaDatos;
using capaDatos.Models;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;


namespace capaPresentacion
{
    public partial class listaUsuarios : Form
    {
        private CN_Usuario cnUsuario = new CN_Usuario();
        private CN_TipoRol cnTipoRol = new CN_TipoRol();

        private List<usuario> usuarios;

        public listaUsuarios()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCambiarEstado.Visible = false;
            // Configura la interfaz de usuario según sea necesario.
            cnTipoRol = new CN_TipoRol(); // Inicializa cnTipoRol
        }

        private void listaUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            MostrarTiposRol();
            ConfigurarNombresColumnas();
        }

        private void MostrarUsuarios()
        {
            // Obtener solo los usuarios activos (estado = 1)
            usuarios = cnUsuario.ObtenerUsuariosPorEstado(1);

            // Asignar la lista de usuarios al DataSource del dataGridClientes
            dataGridClientes.DataSource = usuarios;
        }

        private int ObtenerIdRolSeleccionado()
        {
            if (rbtnAdmin.Checked)
            {
                return 1; // ID del rol "administrador"
            }
            else if (rbtnGerente.Checked)
            {
                return 2; // ID del rol "gerente"
            }
            else if (rbtnVendedor.Checked)
            {
                return 3; // ID del rol "vendedor"
            }

            MessageBox.Show("Debe seleccionar un tipo de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             return 0;
        }


        private void MostrarTiposRol()
        {
            List<tipo_rol> tiposRol = cnTipoRol.ObtenerTiposRol();

            if (tiposRol.Count >= 3)
            {
                rbtnAdmin.Text = tiposRol[0].descripcion_rol;
                rbtnGerente.Text = tiposRol[1].descripcion_rol;
                rbtnVendedor.Text = tiposRol[2].descripcion_rol;
            }
        }



        private void btnAñadir_Click(object sender, EventArgs e)
        {
            int DNI;
            if (!int.TryParse(txtDNI.Text, out DNI))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idRol = ObtenerIdRolSeleccionado();
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string contraseña = txtContraseña.Text;

            if (idRol == 0 || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Preguntar al usuario si realmente desea agregar el nuevo usuario
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea agregar este usuario?", "Confirmar Adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Verificar si ya existe un usuario con el mismo DNI
                if (usuarios.Any(u => u.DNI_usuario == DNI))
                {
                    MessageBox.Show("Ya existe un usuario con el mismo DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Crear un objeto usuario con los datos obtenidos de los controles.
                    var nuevoUsuario = new usuario
                    {
                        DNI_usuario = DNI,
                        id_rol = idRol,
                        nombre_usuario = nombre,
                        apellido_usuario = apellido,
                        direccion_usuario = direccion,
                        contraseña_usuario = contraseña,
                        estado = 1
                    };

                    // Llamar al método de la capa de negocio para agregar el usuario.
                    cnUsuario.AgregarUsuario(nuevoUsuario);

                   
                    // Limpia los campos después de agregar el usuario.
                    LimpiarCampos();
                    MessageBox.Show("Usuario agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Actualizar la lista de usuarios si es necesario.
                    MostrarUsuarios();
                }
            }
            
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null)
            {
                // Preguntar al usuario si realmente desea modificar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea modificar este usuario?", "Confirmar Modificación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (resultado == DialogResult.Yes)
                {
                    var usuarioSeleccionado = ObtenerUsuarioSeleccionado();

                    // Actualizar los datos del usuario seleccionado
                    usuarioSeleccionado.DNI_usuario = int.Parse(txtDNI.Text);
                    usuarioSeleccionado.id_rol = ObtenerIdRolSeleccionado();
                    usuarioSeleccionado.nombre_usuario = txtNombre.Text;
                    usuarioSeleccionado.apellido_usuario = txtApellido.Text;
                    usuarioSeleccionado.direccion_usuario = txtDireccion.Text;

                    // Obtener el valor del campo de contraseña
                    string nuevaContraseña = txtContraseña.Text;

                    // Llama al método de la capa de negocio para modificar el usuario
                    cnUsuario.ModificarUsuario(usuarioSeleccionado, nuevaContraseña);

                    // Vuelve a cargar la lista de usuarios
                    MostrarUsuarios();

                    // Limpia los campos después de modificar el usuario
                    LimpiarCampos();
                }
            }
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null)
            {
                // Preguntar al usuario si realmente desea eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (resultado == DialogResult.Yes)
                {
                    var usuarioSeleccionado = ObtenerUsuarioSeleccionado();
                    cnUsuario.DarDeBajaUsuario(usuarioSeleccionado.id_usuario);
                    MostrarUsuarios();
                    LimpiarCampos();
                }
              
            }
        }


        private usuario ObtenerUsuarioSeleccionado()
        {
            int idUsuario = (int)dataGridClientes.CurrentRow.Cells["id_usuario"].Value;
            return usuarios.Find(u => u.id_usuario == idUsuario);
        }


        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtContraseña.Clear();   
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        

        public void MostrarSoloDataGridClientes()
        {
            foreach (Control control in this.Controls)
            {
                if (control != dataGridClientes)
                {
                    control.Visible = false;
                }
            }

            // Se definio un color personalizado
            Color miColor = Color.FromArgb(49, 66, 82);

            // Cambia el color de fondo del DataGridView al color personalizado
            dataGridClientes.BackgroundColor = miColor;


            // Configura el DataGridView y los Label para mostrarlos adecuadamente
            dataGridClientes.Visible = true;
            dataGridClientes.Width = 1123; // Establecer el ancho deseado
            dataGridClientes.Height = 615; // Establecer la altura deseada
            label1.Visible = true;


            // Cambia la ubicación del DataGridView
            int x = 0; // Cambia esto a la posición X deseada
            int y = 100; // Cambia esto a la posición Y deseada
            dataGridClientes.Location = new Point(x, y);

            // Configura el Label1
            label1.Visible = true;
            int label1X = (this.Width - label1.Width) / 2; // Centra el Label1 horizontalmente
            int label1Y = 30; // Cambia esto a la posición Y deseada para mover el Label hacia arriba en el medio
            label1.Location = new Point(label1X, label1Y);

            txtBuscar.Visible = true;
            int txtBuscarX = 100;
            int txtBuscarY = 70;
            txtBuscar.Location = new Point(txtBuscarX, txtBuscarY);

            lblBuscar.Visible = true;
            int lblBuscarX = 10;
            int lblBuscarY = 70;
            lblBuscar.Location = new Point(lblBuscarX, lblBuscarY);

        }

        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridClientes.CurrentRow != null && dataGridClientes.CurrentRow.Cells.Count >= 8)
                {
                    txtDNI.Text = dataGridClientes.CurrentRow.Cells[1].Value.ToString();
                    txtNombre.Text = dataGridClientes.CurrentRow.Cells[3].Value.ToString();
                    txtApellido.Text = dataGridClientes.CurrentRow.Cells[4].Value.ToString();
                    txtDireccion.Text = dataGridClientes.CurrentRow.Cells[5].Value.ToString();
                    //txtContraseña.Text = dataGridClientes.CurrentRow.Cells[6].Value.ToString();

                    // Obtener el perfil actual
                    string perfilActual = dataGridClientes.CurrentRow.Cells["id_rol"].Value.ToString();

                    // Asignar el perfil actual a los radio buttons
                    switch (perfilActual)
                    {
                        case "1":
                            rbtnAdmin.Checked = true;
                            break;
                        case "2":
                            rbtnGerente.Checked = true;
                            break;
                        case "3":
                            rbtnVendedor.Checked = true;
                            break;
                        default:
                            // Puedes manejar el caso en el que el perfil no coincide con ninguno de los casos anteriores.
                            break;
                    }

                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
                else
                {
                    // Mostrar un mensaje de error o realizar alguna otra acción apropiada cuando no hay elementos seleccionados o no hay suficientes columnas.
                    MessageBox.Show("No se ha seleccionado un usuario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier otra excepción que pueda ocurrir durante la recuperación de datos.
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



       

        

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null)
            {
                int idUsuario = (int)dataGridClientes.CurrentRow.Cells["id_usuario"].Value;

                // Mensaje de confirmación antes de cambiar el estado
                DialogResult result = MessageBox.Show("¿Está seguro de cambiar el estado del usuario?", "Confirmar Cambio de Estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int nuevoEstado = (estadoActual == 1) ? 0 : 1;

                    cnUsuario.CambiarEstadoUsuario(idUsuario, nuevoEstado);

                    // Vuelve a cargar la lista de usuarios según el estado actual
                    var usuarios = cnUsuario.ObtenerUsuariosPorEstado(estadoActual);
                    dataGridClientes.DataSource = usuarios;

                    // Mostrar u ocultar el botón "Cambiar Estado" según el estado actual
                    btnCambiarEstado.Visible = (estadoActual == 0);
                    btnCambiarEstado.Enabled = (estadoActual == 0);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario antes de cambiar el estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text;

            // Llamar al método de búsqueda en la capa de negocios según el estado actual
            List<usuario> resultados = cnUsuario.BuscarUsuariosPorDNIEnTiempoReal(textoBusqueda, estadoActual);

            // Actualizar el DataSource del DataGridView con los resultados
            dataGridClientes.DataSource = resultados;
        }

        private void ConfigurarNombresColumnas()
        {

            // Ocultar columnas que no deseas mostrar
            dataGridClientes.Columns["RegistroUsuario"].Visible = false;
            dataGridClientes.Columns["tipo_rol"].Visible = false;
            dataGridClientes.Columns["venta"].Visible = false;
            dataGridClientes.Columns["estado"].Visible = false;

            // Cambiar el nombre de las columnas programáticamente
            dataGridClientes.Columns["id_usuario"].HeaderText = "ID";
            dataGridClientes.Columns["DNI_usuario"].HeaderText = "DNI";
            dataGridClientes.Columns["nombre_usuario"].HeaderText = "Nombre";
            dataGridClientes.Columns["apellido_usuario"].HeaderText = "Apellido";
            dataGridClientes.Columns["direccion_usuario"].HeaderText = "Dirección";
            dataGridClientes.Columns["contraseña_usuario"].HeaderText = "Contraseña";
            dataGridClientes.Columns["id_rol"].HeaderText = "Rol";
            dataGridClientes.Columns["estado"].HeaderText = "Estado"; // Añade esta línea

            dataGridClientes.Columns["id_rol"].DataPropertyName = "id_rol";
            dataGridClientes.Columns["estado"].DataPropertyName = "estado"; // Añade esta línea



        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni la tecla de retroceso, suprimir el carácter ingresado
                e.Handled = true;
            }
        }
        private int estadoActual = 1; // 1 para usuarios activos, 0 para usuarios inactivos
        private void btnVerInactivos_Click_1(object sender, EventArgs e)
        {
            btnCambiarEstado.Visible = true;

            // Alterna entre usuarios activos e inactivos con cada clic
            estadoActual = (estadoActual == 1) ? 0 : 1;

            var usuarios = cnUsuario.ObtenerUsuariosPorEstado(estadoActual);
            dataGridClientes.DataSource = usuarios;

            // Oculta el botón "Cambiar Estado" si estamos mostrando usuarios activos
            btnCambiarEstado.Visible = (estadoActual == 0);
            btnCambiarEstado.Enabled = (estadoActual == 0);

            btnAñadir.Visible = (estadoActual == 1);
            btnModificar.Visible = (estadoActual == 1);
            btnEliminar.Visible = (estadoActual == 1);
        }

        private void dataGridClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridClientes.Columns["id_rol"].Index && e.Value != null)
            {
                int idRol = Convert.ToInt32(e.Value);

                // Mapea el ID del rol a su descripción correspondiente
                switch (idRol)
                {
                    case 1:
                        e.Value = "Admin";
                        break;
                    case 2:
                        e.Value = "Gerente";
                        break;
                    case 3:
                        e.Value = "Vendedor";
                        break;
                    default:
                        e.Value = "Desconocido";
                        break;
                }
            }

            // Añade este bloque para la columna de estado
            if (e.ColumnIndex == dataGridClientes.Columns["estado"].Index && e.Value != null)
            {
                int estado = Convert.ToInt32(e.Value);

                // Mapea el valor del estado a "activo" o "inactivo"
                e.Value = (estado == 1) ? "Activo" : "Inactivo";
            }

        }

    }
}
    


