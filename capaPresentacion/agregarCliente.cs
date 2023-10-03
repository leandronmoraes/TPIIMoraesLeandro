using CapaEntidad;
using capaNegocio;
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
    public partial class agregarCliente : Form
    {
        private Image imagenPorDefecto;
        public agregarCliente()
        {
            InitializeComponent();
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

        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridClientes.CurrentRow != null && dataGridClientes.CurrentRow.Cells.Count >= 7)
                {
                    txtNombre.Text = dataGridClientes.CurrentRow.Cells[0].Value.ToString();
                    txtApellido.Text = dataGridClientes.CurrentRow.Cells[1].Value.ToString();
                    txtUsuario.Text = dataGridClientes.CurrentRow.Cells[2].Value.ToString();
                    txtDNI.Text = dataGridClientes.CurrentRow.Cells[3].Value.ToString();
                    txtDireccion.Text = dataGridClientes.CurrentRow.Cells[4].Value.ToString();
                    txtContraseña.Text = dataGridClientes.CurrentRow.Cells[5].Value.ToString();

                    Image imagen = (Image)dataGridClientes.CurrentRow.Cells[6].Value as System.Drawing.Image;
                    pBoxAvatar.Image = imagen;
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length > 0 && txtContraseña.Text.Length > 0 &&
                txtDireccion.Text.Length > 0 && txtDNI.Text.Length > 0 &&
                txtNombre.Text.Length > 0 && txtUsuario.Text.Length > 0 &&
                pBoxAvatar.Image != null)
            {
                {
                    // Confirmación para poder ingresar un usuario
                    DialogResult eleccion = MessageBox.Show("¿Confirmar Inserción?", "Agregar Usuario", MessageBoxButtons.YesNo);
                    {
                        // Elección en el caso que sí, guarda los datos
                        if (eleccion == DialogResult.Yes)
                        {
                            Image imagen = pBoxAvatar.Image;
                            dataGridClientes.Rows.Add(txtNombre.Text, txtApellido.Text, txtUsuario.Text,
                                txtDNI.Text, txtDireccion.Text, txtContraseña.Text,pBoxAvatar.Image);

                            txtApellido.Clear();
                            txtContraseña.Clear();
                            txtDireccion.Clear();
                            txtNombre.Clear();
                            txtUsuario.Clear();
                            txtDNI.Clear();
                            pBoxAvatar.Image = imagenPorDefecto;

                            MessageBox.Show("Usuario Agregado", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Usuario no agregado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No ingresaste todos los datos necesarios para poder añadir un usuario.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarCliente_Load(object sender, EventArgs e)
        {
            imagenPorDefecto = System.Drawing.Image.FromFile(@"D:\Facultad 2023 2do cuatrimestre\Taller de Programación II\ProyectoTPII_MoraesLeandro\ProyectoTPII_MoraesLeandro\capaPresentacion\Imagenes\clientes.png");
            pBoxAvatar.Image = imagenPorDefecto;

            /*Incorporarlo en la base de datos con las distintas capas
            List<Cliente> cliente = new CN_Cliente().listarCliente();
            foreach (Cliente recorrer in cliente)
            {
                dataGridClientes.Rows.Add(new object[]
                {
                    recorrer.DNI, 
                    recorrer.Nombre,

                });
            }
            */
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
                if (txtApellido.Text.Length > 0 && txtContraseña.Text.Length > 0 &&
                    txtDireccion.Text.Length > 0 && txtDNI.Text.Length > 0 &&
                    txtNombre.Text.Length > 0 && txtUsuario.Text.Length > 0 &&
                    pBoxAvatar.Image != null)
                {
                    //Confirmación para poder modificar un usuario
                    DialogResult eleccion = MessageBox.Show("¿Confirmar modificación?", "Modificación Usuario", MessageBoxButtons.YesNo);
                    {
                        //Elección en el caso que si, guarda los datos
                        if (eleccion == DialogResult.Yes)
                        {
                            dataGridClientes.CurrentRow.Cells[0].Value = txtNombre.Text;
                            dataGridClientes.CurrentRow.Cells[1].Value = txtApellido.Text;
                            dataGridClientes.CurrentRow.Cells[2].Value = txtUsuario.Text;
                            dataGridClientes.CurrentRow.Cells[3].Value = txtDNI.Text;
                            dataGridClientes.CurrentRow.Cells[4].Value = txtDireccion.Text;
                            dataGridClientes.CurrentRow.Cells[5].Value = txtContraseña.Text;

                            dataGridClientes.CurrentRow.Cells[6].Value = pBoxAvatar.Image;
                            System.Drawing.Image imagen = dataGridClientes.CurrentRow.Cells[6].Value as System.Drawing.Image;
                            pBoxAvatar.Image = imagen;

                            txtApellido.Clear();
                            txtContraseña.Clear();
                            txtDireccion.Clear();
                            txtNombre.Clear();
                            txtUsuario.Clear();
                            txtDNI.Clear();
                            pBoxAvatar.Image = imagenPorDefecto;

                            MessageBox.Show("Se modificaron correctamente los datos", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Usuario no modificado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario de la lista antes de modificarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void btnAñadirAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatar = new OpenFileDialog();
            avatar.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp"; // Filtra por extensiones de imágenes comunes
            if (avatar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Intenta cargar el archivo como una imagen
                    Image img = Image.FromFile(avatar.FileName);

                    // Verifica si es una imagen válida
                    if (EsImagenValida(img))
                    {
                        pBoxAvatar.BackgroundImage = null;
                        pBoxAvatar.Image = img;
                    }
                    else
                    {
                        MessageBox.Show("El archivo seleccionado no es una imagen válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool EsImagenValida(Image img)
        {
            if (img != null)
            {
                // Puedes agregar más validaciones si es necesario, como tamaño máximo, resolución, etc.
                return true;
            }
            return false;
        }
    }
}

