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
    public partial class listaProductos : Form
    {
        private Image imagenPorDefecto;

        public listaProductos()
        {
            InitializeComponent();
            btnEliminarProducto.Enabled = false;
            btnModificarProducto.Enabled = false;
            cmbBoxCategorias.SelectedIndex = 0;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras (mayúsculas y minúsculas), números y espacios
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagenProd = new OpenFileDialog();

            if (imagenProd.ShowDialog() == DialogResult.OK)
            {
                string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
                string selectedExtension = Path.GetExtension(imagenProd.FileName);

                if (Array.Exists(allowedExtensions, ext => ext.Equals(selectedExtension, StringComparison.OrdinalIgnoreCase)))
                {
                    pBoxImagenProducto.BackgroundImage = null;
                    pBoxImagenProducto.Image = Image.FromFile(imagenProd.FileName);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un archivo de imagen válido (jpg, jpeg, png, gif o bmp).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 && cmbBoxCategorias.Text.Length > 0
                && txtStock.Text.Length > 0 && pBoxImagenProducto.Image != null)
            {
                if (decimal.TryParse(txtPrecio.Text, out decimal precio) && precio > 0)
                {
                    // Confirmación para poder ingresar un producto
                    DialogResult eleccion = MessageBox.Show("¿Confirmar Inserción del Producto?", "Confirmación Producto", MessageBoxButtons.YesNo);

                    if (eleccion == DialogResult.Yes)
                    {
                        Image imagen = pBoxImagenProducto.Image;
                        dataGridProductos.Rows.Add(pBoxImagenProducto.Image, txtNombre.Text, cmbBoxCategorias.Text, txtDescripcion.Text,
                            txtPrecio.Text, txtStock.Text);

                        txtNombre.Clear();
                        txtDescripcion.Clear();
                        txtPrecio.Clear();
                        txtStock.Clear();
                        pBoxImagenProducto.Image = imagenPorDefecto;

                        btnEliminarProducto.Enabled = false;
                        btnModificarProducto.Enabled = false;

                        MessageBox.Show("Se insertaron correctamente los datos del producto", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Producto no agregado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El precio debe ser un número mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ingresó todos los datos para poder añadir", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridProductos.SelectedRows.Count == 0)
            {
                // Mostrar un mensaje de error si no se ha seleccionado ninguna fila
                MessageBox.Show("Seleccione un producto para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna modificación
            }

            if (txtNombre.Text.Length > 0 && cmbBoxCategorias.Text.Length > 0 &&
                txtPrecio.Text.Length > 0 && txtStock.Text.Length > 0 && pBoxImagenProducto.Image != null)
            {
                //Confirmación para poder modificar un usuario
                DialogResult eleccion = MessageBox.Show("¿Confirmar Modificación?", "Modificación Producto", MessageBoxButtons.YesNo);
                {
                    //Elección en el caso que sí, guarda los datos
                    if (eleccion == DialogResult.Yes)
                    {
                        dataGridProductos.CurrentRow.Cells[0].Value = pBoxImagenProducto.Image;
                        System.Drawing.Image imagen = dataGridProductos.CurrentRow.Cells[0].Value as System.Drawing.Image;
                        pBoxImagenProducto.Image = imagen;

                        dataGridProductos.CurrentRow.Cells[1].Value = txtNombre.Text;
                        dataGridProductos.CurrentRow.Cells[2].Value = cmbBoxCategorias.Text;
                        dataGridProductos.CurrentRow.Cells[3].Value = txtDescripcion.Text;
                        dataGridProductos.CurrentRow.Cells[4].Value = txtPrecio.Text;
                        dataGridProductos.CurrentRow.Cells[5].Value = txtStock.Text;

                        txtNombre.Clear();
                        txtDescripcion.Clear();
                        txtDescripcion.Clear();
                        txtPrecio.Clear();
                        txtStock.Clear();

                        pBoxImagenProducto.Image = imagenPorDefecto;
                        btnEliminarProducto.Enabled = false;
                        btnModificarProducto.Enabled = false;

                        MessageBox.Show("Se modificaron correctamente los datos del producto", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datos del producto no modificados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No ingresó todos los datos para poder modificar", "ERROR");
            }
        }



        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 || cmbBoxCategorias.Text.Length == 0 ||
                txtPrecio.Text.Length == 0 || txtStock.Text.Length == 0 || pBoxImagenProducto.Image == null)
            {
                // Mostrar un mensaje de error si uno o más campos están vacíos
                MessageBox.Show("Seleccione un producto antes de intentar eliminarlo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Confirmación para poder eliminar un usuario
                DialogResult eleccion = MessageBox.Show("¿Confirmar Eliminación?", "Eliminación del producto", MessageBoxButtons.YesNo);

                if (eleccion == DialogResult.Yes)
                {
                    // Eliminar el producto si se cumplen todas las condiciones
                    dataGridProductos.Rows.Remove(dataGridProductos.CurrentRow);

                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtPrecio.Clear();
                    txtStock.Clear();
                    pBoxImagenProducto.Image = imagenPorDefecto;
                    btnEliminarProducto.Enabled = false;
                    btnModificarProducto.Enabled = false;

                    MessageBox.Show("Producto Eliminado", "Eliminación Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no eliminado", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string encontrarProducto = txtBuscar.Text;
            bool encontrado = false;

            if (!string.IsNullOrEmpty(encontrarProducto))
            {
                foreach (DataGridViewRow recorrer in dataGridProductos.Rows)
                {
                    if (recorrer.Cells[1].Value.ToString().Equals(encontrarProducto, StringComparison.OrdinalIgnoreCase)                         )
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
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Si no se encuentra ningún producto, muestra todas las filas
                    foreach (DataGridViewRow recorrer in dataGridProductos.Rows)
                    {
                        recorrer.Visible = true;
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string encontrarCliente = txtBuscar.Text;
            bool encontrado = false;

            foreach (DataGridViewRow recorrer in dataGridProductos.Rows)
            {
                if (recorrer.Cells[1].Value.ToString().IndexOf(encontrarCliente, StringComparison.OrdinalIgnoreCase) >= 0)
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
                

                // Si no se encuentra ningún producto, muestra todas las filas
                foreach (DataGridViewRow recorrer in dataGridProductos.Rows)
                {
                    recorrer.Visible = true;
                }
            }
        }

        private void listaProductos_Load(object sender, EventArgs e)
        {
            //Cargamos las imagenes que se encuentran en los recursos del proyecto
            Image imagen1 = Properties.Resources.onepiece;
            Image imagen2 = Properties.Resources.batman;
            Image imagen3 = Properties.Resources.libro100años;
            //Cargamos de manera local
            dataGridProductos.Rows.Add(imagen1, "Producto1", "Mangas", "Breve Descripción", "5000", "100", "Detalles Venta");
            dataGridProductos.Rows.Add(imagen2, "Producto2", "Comics", "Breve Descripción", "5000", "100", "Detalles Venta");
            dataGridProductos.Rows.Add(imagen3, "Producto3", "Libros", "Breve Descripción", "5000", "100", "Detalles Venta");

            Image imagenPorDefecto = Properties.Resources.producto_pbox;
            pBoxImagenProducto.Image = imagenPorDefecto;
        }

        private void dataGridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridProductos.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridProductos.Rows[e.RowIndex];

                if (selectedRow.Cells.Count >= 6)
                {
                    Image imagen = (Image)selectedRow.Cells[0].Value as System.Drawing.Image;
                    pBoxImagenProducto.Image = imagen;
                    txtNombre.Text = selectedRow.Cells[1].Value.ToString();
                    cmbBoxCategorias.Text = selectedRow.Cells[2].Value.ToString();
                    txtDescripcion.Text = selectedRow.Cells[3].Value.ToString();
                    txtPrecio.Text = selectedRow.Cells[4].Value.ToString();
                    txtStock.Text = selectedRow.Cells[5].Value.ToString();

                    // Habilita los botones "Eliminar" y "Modificar" cuando se selecciona una fila válida.
                    btnEliminarProducto.Enabled = true;
                    btnModificarProducto.Enabled = true;
                    
                }
                else
                {
                    // Mostrar un mensaje de error si no hay suficientes columnas.
                    MessageBox.Show("No se ha seleccionado un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




