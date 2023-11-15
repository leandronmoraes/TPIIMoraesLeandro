using capaDatos.Models;
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
    public partial class totalVentas : Form
    {
        public totalVentas()
        {
            InitializeComponent();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVentas.Columns[e.ColumnIndex].Name == "detalles")
            {
                // Obtén la información de la venta desde las celdas del DataGridView
                int idVenta = Convert.ToInt32(dgvVentas.CurrentRow.Cells["id_venta"].Value); // Asegúrate de que el nombre de la columna sea "id_venta" en lugar de "idVenta"

                // Crea una nueva instancia del formulario listaDetalleVenta y pasa la información de la venta
                listaDetalleVenta detallesVentaForm = new listaDetalleVenta(idVenta);
                detallesVentaForm.ShowDialog();
            }
        }

        private void totalVentas_Load(object sender, EventArgs e)
        {
            
            TfechaDesde.ValueChanged += DtpFecha_ValueChanged;
            TFechaHasta.ValueChanged += DtpFecha_ValueChanged;

            // Cargar los datos inicialmente
            CargarDatos();
            using (var dbContext = new ProyectoTPII_MoraesLeandroEntities())
            {
                var ventas = dbContext.venta.Include("cliente").Include("usuario").ToList();

                dgvVentas.Rows.Clear();

                foreach (var venta in ventas)
                {
                    // Obtener los datos del vendedor y del cliente
                    string nombreVendedor = venta.usuario.nombre_usuario;
                    int dniVendedor = venta.usuario.DNI_usuario ?? 0; // Valor predeterminado 0 si es nulo

                    string nombreCliente = venta.cliente.nombre_cliente;
                    int dniCliente = Convert.ToInt32(venta.cliente.DNI_cliente); // Convertir a int

                    dgvVentas.Rows.Add(
                        venta.id_venta,
                        nombreVendedor,
                        dniVendedor,
                        nombreCliente,
                        dniCliente,
                        venta.fecha_venta,
                        venta.total_venta
                    );
                }
            }
        }

        private void CargarDatos()
        {
            DateTime fechaDesde = TfechaDesde.Value.Date;
            DateTime fechaHasta = TFechaHasta.Value.Date;

            // Validación: fechaDesde no puede ser mayor que la fecha actual
            if (fechaDesde > DateTime.Now)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha actual", "Error en fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Restablecer fechaDesde a la fecha actual
                TfechaDesde.ValueChanged -= DtpFecha_ValueChanged;
                TfechaDesde.Value = DateTime.Now;
                TfechaDesde.ValueChanged += DtpFecha_ValueChanged;

                return;
            }

            // Validación: fechaHasta no puede ser menor que fechaDesde
            if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("La fecha final no puede ser menor que la fecha inicial", "Error en fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Restablecer fechaHasta a la fecha actual
                TFechaHasta.ValueChanged -= DtpFecha_ValueChanged;
                TFechaHasta.Value = DateTime.Now;
                TFechaHasta.ValueChanged += DtpFecha_ValueChanged;

                return;
            }

            using (var dbContext = new ProyectoTPII_MoraesLeandroEntities())
            {
                try
                {
                    var ventas = dbContext.venta.Include("cliente").Include("usuario")
                                    .Where(v => v.fecha_venta >= fechaDesde && v.fecha_venta <= fechaHasta)
                                    .ToList();

                    dgvVentas.Rows.Clear();

                    foreach (var venta in ventas)
                    {
                        // Obtener los datos del vendedor y del cliente
                        string nombreVendedor = venta.usuario.nombre_usuario;
                        int dniVendedor = venta.usuario.DNI_usuario ?? 0;

                        string nombreCliente = venta.cliente.nombre_cliente;
                        int dniCliente = Convert.ToInt32(venta.cliente.DNI_cliente);

                        dgvVentas.Rows.Add(
                            venta.id_venta,
                            nombreVendedor,
                            dniVendedor,
                            nombreCliente,
                            dniCliente,
                            venta.fecha_venta,
                            venta.total_venta
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            // Al cambiar la fecha en cualquiera de los DateTimePicker, cargar los datos
            CargarDatos();
        }

        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtroDNI = txtBuscar.Text.Trim();

            using (var dbContext = new ProyectoTPII_MoraesLeandroEntities())
            {
                try
                {
                    var ventas = dbContext.venta.Include("cliente").Include("usuario")
                        .Where(v =>
                            v.usuario.DNI_usuario.ToString().Contains(filtroDNI) ||
                            v.cliente.DNI_cliente.Contains(filtroDNI))
                        .ToList();

                    dgvVentas.Rows.Clear();

                    foreach (var venta in ventas)
                    {
                        // Obtener los datos del vendedor y del cliente
                        string nombreVendedor = venta.usuario.nombre_usuario;
                        int dniVendedor = venta.usuario.DNI_usuario ?? 0;

                        string nombreCliente = venta.cliente.nombre_cliente;
                        int dniCliente = Convert.ToInt32(venta.cliente.DNI_cliente);

                        dgvVentas.Rows.Add(
                            venta.id_venta,
                            nombreVendedor,
                            dniVendedor,
                            nombreCliente,
                            dniCliente,
                            venta.fecha_venta,
                            venta.total_venta
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }






    }
}
