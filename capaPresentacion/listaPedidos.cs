using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace capaPresentacion
{
    public partial class listaPedidos : Form
    {
        private ProyectoTPII_MoraesLeandroEntities dbContext; // Declarar dbContext como un campo de clase
       
        public listaPedidos()
        {
            InitializeComponent();

            // Deshabilitamos los botones Eliminar y Modificar al cargar el formulario.
            btnEliminar.Enabled = false;
            btnConfirmarPedido.Enabled = false;

            cmbProveedor.SelectedIndex = 0;
            // se deshabilito la modificación de fecha, para que solo se registre la fecha actual.
            fecha.Enabled = false;

            dbContext = new ProyectoTPII_MoraesLeandroEntities();

            // Carga la lista de proveedores en el ComboBox al cargar el formulario
            CargarProveedores();
        }



        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un número ni la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // No permite que el carácter sea ingresado en el TextBox
            }

            // Verifica si el dígito "0" o un espacio es el primer carácter
            if ((e.KeyChar == '0' || e.KeyChar == ' ') && txtCantidad.Text.Length == 0)
            {
                e.Handled = true; // No permite que el carácter sea ingresado en el TextBox
            }
        }






        private void CargarProveedores()
        {
            // Utiliza Entity Framework para obtener la lista de proveedores de la base de datos
            var proveedores = dbContext.proveedor.ToList();

            // Asigna la lista de proveedores al ComboBox
            cmbProveedor.DisplayMember = "nombre_proveedor"; // Muestra el nombre del proveedor en el ComboBox
            cmbProveedor.ValueMember = "id_proveedor"; // Utiliza el ID del proveedor como valor interno
            cmbProveedor.DataSource = proveedores;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Length > 0 && txtCantidad.Text.Length > 0 &&
                 txtDescripcion.Text.Length > 0 && txtDireccion.Text.Length > 0)
            {
                // Confirmación para poder ingresar un pedido
                DialogResult eleccion = MessageBox.Show("¿Confirmar Inserción?", "Agregar Pedido", MessageBoxButtons.YesNo);
                if (eleccion == DialogResult.Yes)
                {
                    using (var db = new ProyectoTPII_MoraesLeandroEntities())
                    {
                        pedido nuevoPedido = new pedido
                        {
                            // Obtén la fecha seleccionada del DateTimePicker
                            fecha_pedido = fecha.Value,
                            nombre_producto_pedido = txtNombreProducto.Text,
                            cantidad_pedido = int.Parse(txtCantidad.Text),
                            descripcion_pedido = txtDescripcion.Text,
                            direccion_pedido = txtDireccion.Text,
                            id_proveedor = int.Parse(cmbProveedor.SelectedValue.ToString()),
                            estado = 1,
                        };
                        db.pedido.Add(nuevoPedido);
                        db.SaveChanges();
                    }

                    txtNombreProducto.Clear();
                    txtCantidad.Clear();
                    txtDescripcion.Clear();
                    txtDireccion.Clear();

                    MessageBox.Show("Pedido Agregado", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pedido no agregado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ingresaste todos los datos necesarios para poder añadir un pedido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Length > 0 && txtCantidad.Text.Length > 0 &&
                txtDescripcion.Text.Length > 0 &&
                txtDireccion.Text.Length > 0)
            {
                //Confirmación para poder eliminar un pedido
                DialogResult eleccion = MessageBox.Show("¿Confirmar Eliminación?", "Eliminar Pedido", MessageBoxButtons.YesNo);
                {
                    //Elección en el caso que si, guarda los datos
                    if (eleccion == DialogResult.Yes)
                    {
                        int pedidoId = (int)dgvPedidos.CurrentRow.Cells["id_pedido"].Value;

                        using (var db = new ProyectoTPII_MoraesLeandroEntities())
                        {
                            var pedidoAEliminar = db.pedido.FirstOrDefault(p => p.id_pedido == pedidoId);
                            if (pedidoAEliminar != null)
                            {
                                db.pedido.Remove(pedidoAEliminar);
                                db.SaveChanges();
                            }
                        }

                        txtNombreProducto.Clear();
                        txtCantidad.Clear();      
                        txtDescripcion.Clear();
                        txtDireccion.Clear();

                        MessageBox.Show("Pedido Eliminado", "Eliminación Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Deshabilitar los botones "Eliminar" y "Modificar" después de eliminar un pedido
                        btnEliminar.Enabled = false;
                        btnConfirmarPedido.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Pedido no eliminado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pedido de la lista antes de eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPedidos.CurrentRow != null)
                {
                    txtNombreProducto.Text = dgvPedidos.CurrentRow.Cells["nombre_producto_pedido"].Value.ToString();
                    txtCantidad.Text = dgvPedidos.CurrentRow.Cells["cantidad_pedido"].Value.ToString();
                    cmbProveedor.Text = dgvPedidos.CurrentRow.Cells["id_proveedor"].Value.ToString();
                    txtDescripcion.Text = dgvPedidos.CurrentRow.Cells["descripcion_pedido"].Value.ToString();
                    txtDireccion.Text = dgvPedidos.CurrentRow.Cells["direccion_pedido"].Value.ToString();

                    if (DateTime.TryParse(dgvPedidos.CurrentRow.Cells["fecha_pedido"].Value.ToString(), out DateTime fechaPedido))
                    {
                        fecha.Value = fechaPedido;
                    }

                    btnEliminar.Enabled = true;
                    btnConfirmarPedido.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un pedido válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int estadoFiltrado = 1; // Variable para almacenar el estado actual de filtrado (1 por defecto)
        private void listaPedidos_Load(object sender, EventArgs e)
        {
            CargarPedidosConEstado(estadoFiltrado);
            cambiarColumna();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de lista de productos
            listaProductosForm listaProductosForm = new listaProductosForm();

            // Mostrar el formulario de lista de productos como un diálogo
            DialogResult result = listaProductosForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Crear una instancia del contexto de Entity Framework
                ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities();



                string nombreProductoSeleccionado = listaProductosForm.NombreProductoSeleccionado;
                txtNombreProducto.Text = nombreProductoSeleccionado;



                btnLimpiarProducto.Visible = true;
            }    
        }


        private void CargarPedidosConEstado(int estado)
        {
            using (var db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var pedidos = from p in db.pedido
                              where p.estado == estado
                              select new
                              {
                                  p.id_pedido,
                                  p.nombre_producto_pedido,
                                  p.descripcion_pedido,
                                  p.direccion_pedido,
                                  p.cantidad_pedido,
                                  p.fecha_pedido,
                                  p.id_proveedor,
                                  p.estado,
                              };
                dgvPedidos.DataSource = pedidos.ToList();
            }
        }
        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Clear();
            btnLimpiarProducto.Visible = false;
        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Length > 0 && txtCantidad.Text.Length > 0 &&
                txtDescripcion.Text.Length > 0 && txtDireccion.Text.Length > 0)
            {
                // Confirmación para confirmar el pedido
                DialogResult eleccion = MessageBox.Show("¿Confirmar Pedido?", "Confirmar Pedido", MessageBoxButtons.YesNo);
                if (eleccion == DialogResult.Yes)
                {
                    using (var db = new ProyectoTPII_MoraesLeandroEntities())
                    {
                        // Obtener el producto seleccionado
                        string nombreProductoSeleccionado = txtNombreProducto.Text;
                        producto productoSeleccionado = db.producto.FirstOrDefault(p => p.nombre_producto == nombreProductoSeleccionado);

                        if (productoSeleccionado != null)
                        {
                            // Actualizar el stock del producto sumando la cantidad del pedido
                            productoSeleccionado.stock_producto += int.Parse(txtCantidad.Text);

                            // Crear un nuevo pedido con estado confirmado (2)
                            pedido nuevoPedido = new pedido
                            {
                                fecha_pedido = fecha.Value,
                                nombre_producto_pedido = txtNombreProducto.Text,
                                cantidad_pedido = int.Parse(txtCantidad.Text),
                                descripcion_pedido = txtDescripcion.Text,
                                direccion_pedido = txtDireccion.Text,
                                id_proveedor = int.Parse(cmbProveedor.SelectedValue.ToString()),

                                estado = 2, // Cambiado a estado confirmado
                            };

                            // Asignar el producto seleccionado al nuevo pedido
                            nuevoPedido.producto = productoSeleccionado;

                            // Agregar el nuevo pedido a la base de datos
                            db.pedido.Add(nuevoPedido);

                            // Cambiar el estado del pedido original a confirmado (2)
                            int pedidoId = (int)dgvPedidos.CurrentRow.Cells["id_pedido"].Value;
                            var pedidoOriginal = db.pedido.FirstOrDefault(p => p.id_pedido == pedidoId);
                            if (pedidoOriginal != null)
                            {
                                pedidoOriginal.estado = 2; // Cambiar a estado confirmado
                                db.Entry(pedidoOriginal).State = EntityState.Modified;
                            }

                            // Guardar los cambios en el stock del producto y en el nuevo pedido
                            db.Entry(productoSeleccionado).State = EntityState.Modified;
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Limpiar los campos después de confirmar el pedido
                    txtNombreProducto.Clear();
                    txtCantidad.Clear();
                    txtDescripcion.Clear();
                    txtDireccion.Clear();

                    // Volver a cargar los pedidos pendientes (estado 1)
                    CargarPedidosConEstado(1);

                    MessageBox.Show("Pedido Confirmado", "Confirmación de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pedido no confirmado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No ingresaste todos los datos necesarios para poder confirmar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cambiarColumna()
        {
            //Cambiar Header
            dgvPedidos.Columns["id_pedido"].HeaderText = "ID";
            dgvPedidos.Columns["cantidad_pedido"].HeaderText = "Cantidad";
            dgvPedidos.Columns["descripcion_pedido"].HeaderText = "Descripción";
            dgvPedidos.Columns["direccion_pedido"].HeaderText = "Dirección";
            dgvPedidos.Columns["fecha_pedido"].HeaderText = "Fecha";
            dgvPedidos.Columns["id_proveedor"].HeaderText = "Proveedor";
            dgvPedidos.Columns["nombre_producto_pedido"].HeaderText = "Producto";
            //dgvPedidos.Columns["id_producto"].HeaderText = "ID del producto";

            //Ocultar Tablas

            dgvPedidos.Columns["estado"].Visible = false;
        }

        private void btnVerConfirmados_Click(object sender, EventArgs e)
        {
            estadoFiltrado = 2; // Cambiar al estado 2 (confirmado)
            CargarPedidosConEstado(estadoFiltrado);
        }

        private void btnVerPendientes_Click(object sender, EventArgs e)
        {
            estadoFiltrado = 1; // Cambiar al estado 1 (pendiente)
            CargarPedidosConEstado(estadoFiltrado);
        }
    }
}
