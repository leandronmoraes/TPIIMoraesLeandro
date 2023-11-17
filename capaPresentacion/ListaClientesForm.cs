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
    

    public partial class ListaClientesForm : Form
    {
        public string DNIClienteSeleccionado { get; private set; }
        private ProyectoTPII_MoraesLeandroEntities dbContext; // Reemplaza DbContext con el contexto de tu base de datos

        public ListaClientesForm()
        {
            InitializeComponent();

            // Inicializa el contexto de la base de datos
            dbContext = new ProyectoTPII_MoraesLeandroEntities(); 
        }

        private void ListaClientesForm_Load(object sender, EventArgs e)
        {
            // Cargar datos de clientes desde la base de datos
            var clientes = dbContext.cliente
                .Where(c => c.estado == 1)
                .ToList();

            // Configurar el DataGridView para mostrar los datos
            dataGridViewClientes.AutoGenerateColumns = true;
            dataGridViewClientes.DataSource = clientes;

            // Cambiar los nombres de las columnas
            dataGridViewClientes.Columns["id_cliente"].HeaderText = "ID";
            dataGridViewClientes.Columns["DNI_cliente"].HeaderText = "DNI";
            dataGridViewClientes.Columns["nombre_cliente"].HeaderText = "Nombre";
            dataGridViewClientes.Columns["apellido_cliente"].HeaderText = "Apellido";
            dataGridViewClientes.Columns["direccion"].HeaderText = "Dirección";
            dataGridViewClientes.Columns["telefono"].HeaderText = "Teléfono";

            // Ocultar la columna "nombre_producto"
          
            dataGridViewClientes.Columns["venta"].Visible = false;
            dataGridViewClientes.Columns["estado"].Visible = false;
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClientes.Rows[e.RowIndex];
                DNIClienteSeleccionado = row.Cells["DNI_cliente"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientesPorNombre(txtBuscar.Text);
        }

        private void FiltrarClientesPorNombre(string filtro)
        {
            var clientesFiltrados = dbContext.cliente
                .Where(c => c.estado == 1 &&
                    (c.nombre_cliente.Contains(filtro) ||
                     c.apellido_cliente.Contains(filtro) ||
                     c.DNI_cliente.Contains(filtro)))
                .ToList();

            dataGridViewClientes.DataSource = clientesFiltrados;
        }


    }
}
 

