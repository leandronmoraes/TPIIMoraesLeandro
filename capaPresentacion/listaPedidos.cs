﻿using System;
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
    public partial class listaPedidos : Form
    {
        public listaPedidos()
        {
            InitializeComponent();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Length > 0 && txtCantidad.Text.Length > 0 &&
                txtProveedor.Text.Length > 0 && txtDescripcion.Text.Length > 0 &&
                txtDireccion.Text.Length > 0)
            {
                // Confirmación para poder ingresar un pedido
                DialogResult eleccion = MessageBox.Show("¿Confirmar Inserción?", "Agregar Pedido", MessageBoxButtons.YesNo);
                {
                    // Elección en el caso que sí, guarda los datos
                    if (eleccion == DialogResult.Yes)
                    {
                        // Obtén la fecha seleccionada del DateTimePicker
                        DateTime fechaSeleccionada = fecha.Value;

                        // Agrega el pedido al DataGridView
                        dgvPedidos.Rows.Add(txtNombreProducto.Text, txtCantidad.Text, txtProveedor.Text,
                            txtDescripcion.Text, txtDireccion.Text, fechaSeleccionada.ToString("yyyy-MM-dd")); // Formatea la fecha como desees

                        txtNombreProducto.Clear();
                        txtCantidad.Clear();
                        txtProveedor.Clear();
                        txtDescripcion.Clear();
                        txtDireccion.Clear();

                        MessageBox.Show("Pedido Agregado", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pedido no agregado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                txtProveedor.Text.Length > 0 && txtDescripcion.Text.Length > 0 &&
                txtDireccion.Text.Length > 0)
            {
                //Confirmación para poder eliminar un pedido
                DialogResult eleccion = MessageBox.Show("¿Confirmar Eliminación?", "Eliminar Pedido", MessageBoxButtons.YesNo);
                {
                    //Elección en el caso que si, guarda los datos
                    if (eleccion == DialogResult.Yes)
                    {
                        dgvPedidos.Rows.Remove(dgvPedidos.CurrentRow);

                        txtNombreProducto.Clear();
                        txtCantidad.Clear();
                        txtProveedor.Clear();
                        txtDescripcion.Clear();
                        txtDireccion.Clear();

                        MessageBox.Show("Pedido Eliminado", "Eliminación Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text.Length > 0 && txtCantidad.Text.Length > 0 &&
               txtProveedor.Text.Length > 0 && txtDescripcion.Text.Length > 0 &&
               txtDireccion.Text.Length > 0)
            {
                //Confirmación para poder modificar un pedido
                DialogResult eleccion = MessageBox.Show("¿Confirmar modificación?", "Modificación Pedido", MessageBoxButtons.YesNo);
                {
                    //Elección en el caso que si, guarda los datos
                    if (eleccion == DialogResult.Yes)
                    {
                        dgvPedidos.CurrentRow.Cells[0].Value = txtNombreProducto.Text;
                        dgvPedidos.CurrentRow.Cells[1].Value = txtCantidad.Text;
                        dgvPedidos.CurrentRow.Cells[2].Value = txtProveedor.Text;
                        dgvPedidos.CurrentRow.Cells[3].Value = txtDireccion.Text;
                        dgvPedidos.CurrentRow.Cells[4].Value = fecha.Text;

                        txtNombreProducto.Clear();
                        txtCantidad.Clear();
                        txtProveedor.Clear();
                        txtDireccion.Clear();
                        
                        

                        MessageBox.Show("Se modificaron correctamente los datos", "Datos Correctos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Pedido no modificado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un pedido de la lista antes de modificarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvPedidos.CurrentRow != null && dgvPedidos.CurrentRow.Cells.Count >= 5)
                {
                  
                    txtNombreProducto.Text = dgvPedidos.CurrentRow.Cells[0].Value.ToString();
                    txtCantidad.Text = dgvPedidos.CurrentRow.Cells[1].Value.ToString();
                    txtProveedor.Text = dgvPedidos.CurrentRow.Cells[2].Value.ToString();
                    txtDireccion.Text = dgvPedidos.CurrentRow.Cells[3].Value.ToString();
                    //fecha.Text = dgvPedidos.CurrentRow.Cells[4].Value.ToString();

                }
                else
                {
                    // Mostrar un mensaje de error o realizar alguna otra acción apropiada cuando no hay elementos seleccionados o no hay suficientes columnas.
                    MessageBox.Show("No se ha seleccionado un pedido válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier otra excepción que pueda ocurrir durante la recuperación de datos.
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}