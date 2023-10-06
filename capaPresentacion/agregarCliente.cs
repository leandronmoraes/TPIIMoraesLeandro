using capaDatos;
using CapaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            btnModificar.Enabled = false;

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
                if (dataGridClientes.CurrentRow != null && dataGridClientes.CurrentRow.Cells.Count >= 5)
                {
                    txtNombre.Text = dataGridClientes.CurrentRow.Cells[1].Value.ToString();
                    txtApellido.Text = dataGridClientes.CurrentRow.Cells[2].Value.ToString();
                    txtDNI.Text = dataGridClientes.CurrentRow.Cells[0].Value.ToString();
                    txtDireccion.Text = dataGridClientes.CurrentRow.Cells[3].Value.ToString();
                    txtTelefono.Text = dataGridClientes.CurrentRow.Cells[4].Value.ToString();
                    // Obtén la imagen desde la celda como tipo byte[]
                    byte[] imagenBytes = (byte[])dataGridClientes.CurrentRow.Cells[5].Value;

                    // Convierte los bytes en una imagen
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        Image imagen = Image.FromStream(ms);
                        pBoxAvatar.Image = imagen;
                    }

                    btnModificar.Enabled = true;
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
            if (txtApellido.Text.Length > 0 && txtDireccion.Text.Length > 0 && txtDNI.Text.Length > 0 && txtNombre.Text.Length > 0 && pBoxAvatar.Image != null)
            {
                int numeroDNI = 0;
                int.TryParse(txtDNI.Text, out numeroDNI);

                using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                {
                    // Validar si existe otro cliente con el mismo DNI
                    cliente clienteExistente = db.cliente.FirstOrDefault(c => c.DNI_cliente == numeroDNI);

                    if (clienteExistente == null)
                    {
                        // Crear un nuevo cliente
                        cliente nuevoCliente = new cliente
                        {
                            nombre_cliente = txtNombre.Text,
                            apellido_cliente = txtApellido.Text,
                            direccion = txtDireccion.Text,
                            telefono = txtTelefono.Text
                        };

                        // Guardar la imagen si se ha seleccionado una
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pBoxAvatar.Image.Save(ms, pBoxAvatar.Image.RawFormat);
                            nuevoCliente.avatar = ms.ToArray();
                        }

                        // Asignar el DNI
                        nuevoCliente.DNI_cliente = numeroDNI;

                        // Agregar el nuevo cliente a la base de datos
                        db.cliente.Add(nuevoCliente);
                        db.SaveChanges();

                        MessageBox.Show("Cliente insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe otro cliente con el mismo DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de insertar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void agregarCliente_Load(object sender, EventArgs e)
        {

            using(ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                
                var lst = from c in db.cliente
                          
                          select c;
                dataGridClientes.DataSource = lst.ToList();
            }



            Image image2 = Properties.Resources.usuario_verificado;
            pBoxAvatar.Image = imagenPorDefecto;

         
  
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length > 0 && txtDireccion.Text.Length > 0 && txtDNI.Text.Length > 0 && txtNombre.Text.Length > 0 && pBoxAvatar.Image != null)
            {
                int numeroDNI = 0;
                int.TryParse(txtDNI.Text, out numeroDNI);

                using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                {
                    // Obtener el DNI del cliente seleccionado en el DataGridView
                    int dniClienteSeleccionado = Convert.ToInt32(dataGridClientes.CurrentRow.Cells[0].Value);

                    // Buscar el cliente en la base de datos por su DNI
                    cliente clienteModificar = db.cliente.FirstOrDefault(c => c.DNI_cliente == dniClienteSeleccionado);

                    if (clienteModificar != null)
                    {
                        // Actualizar los valores del cliente
                        clienteModificar.nombre_cliente = txtNombre.Text;
                        clienteModificar.apellido_cliente = txtApellido.Text;
                        clienteModificar.direccion = txtDireccion.Text;
                        clienteModificar.telefono = txtTelefono.Text;

                        // Actualizar la imagen si se ha seleccionado una nueva
                        if (pBoxAvatar.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                pBoxAvatar.Image.Save(ms, pBoxAvatar.Image.RawFormat);
                                clienteModificar.avatar = ms.ToArray();
                            }
                        }

                        // Guardar los cambios en la base de datos
                        db.SaveChanges();

                        // Actualizar el DataGridView si es necesario
                        dataGridClientes.CurrentRow.Cells[0].Value = txtDNI.Text;
                        dataGridClientes.CurrentRow.Cells[1].Value = txtNombre.Text;
                        dataGridClientes.CurrentRow.Cells[2].Value = txtApellido.Text;
                        dataGridClientes.CurrentRow.Cells[3].Value = txtDireccion.Text;
                        dataGridClientes.CurrentRow.Cells[4].Value = txtTelefono.Text;
                        dataGridClientes.CurrentRow.Cells[5].Value = pBoxAvatar.Image;

                        MessageBox.Show("Se modificaron correctamente los datos", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // En caso que sea necesario se puede agregar más validaciones como el tamaño máximo, resolución.

                return true;
            }
            return false;
        }

       
        
            private void btnBuscar_Click(object sender, EventArgs e)
            {
                // Obtén el número de DNI ingresado en el TextBox
                int dniBuscado = 0;
                if (int.TryParse(txtBuscar.Text, out dniBuscado))
                {
                    using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
                    {
                        // Realiza la consulta en la base de datos para buscar el cliente por DNI
                        var clienteEncontrado = db.cliente.FirstOrDefault(c => c.DNI_cliente == dniBuscado);

                        if (clienteEncontrado != null)
                        {
                            // Si se encuentra el cliente, muestra sus datos en los controles correspondientes
                            txtNombre.Text = clienteEncontrado.nombre_cliente;
                            txtApellido.Text = clienteEncontrado.apellido_cliente;
                            txtDNI.Text = clienteEncontrado.DNI_cliente.ToString();
                            txtDireccion.Text = clienteEncontrado.direccion;
                            txtTelefono.Text = clienteEncontrado.telefono.ToString();

                            // Carga la imagen del cliente (si está disponible)
                            if (clienteEncontrado.avatar != null && clienteEncontrado.avatar.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(clienteEncontrado.avatar))
                                {
                                    pBoxAvatar.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                // Si no hay imagen, establece una imagen por defecto
                                pBoxAvatar.Image = imagenPorDefecto;
                            }

                            btnModificar.Enabled = true;
                        }
                        else
                        {
                            // Si no se encuentra el cliente, muestra un mensaje indicando que no se encontró
                            MessageBox.Show("No se encontró un cliente con el DNI especificado.", "Cliente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    // Si el número de DNI ingresado no es válido, muestra un mensaje de error
                    MessageBox.Show("Por favor, ingresa un número de DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }


