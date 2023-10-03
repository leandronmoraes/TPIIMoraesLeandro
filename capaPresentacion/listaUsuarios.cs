using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace capaPresentacion
{
    public partial class listaUsuarios : Form
    {
        private Image imagenPorDefecto;
        public listaUsuarios()
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

        //Envia la celda determinada a su textbox correspondiente
        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridClientes.CurrentRow != null && dataGridClientes.CurrentRow.Cells.Count >= 8)
                {
                    txtNombre.Text = dataGridClientes.CurrentRow.Cells[0].Value.ToString();
                    txtApellido.Text = dataGridClientes.CurrentRow.Cells[1].Value.ToString();
                    txtUsuario.Text = dataGridClientes.CurrentRow.Cells[2].Value.ToString();
                    txtDNI.Text = dataGridClientes.CurrentRow.Cells[3].Value.ToString();
                    txtDireccion.Text = dataGridClientes.CurrentRow.Cells[4].Value.ToString();
                    txtContraseña.Text = dataGridClientes.CurrentRow.Cells[5].Value.ToString();

                    // Recuperar el perfil actual
                    string perfilActual = dataGridClientes.CurrentRow.Cells[6].Value.ToString();

                    // Asignar el perfil actual a los radio buttons
                    if (perfilActual == "Admin")
                    {
                        rbtnAdmin.Checked = true;
                    }
                    else if (perfilActual == "Gerente")
                    {
                        rbtnGerente.Checked = true;
                    }
                    else if (perfilActual == "Vendedor")
                    {
                        rbtnVendedor.Checked = true;
                    }
                
                    Image imagen = (Image)dataGridClientes.CurrentRow.Cells[7].Value as System.Drawing.Image;
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
                // Verifica si al menos un radio button está marcado
                if (rbtnAdmin.Checked || rbtnGerente.Checked || rbtnVendedor.Checked)
                {
                    // Confirmación para poder ingresar un usuario
                    DialogResult eleccion = MessageBox.Show("¿Confirmar Inserción?", "Agregar Usuario", MessageBoxButtons.YesNo);
                    {
                        // Elección en el caso que sí, guarda los datos
                        if (eleccion == DialogResult.Yes)
                        {
                            // Obtiene el valor seleccionado de los radio buttons
                            string perfil = rbtnAdmin.Checked ? "Admin" : (rbtnGerente.Checked ? "Gerente" : "Vendedor");

                            Image imagen = pBoxAvatar.Image;
                            dataGridClientes.Rows.Add(txtNombre.Text, txtApellido.Text, txtUsuario.Text,
                                txtDNI.Text, txtDireccion.Text, txtContraseña.Text, perfil, pBoxAvatar.Image);

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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length > 0 && txtContraseña.Text.Length > 0 &&
                txtDireccion.Text.Length > 0 && txtDNI.Text.Length > 0 &&
                txtNombre.Text.Length > 0 && txtUsuario.Text.Length > 0 &&
                pBoxAvatar.Image != null)
            {
                //Confirmación para poder eliminar un usuario
                DialogResult eleccion = MessageBox.Show("¿Confirmar Eliminación?", "Eliminar Usuario", MessageBoxButtons.YesNo);
                {
                    //Elección en el caso que si, guarda los datos
                    if (eleccion == DialogResult.Yes)
                    {
                        dataGridClientes.Rows.Remove(dataGridClientes.CurrentRow);

                        txtApellido.Clear();
                        txtContraseña.Clear();
                        txtDireccion.Clear();
                        txtNombre.Clear();
                        txtUsuario.Clear();
                        txtDNI.Clear();
                        pBoxAvatar.Image = imagenPorDefecto;

                        MessageBox.Show("Usuario Eliminado", "Eliminación Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnModificar_Click_1(object sender, EventArgs e)
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

                        // Actualiza el perfil en función de los radio buttons
                        if (rbtnAdmin.Checked)
                        {
                            dataGridClientes.CurrentRow.Cells[6].Value = "Admin";
                        }
                        else if (rbtnGerente.Checked)
                        {
                            dataGridClientes.CurrentRow.Cells[6].Value = "Gerente";
                        }
                        else if (rbtnVendedor.Checked)
                        {
                            dataGridClientes.CurrentRow.Cells[6].Value = "Vendedor";
                        }
                        else
                        {
                            MessageBox.Show("Seleccione una opción");
                        }

                        dataGridClientes.CurrentRow.Cells[7].Value = pBoxAvatar.Image;
                        System.Drawing.Image imagen = dataGridClientes.CurrentRow.Cells[7].Value as System.Drawing.Image;
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

        private void listaUsuarios_Load(object sender, EventArgs e)
        {

            //Cargamos de manera local

            dataGridClientes.Rows.Add("Leandro", "Moraes", "leandromoraes", 123, "barrio1", "contraseña", "vendedor");
            dataGridClientes.Rows.Add("Alexis", "Colman", "alexiscolman", 1234, "barrio1", "contraseña", "vendedor");
            dataGridClientes.Rows.Add("Lucas", "Haberles", "lucashaberles", 12345, "barrio1", "contraseña", "vendedor");
            dataGridClientes.Rows.Add("Lucas", "Parodi", "lucasparodi", 123456, "barrio1", "contraseña", "vendedor");
            dataGridClientes.Rows.Add("Leandro", "Ponce", "leandroponce", 1234567, "barrio1", "contraseña", "vendedor");
            imagenPorDefecto = System.Drawing.Image.FromFile(@"D:\Facultad 2023 2do cuatrimestre\Taller de Programación II\ProyectoTPII_MoraesLeandro\ProyectoTPII_MoraesLeandro\capaPresentacion\Imagenes\clientes.png");
            pBoxAvatar.Image = imagenPorDefecto;


            /*
            System.Drawing.Image image = System.Drawing.Image.FromFile
                (@"D:\Facultad 2023 2do cuatrimestre\Taller de Programación II\ProyectoTPII_MoraesLeandro\ProyectoTPII_MoraesLeandro\capaPresentacion\Imagenes\catalogar.png");
            dataGridClientes.Rows.Add("Leandro", "Moraes", "leandromoraes", "42743277", "Barrio Pirayui", "contraseña","Vendedor", image);
            */


        }

        public void MostrarSoloDataGridClientes()
        {
            foreach (Control control in this.Controls)
            {
                if (control != dataGridClientes )
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string encontrarCliente = txtBuscar.Text;
            bool encontrado = false;

            foreach (DataGridViewRow recorrer in dataGridClientes.Rows)
            {
                if (recorrer.Cells[2].Value.ToString().IndexOf(encontrarCliente, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    recorrer.Cells[3].Value.ToString().IndexOf(encontrarCliente, StringComparison.OrdinalIgnoreCase) >= 0)
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
                foreach (DataGridViewRow recorrer in dataGridClientes.Rows)
                {
                    recorrer.Visible = true;
                }
            }
        }
    }
}

