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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();

            //Deshabilitamos los botones inicialmente
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
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProveedores.CurrentRow != null && dgvProveedores.CurrentRow.Cells.Count >= 6)
                {
                    txtCuit.Text = dgvProveedores.CurrentRow.Cells[0].Value.ToString();
                    txtNombre.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
                    txtTelefono.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
                    txtEmail.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
                    txtDireccion.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();

                    // Recuperar el perfil actual
                    string perfilActual = dgvProveedores.CurrentRow.Cells[4].Value.ToString();

                    // Asignar el perfil actual a los radio buttons
                    if (perfilActual == "Responsable Inscripto")
                    {
                        rbtnInscripto.Checked = true;
                    }
                    else if (perfilActual == "Responsable No Inscripto")
                    {
                        rbtnNoInscripto.Checked = true;
                    }
                    else if (perfilActual == "Consumidor Final")
                    {
                        rbtnFinal.Checked = true;
                    }

                    // Habilitar los botones Eliminar y Modificar cuando se selecciona una fila.
                    btnEliminar.Enabled = true;
                    
                }
                else
                {
                    // Mostrar un mensaje de error o realizar alguna otra acción apropiada cuando no hay elementos seleccionados o no hay suficientes columnas.
                    MessageBox.Show("No se ha seleccionado una opción válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier otra excepción que pueda ocurrir durante la recuperación de datos.
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Length > 0 && txtNombre.Text.Length > 0 && txtCuit.Text.Length > 0 && txtEmail.Text.Length > 0
                && txtTelefono.Text.Length > 0)
            {
                // Verifica si al menos un radio button está marcado
                if (rbtnInscripto.Checked || rbtnNoInscripto.Checked || rbtnFinal.Checked)
                {
                    // Confirmación para poder ingresar un usuario
                    DialogResult eleccion = MessageBox.Show("¿Confirmar Inserción?", "Agregar Usuario", MessageBoxButtons.YesNo);
                    {
                        // Elección en el caso que sí, guarda los datos
                        if (eleccion == DialogResult.Yes)
                        {
                            // Obtiene el valor seleccionado de los radio buttons
                            string perfil = rbtnInscripto.Checked ? "Inscripto" : (rbtnNoInscripto.Checked ? "No Inscripto" : "Consumidor Final");

                           
                            dgvProveedores.Rows.Add(txtCuit.Text, txtNombre.Text, txtTelefono.Text, txtEmail.Text, 
                                perfil, txtDireccion.Text);

                            txtCuit.Clear();
                            txtNombre.Clear();
                            txtTelefono.Clear();
                            txtEmail.Clear();
                            txtDireccion.Clear();
                            

                            MessageBox.Show("Usuario Agregado", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Usuario no agregado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un perfil (Admin, Gerente o Vendedor) antes de agregar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ingresaste todos los datos necesarios para poder añadir un usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Length > 0 && txtNombre.Text.Length > 0 && txtCuit.Text.Length > 0 && txtEmail.Text.Length > 0
                && txtTelefono.Text.Length > 0)
            {
                // Confirmación para poder eliminar un proveedor
                DialogResult eleccion = MessageBox.Show("¿Confirmar Eliminación?", "Eliminar Usuario", MessageBoxButtons.YesNo);
                {
                    // Elección en el caso que sí, guarda los datos
                    if (eleccion == DialogResult.Yes)
                    {
                        dgvProveedores.Rows.Remove(dgvProveedores.CurrentRow);

                        txtCuit.Clear();
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        txtEmail.Clear();
                        txtDireccion.Clear();

                        MessageBox.Show("Usuario Eliminado", "Eliminación Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Deshabilitar el botón "Eliminar" después de eliminar un usuario
                        btnEliminar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Usuario no eliminado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista antes de eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string encontrarProveedor = txtBuscar.Text;
            bool encontrado = false;

            foreach (DataGridViewRow recorrer in dgvProveedores.Rows)
            {
                if (recorrer.Cells[0].Value.ToString().IndexOf(encontrarProveedor, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    recorrer.Visible = true;
                    encontrado = true;
                }
                else
                {
                    recorrer.Visible = false;
                }
            }

            if (!encontrado)
            {
                // Si no se encuentra ningún cliente, muestra todas las filas
                foreach (DataGridViewRow recorrer in dgvProveedores.Rows)
                {
                    recorrer.Visible = true;
                }
            }
        }
    }
}
