using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using capaNegocio;
using CapaEntidad;

namespace capaPresentacion
{
    public partial class nuevaVenta : Form
    {
        public nuevaVenta()
        {
            InitializeComponent();

            btnLimpiarCliente.Visible = false;
            btnLimpiarProducto.Visible = false;
            // Establece el valor predeterminado de txtCantidad en 1
            txtCantidad.Text = "1";

        }
        private decimal precioUnitarioActual;


        public class Clientess
        {

            public string DNI { get; set; }
            public string Nombre { get; set; }

            
        }

        List<Clientess> clientes = new List<Clientess>
        {
            new Clientess { DNI = "42743277", Nombre = "Leandro Moraes" },
            new Clientess { DNI = "1234", Nombre = "Usuario1" },
            new Clientess { DNI = "5678", Nombre = "Usuario2" },
        };

    
        public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
        }
        List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "producto1", Precio = 600 },
            new Producto { Nombre = "producto2", Precio = 800 },
            new Producto { Nombre = "producto3", Precio = 1200 },
            // Agregar más productos aquí
        };

        private void btnSumarCantidad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                int cantidad;
                if (int.TryParse(txtCantidad.Text, out cantidad))
                {
                    cantidad++;
                    txtCantidad.Text = cantidad.ToString();

                    // Calcula el precio total multiplicando la cantidad por el precio unitario
                    decimal precioTotal = cantidad * precioUnitarioActual;
                    txtPrecio.Text = precioTotal.ToString();
                }
                else
                {
                    MessageBox.Show("La cantidad no es un número entero válido");
                }
            }
        }

        private void btnRestarCantidad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                int cantidad;
                if (int.TryParse(txtCantidad.Text, out cantidad) && cantidad > 1)
                {
                    cantidad--;
                    txtCantidad.Text = cantidad.ToString();

                    decimal precioTotal;
                    if (decimal.TryParse(txtPrecio.Text, out precioTotal) && cantidad != 0)
                    {
                        // Calcula el precio total dividiendo el precio actual entre la cantidad
                        precioTotal = precioTotal - precioUnitarioActual;
                        txtPrecio.Text = precioTotal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El precio no es un número decimal válido o la cantidad es cero.");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad no es un número entero válido o es menor o igual a 1");
                }
            }
        }


        private void btnVenta_Click(object sender, EventArgs e)
        {
            txtDNICliente.Enabled = false;

            int cantidad;
            if (int.TryParse(txtCantidad.Text, out cantidad))
            {
                decimal precioUnidad;
                if (decimal.TryParse(txtPrecio.Text, out precioUnidad))
                {
                    decimal subtotal = cantidad * precioUnidad;

                    // Agrega la fila al DataGridView con los datos calculados
                    dataGridVenta.Rows.Add(txtDNICliente.Text, txtNombreProducto.Text, cantidad, precioUnidad, subtotal.ToString());

                    // Calcula el total
                    totalPorVender();
                    limpiarDatos();

                }
                else
                {
                    MessageBox.Show("El precio no es un número decimal válido");
                }
            }
            else
            {
                MessageBox.Show("La cantidad no es un número entero válido");
            }
        }

        private void limpiarDatos()
        {
            txtCantidad.Text = "1";
            txtPrecio.Text = "";
            txtNombreProducto.Text = "";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;

            Producto productoEncontrado = productos.FirstOrDefault(p => p.Nombre == nombreProducto);

            if (productoEncontrado != null)
            {
                // Establece el precio en el campo txtPrecio
                txtPrecio.Text = productoEncontrado.Precio.ToString();
                precioUnitarioActual = productoEncontrado.Precio; // Almacena el precio unitario actual
                btnLimpiarProducto.Visible = true;
            }
            else
            {
                MessageBox.Show("Producto no se encuentra disponible");
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtDNICliente.Clear();
            btnLimpiarCliente.Visible = false;
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Clear();
            btnLimpiarProducto.Visible = false;
        }

        public void totalPorVender()
        {
            decimal total = 0.0m;
            foreach (DataGridViewRow row in dataGridVenta.Rows)
            {
                total += Convert.ToDecimal(row.Cells[3].Value);
            }
            txtTotal.Text = total.ToString();
        }




        private void btnLimpiarCarrito_Click(object sender, EventArgs e)
        {
            txtDNICliente.Enabled = true;
            dataGridVenta.Rows.Clear(); // Elimina todas las filas del DataGridView
            txtTotal.Text = ""; // Limpia el campo de total (si es necesario)

            txtCantidad.Text = "";
        }

        private void txtDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nuevaVenta_Load(object sender, EventArgs e)
        {
            cmbPago.SelectedIndex = 0;


        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta Registrada con Exito");
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            string dniCliente = txtDNICliente.Text;

            // Buscar el cliente en la lista de clientes por DNI
            Clientess clienteEncontrado = clientes.FirstOrDefault(c => c.DNI == dniCliente);

            if (clienteEncontrado != null)
            {
                // Establece el nombre del cliente en el campo txtDNICliente
                txtDNICliente.Text = clienteEncontrado.Nombre;
                btnLimpiarCliente.Visible = true;
            }
            else
            {
                MessageBox.Show("Cliente no se encuentra registrado");
            }
        }
    }
}
