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
    public partial class listaProductosForm : Form
    {

        public string NombreProductoSeleccionado { get; private set; }
        private ProyectoTPII_MoraesLeandroEntities dbContext;
        public producto ProductoSeleccionado { get; private set; }
        public listaProductosForm()
        {
            InitializeComponent();
            //Inicializamos el contexto de la base de datos
            dbContext = new ProyectoTPII_MoraesLeandroEntities();
            
        }

        private void listaProductosForm_Load(object sender, EventArgs e)
        {
            // Cargar datos de clientes desde la base de datos
            var productos = dbContext.producto
            .Where(p => p.estado == 1 && p.stock_producto != 0)
            .ToList();

            // Configurar el DataGridView para mostrar los datos
            dataGridViewProductos.AutoGenerateColumns = true;
            dataGridViewProductos.DataSource = productos;

            // Cambiar los nombres de las columnas
            dataGridViewProductos.Columns["id_producto"].HeaderText = "ID";
            dataGridViewProductos.Columns["nombre_producto"].HeaderText = "Nombre del Producto";
            dataGridViewProductos.Columns["descripcion_producto"].HeaderText = "Descripción";
            dataGridViewProductos.Columns["id_proveedor"].HeaderText = "Proveedor";
            dataGridViewProductos.Columns["precio_producto"].HeaderText = "Precio";
            dataGridViewProductos.Columns["stock_producto"].HeaderText = "Stock";
            dataGridViewProductos.Columns["stock_producto"].HeaderText = "Stock";

            // Ocultar la columna "nombre_producto"
            dataGridViewProductos.Columns["categoria"].Visible = false;
            dataGridViewProductos.Columns["proveedor"].Visible = false;
            dataGridViewProductos.Columns["venta_detalle"].Visible = false;
            dataGridViewProductos.Columns["pedido"].Visible = false;
            dataGridViewProductos.Columns["estado"].Visible = false;
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProductos.Rows[e.RowIndex];
                NombreProductoSeleccionado = row.Cells["nombre_producto"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductosPorNombre(txtBuscar.Text);
        }

        private void FiltrarProductosPorNombre(string nombre)
        {
            var productosFiltrados = dbContext.producto
                .Where(p => p.estado == 1 && p.stock_producto != 0 && (p.nombre_producto.Contains(nombre) || p.descripcion_producto.Contains(nombre)))
                .ToList();

            dataGridViewProductos.DataSource = productosFiltrados;
        }

    }
}
