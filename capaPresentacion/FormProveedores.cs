using capaDatos.Models;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class FormProveedores : Form
    {
        private CN_Proveedor proveedorNegocio;
        private bool mostrandoProveedoresActivos = true;
        public FormProveedores()
        {
            InitializeComponent();
            proveedorNegocio = new CN_Proveedor();
            // Deshabilitamos los botones inicialmente
            btnEliminar.Enabled = false;

            
        }


        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string correo = txtEmail.Text;
            if (txtDireccion.Text.Length > 0 && correoBueno(correo) && txtNombre.Text.Length > 0 && txtCuit.Text.Length > 0 && txtEmail.Text.Length > 0
                && txtTelefono.Text.Length > 0)
            {
                // Validar que no haya proveedores duplicados
                if (!proveedorNegocio.ProveedorDuplicado(txtCuit.Text))
                {
                    // Confirmación para poder ingresar un proveedor
                    DialogResult eleccion = MessageBox.Show("¿Confirmar Inserción?", "Agregar Proveedor", MessageBoxButtons.YesNo);
                    if (eleccion == DialogResult.Yes)
                    {
                        // Obtiene el valor seleccionado de los radio buttons
                        string perfil = GetRadioButtonCheckedText();

                        // Crear una nueva entidad de Proveedor con los datos del formulario
                        proveedor nuevoProveedor = new proveedor
                        {
                            cuit_proveedor = txtCuit.Text,
                            nombre_proveedor = txtNombre.Text,
                            telefono_proveedor = txtTelefono.Text,
                            email_proveedor = txtEmail.Text,
                            IVA = perfil,
                            direccion_proveedor = txtDireccion.Text
                        };

                        // Agregar el nuevo proveedor a través de la capa de negocio
                        proveedorNegocio.AgregarProveedor(nuevoProveedor);

                        // Limpiar los campos del formulario
                        LimpiarCampos();

                        MessageBox.Show("Proveedor Agregado", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no agregado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un proveedor con el mismo CUIT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ingresaste todos los datos necesarios para poder añadir un proveedor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                DialogResult eleccion = MessageBox.Show("¿Confirmar Cambio de Estado?", "Cambiar Estado del Proveedor", MessageBoxButtons.YesNo);
                if (eleccion == DialogResult.Yes)
                {
                    int proveedorId = (int)dgvProveedores.SelectedRows[0].Cells["id_proveedor"].Value;
                    proveedorNegocio.CambiarEstadoProveedor(proveedorId);

                    dgvProveedores.DataSource = proveedorNegocio.ObtenerTodosLosProveedores();

                    txtCuit.Clear();
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtEmail.Clear();
                    txtDireccion.Clear();

                    MessageBox.Show("Estado del Proveedor Cambiado a Inactivo", "Cambio de Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnEliminar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un proveedor de la lista antes de cambiar su estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetRadioButtonCheckedText()
        {
            if (rbtnInscripto.Checked)
            {
                return "Responsable inscripto";
            }
            else if (rbtnNoInscripto.Checked)
            {
                return "Responsable no inscripto";
            }
            else if (rbtnFinal.Checked)
            {
                return "Consumidor final";
            }

            return string.Empty; // Devuelve una cadena vacía si no hay ninguno seleccionado
        }

        private void LimpiarCampos()
        {
            txtCuit.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            errorProvider1.SetError(txtEmail, "");
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvProveedores.CurrentRow != null && dgvProveedores.CurrentRow.Cells.Count >= 6)
                {

                    txtCuit.Text = dgvProveedores.CurrentRow.Cells[3].Value.ToString();
                    txtNombre.Text = dgvProveedores.CurrentRow.Cells[1].Value.ToString();
                    txtTelefono.Text = dgvProveedores.CurrentRow.Cells[2].Value.ToString();
                    txtEmail.Text = dgvProveedores.CurrentRow.Cells[4].Value.ToString();
                    txtDireccion.Text = dgvProveedores.CurrentRow.Cells[5].Value.ToString();

                    // Recuperar el perfil actual
                    string perfilActual = dgvProveedores.CurrentRow.Cells[6].Value.ToString();

                    // Asignar el perfil actual a los radio buttons
                    switch (perfilActual)
                    {
                        case "Responsable Inscripto":
                            rbtnInscripto.Checked = true;
                            break;
                        case "Responsable No Inscripto":
                            rbtnNoInscripto.Checked = true;
                            break;
                        case "Consumidor Final":
                            rbtnFinal.Checked = true;
                            break;
                    }

                    // Habilitar los botones Eliminar y Modificar cuando se selecciona una fila.
                    btnEliminar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado una opción válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier otra excepción que pueda ocurrir durante la recuperación de datos.
                MessageBox.Show("Se ha producido un error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {

            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                CargarProveedoresActivos();
                cambiarColumna();
            }
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

        private void CargarProveedoresActivos()
        {
            dgvProveedores.DataSource = proveedorNegocio.ObtenerProveedoresActivos();
        }

        private void CargarProveedoresInactivos()
        {
            dgvProveedores.DataSource = proveedorNegocio.ObtenerProveedoresInactivos();
        }


        private void btnAlternarEstado_Click(object sender, EventArgs e)
        {
            if (mostrandoProveedoresActivos)
            {
                CargarProveedoresInactivos();
                btnAlternarEstado.Text = "Mostrar Activos";
            }
            else
            {
                CargarProveedoresActivos();
                btnAlternarEstado.Text = "Mostrar Inactivos";
            }

            mostrandoProveedoresActivos = !mostrandoProveedoresActivos;
        }

        public bool correoBueno(string direccionCorreo)
        {

            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$";


            Regex regex = new Regex(patron);


            return regex.IsMatch(direccionCorreo);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            if (correoBueno(txtEmail.Text) == false)
            {
                errorProvider1.SetError(txtEmail, "Formato de correo incorrecto");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void btnBuscarPorCUIT_Click_1(object sender, EventArgs e)
        {
            string cuitBusqueda = txtBuscarCuit.Text;

            if (!string.IsNullOrEmpty(cuitBusqueda))
            {
                List<proveedor> proveedoresEncontrados = proveedorNegocio.BuscarProveedorPorCUIT(cuitBusqueda);

                if (proveedoresEncontrados.Count > 0)
                {
                    dgvProveedores.DataSource = proveedoresEncontrados;
                }
                else
                {
                    MessageBox.Show("No se encontraron proveedores con el CUIT especificado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un CUIT para realizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cambiarColumna()
        {
            //Cambiar Header
            dgvProveedores.Columns["id_proveedor"].HeaderText = "ID";
            dgvProveedores.Columns["nombre_proveedor"].HeaderText = "Nombre del Proveedor";
            dgvProveedores.Columns["telefono_proveedor"].HeaderText = "Teléfono";
            dgvProveedores.Columns["cuit_proveedor"].HeaderText = "CUIT";
            dgvProveedores.Columns["direccion_proveedor"].HeaderText = "Dirección";

            //Ocultar Tablas
            dgvProveedores.Columns["pedido"].Visible = false;
            dgvProveedores.Columns["producto"].Visible = false;
            dgvProveedores.Columns["estado"].Visible = false;
        }

        private void txtBuscarCuit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cuitBusqueda = txtBuscarCuit.Text;

                if (!string.IsNullOrEmpty(cuitBusqueda))
                {
                    List<proveedor> proveedoresEncontrados = proveedorNegocio.BuscarProveedorPorCUIT(cuitBusqueda);

                    if (proveedoresEncontrados.Count > 0)
                    {
                        dgvProveedores.DataSource = proveedoresEncontrados;
                    }
                    else
                    {
                        // Si no se encuentran resultados, puedes volver a cargar todos los proveedores activos.
                        CargarProveedoresActivos();
                    }
                }
                else
                {
                    // Si el cuadro de búsqueda está vacío, muestra todos los proveedores activos.
                    CargarProveedoresActivos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla para eliminar(backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}

