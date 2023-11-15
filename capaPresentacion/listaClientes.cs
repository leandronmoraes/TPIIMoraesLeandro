using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class listaClientes : Form
    {
        public listaClientes()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnMostrarInactivos.Text = "Mostrar Inactivos";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                // Verifica si el cuadro de búsqueda está vacío
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    // Si está vacío y estás en la vista de inactivos, muestra solo los clientes inactivos
                    if (mostrarInactivos)
                    {
                        CargarClientesInactivos();
                    }
                    else
                    {
                        // Si está vacío y no estás en la vista de inactivos, reinicia el DataGridView (muestra todos los clientes activos)
                        CargarClientes();
                    }
                }
                else
                {
                    // Filtra los clientes por DNI y estado (insensible a mayúsculas y minúsculas)
                    var clientes = from c in db.cliente
                                   where (mostrarInactivos ? c.estado == 0 : c.estado == 1) &&
                                         c.DNI_cliente.ToLower().Contains(txtBuscar.Text.ToLower())
                                   select new
                                   {
                                       c.id_cliente,
                                       c.DNI_cliente,
                                       c.nombre_cliente,
                                       c.apellido_cliente,
                                       c.direccion,
                                       c.telefono,
                                       c.estado,
                                   };

                    dataGridClientes.DataSource = clientes.ToList();
                }
            }
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length > 0 && txtDireccion.Text.Length > 0 && txtDNI.Text.Length > 0 && txtNombre.Text.Length > 0)
            {
                int numeroDNI = 0;
                int.TryParse(txtDNI.Text, out numeroDNI);

                using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                {
                    // Obtener el DNI del cliente seleccionado en el DataGridView
                    int dniClienteSeleccionado = Convert.ToInt32(dataGridClientes.CurrentRow.Cells[0].Value);

                    // Buscar el cliente en la base de datos por su DNI
                    cliente clienteModificar = db.cliente.FirstOrDefault(c => c.DNI_cliente == txtDNI.Text);

                    if (clienteModificar != null)
                    {
                        // Mostrar un cuadro de diálogo de confirmación
                        DialogResult result = MessageBox.Show("¿Desea modificar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Realizar la modificación solo si el usuario confirma
                            // Actualizar los valores del cliente
                            clienteModificar.nombre_cliente = txtNombre.Text;
                            clienteModificar.apellido_cliente = txtApellido.Text;
                            clienteModificar.direccion = txtDireccion.Text;
                            clienteModificar.telefono = txtTelefono.Text;

                            // Guardar los cambios en la base de datos
                            db.SaveChanges();
                            cargarFormulario();

                            // Actualizar el DataGridView si es necesario
                            dataGridClientes.CurrentRow.Cells[1].Value = txtDNI.Text;
                            dataGridClientes.CurrentRow.Cells[2].Value = txtNombre.Text;
                            dataGridClientes.CurrentRow.Cells[3].Value = txtApellido.Text;
                            dataGridClientes.CurrentRow.Cells[4].Value = txtDireccion.Text;
                            dataGridClientes.CurrentRow.Cells[5].Value = txtTelefono.Text;

                            MessageBox.Show("Se modificaron correctamente los datos", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un cliente con el DNI especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista antes de modificarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaClientes_Load(object sender, EventArgs e)
        {
            cargarFormulario();
        }

        private void cargarFormulario()
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var clientes = from c in db.cliente
                               where (mostrarInactivos ? c.estado == 0 : c.estado == 1)
                               select new
                               {
                                   c.id_cliente,
                                   c.DNI_cliente,
                                   c.nombre_cliente,
                                   c.apellido_cliente,
                                   c.direccion,
                                   c.telefono,
                                   c.estado,
                               };

                dataGridClientes.DataSource = clientes.ToList();

                // Actualiza la visibilidad de los botones según la condición
                btnCambiarEstado.Visible = mostrarInactivos;
                btnModificar.Visible = !mostrarInactivos;
                btnEliminar.Visible = !mostrarInactivos;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado no es un número y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni la tecla de retroceso, suprimir el carácter ingresado
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número ni la tecla de retroceso, suprimir el carácter ingresado
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null && dataGridClientes.CurrentRow.Cells.Count >= 5)
            {
                // Obtén el ID del cliente seleccionado
                int clienteId = Convert.ToInt32(dataGridClientes.CurrentRow.Cells[0].Value);

                using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                {
                    // Recupera el cliente de la base de datos según el ID
                    cliente clienteEliminar = db.cliente.FirstOrDefault(c => c.id_cliente == clienteId);

                    if (clienteEliminar != null)
                    {
                        // Muestra un cuadro de diálogo de confirmación
                        DialogResult result = MessageBox.Show("¿Desea dar de baja este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Establece el estado en 0 (inactivo)
                            clienteEliminar.estado = 0;

                            // Guarda los cambios en la base de datos
                            db.SaveChanges();

                            // Recarga el formulario para actualizar el DataGridView
                            cargarFormulario();
                        }
                        MessageBox.Show("Cliente dado de baja correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un cliente con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista antes de eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool mostrarInactivos = false;
        private void btnMostrarInactivos_Click(object sender, EventArgs e)
        {
            mostrarInactivos = !mostrarInactivos; // Cambia el estado de la variable

            if (mostrarInactivos)
            {
                btnMostrarInactivos.Text = "Mostrar Activos"; // Actualiza el texto del botón
            }
            else
            {
                btnMostrarInactivos.Text = "Mostrar Inactivos"; // Actualiza el texto del botón
            }

            // Recarga el formulario para mostrar los clientes según el estado seleccionado
            cargarFormulario();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dataGridClientes.CurrentRow != null && dataGridClientes.CurrentRow.Cells.Count >= 5)
            {
                // Obtén el ID del cliente seleccionado
                int clienteId = Convert.ToInt32(dataGridClientes.CurrentRow.Cells[0].Value);

                using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                {
                    // Recupera el cliente de la base de datos según el ID
                    cliente clienteCambiarEstado = db.cliente.FirstOrDefault(c => c.id_cliente == clienteId);

                    if (clienteCambiarEstado != null)
                    {
                        // Muestra un cuadro de diálogo de confirmación
                        DialogResult result = MessageBox.Show("¿Desea cambiar el estado de este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            // Cambia el estado del cliente (1 a 0 o viceversa)
                            clienteCambiarEstado.estado = (clienteCambiarEstado.estado == 1) ? 0 : 1;

                            // Guarda los cambios en la base de datos
                            db.SaveChanges();

                            // Recarga el formulario para actualizar el DataGridView
                            cargarFormulario();

                            MessageBox.Show("Estado del cliente cambiado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un cliente con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista antes de cambiar su estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para cargar todos los clientes (sin filtrar)
        private void CargarClientes()
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var clientes = from c in db.cliente
                               where (mostrarInactivos ? true : c.estado == 1)
                               select new
                               {
                                   c.id_cliente,
                                   c.DNI_cliente,
                                   c.nombre_cliente,
                                   c.apellido_cliente,
                                   c.direccion,
                                   c.telefono,
                                   c.estado,
                               };

                dataGridClientes.DataSource = clientes.ToList();
            }
        }

        // Método para cargar solo los clientes inactivos
        private void CargarClientesInactivos()
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var clientesInactivos = from c in db.cliente
                                        where c.estado == 0
                                        select new
                                        {
                                            c.id_cliente,
                                            c.DNI_cliente,
                                            c.nombre_cliente,
                                            c.apellido_cliente,
                                            c.direccion,
                                            c.telefono,
                                            c.estado,
                                        };

                dataGridClientes.DataSource = clientesInactivos.ToList();
            }
        }

        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridClientes.CurrentRow != null && dataGridClientes.CurrentRow.Cells.Count >= 5)
                {
                    txtNombre.Text = dataGridClientes.CurrentRow.Cells[2].Value.ToString();
                    txtApellido.Text = dataGridClientes.CurrentRow.Cells[3].Value.ToString();
                    txtDNI.Text = dataGridClientes.CurrentRow.Cells[1].Value.ToString();
                    txtDireccion.Text = dataGridClientes.CurrentRow.Cells[4].Value.ToString();
                    txtTelefono.Text = dataGridClientes.CurrentRow.Cells[5].Value.ToString();



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

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}

