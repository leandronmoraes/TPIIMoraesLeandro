using capaDatos.Models;
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
using capaDatos; 
using iTextSharp.text;
using FontAwesome.Sharp;


namespace capaPresentacion
{

    public partial class formVenta : Form
    {
        private int idVendedorConectado;
        int idUsuario = ContextoCompartido.UsuarioId;

        public formVenta(int idVendedorConectado)
        {
            InitializeComponent();
            // Asegúrate de que estás obteniendo el ID del vendedor utilizando la capa de negocio
            CN_Login cnLogin = new CN_Login();
            this.idVendedorConectado = idVendedorConectado;
            
        }


        private void dataGridVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridVenta.Columns[e.ColumnIndex].Name == "detalles")
            {
                // Obtener la información necesaria de la fila seleccionada
                int idVenta = Convert.ToInt32(dataGridVenta.CurrentRow.Cells["id_venta"].Value);


                // Crear una instancia del formulario listaDetalleVenta y pasar el ID de la venta
                listaDetalleVenta detallesAbiertos = new listaDetalleVenta(idVenta);

                // Mostrar el formulario de detalles de venta
                detallesAbiertos.ShowDialog();
            }
        }

        private void formVenta_Load(object sender, EventArgs e)
        {

            // Agregar un controlador de eventos para el botón de búsqueda
            btnBuscar.Click += btnBuscar_Click;
            DateTime fechaActual = DateTime.Now.Date;

            // Obtén las fechas seleccionadas
            DateTime fechaDesde = fechaDesdePicker.Value.Date;
            DateTime fechaHasta = fechaHastaPicker.Value.Date;

            // Validación: fechaDesde no puede ser mayor que la fecha actual
            if (fechaDesde > fechaActual)
            {
                MessageBox.Show("La fecha desde no puede ser mayor que la fecha actual.");
                // Puedes hacer más aquí, como establecer la fechaDesde en la fecha actual, etc.
            }

            // Validación: fechaHasta no puede ser menor que la fecha actual
            if (fechaHasta < fechaActual)
            {
                MessageBox.Show("La fecha hasta no puede ser menor que la fecha actual.");
                // Puedes hacer más aquí, como establecer la fechaHasta en la fecha actual, etc.
            }
            
                // Asegúrate de proporcionar un valor predeterminado para terminoBusqueda o modificar según sea necesario
                CargarVentasDelVendedor(ContextoCompartido.UsuarioId, fechaDesdePicker.Value, fechaHastaPicker.Value, "");
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string terminoBusqueda = txtBuscar.Text.Trim();
            CargarVentasDelVendedor(ContextoCompartido.UsuarioId, fechaDesdePicker.Value, fechaHastaPicker.Value, terminoBusqueda);
        }
        private void CargarVentasDelVendedor(int idVendedor, DateTime fechaDesde, DateTime fechaHasta, string terminoBusqueda)
        {
            

            // Conecta con la base de datos utilizando Entity Framework u otro método de tu elección.
            using (var dbContext = new ProyectoTPII_MoraesLeandroEntities())
            {
                dataGridVenta.Columns["id_venta"].DataPropertyName = "id_venta";
                dataGridVenta.Columns["nombre_cliente"].DataPropertyName = "nombre_cliente";
                dataGridVenta.Columns["fecha_venta"].DataPropertyName = "fecha_venta";

                dataGridVenta.Columns["total_venta"].DataPropertyName = "total_venta";
                //dataGridVenta.Columns["nombre_usuario"].DataPropertyName = "nombre_usuario";
                dataGridVenta.Columns["descripcion_tipo_pago"].DataPropertyName = "descripcion_tipo_pago";
                //dataGridVenta.Columns["estado"].DataPropertyName = "estado";
                dataGridVenta.Columns["detalles"].DataPropertyName = "detalles";

                // Obtiene los datos de la base de datos y los enlaza al DataGridView, filtrando por el ID del vendedor
                var ventas = dbContext.venta
            .Where(v => v.id_vendedor == idVendedor &&
                        v.fecha_venta >= fechaDesde &&
                        v.fecha_venta <= fechaHasta &&
                        (v.cliente.nombre_cliente.Contains(terminoBusqueda) || v.cliente.DNI_cliente.Contains(terminoBusqueda))) // Modifica según tus necesidades
            .Select(v => new
            {
                v.id_venta,
                v.cliente.nombre_cliente,
                v.fecha_venta,
                v.total_venta,
                v.cliente.DNI_cliente,
                v.tipo_pago.descripcion_tipo_pago,
                v.estado,
            })
            .ToList();

                dataGridVenta.DataSource = ventas;
            }
        }

        private void fechaDesdePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;
            DateTime fechaDesde = fechaDesdePicker.Value.Date;
            DateTime fechaHasta = fechaHastaPicker.Value.Date;

            // Validación: fechaDesde no puede ser mayor que la fecha actual
            if (fechaDesde > fechaActual)
            {
                MessageBox.Show("La fecha desde no puede ser mayor que la fecha actual.");
                // Puedes hacer más aquí, como establecer la fechaDesde en la fecha actual, etc.
            }

            // Validación: fechaHasta no puede ser menor que la fecha actual
            if (fechaHasta < fechaActual)
            {
                MessageBox.Show("La fecha hasta no puede ser menor que la fecha actual.");
                // Puedes hacer más aquí, como establecer la fechaHasta en la fecha actual, etc.
            }

            // Cargar las ventas solo si las fechas son válidas
            if (fechaDesde <= fechaActual && fechaHasta >= fechaActual)
            {
                // Asegúrate de proporcionar un valor predeterminado para terminoBusqueda o modificar según sea necesario
                CargarVentasDelVendedor(ContextoCompartido.UsuarioId, fechaDesdePicker.Value, fechaHastaPicker.Value, "");
            }

        }

        private void fechaHastaPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;
            DateTime fechaDesde = fechaDesdePicker.Value.Date;
            DateTime fechaHasta = fechaHastaPicker.Value.Date;

            // Validación: fechaDesde no puede ser mayor que la fecha actual
            if (fechaDesde > fechaActual)
            {
                MessageBox.Show("La fecha desde no puede ser mayor que la fecha actual.");
                // Puedes hacer más aquí, como establecer la fechaDesde en la fecha actual, etc.
            }

            // Validación: fechaHasta no puede ser menor que la fecha actual
            if (fechaHasta < fechaActual)
            {
                MessageBox.Show("La fecha hasta no puede ser menor que la fecha actual.");
                // Puedes hacer más aquí, como establecer la fechaHasta en la fecha actual, etc.
            }

            // Cargar las ventas solo si las fechas son válidas
            if (fechaDesde <= fechaActual && fechaHasta >= fechaActual)
            {
                // Asegúrate de proporcionar un valor predeterminado para terminoBusqueda o modificar según sea necesario
                CargarVentasDelVendedor(ContextoCompartido.UsuarioId, fechaDesdePicker.Value, fechaHastaPicker.Value, "");
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter presionado es un número o la tecla de retroceso
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 es el código ASCII para la tecla de retroceso (Backspace)
            {
                // Si no es un número, cancelar el evento para evitar que se agregue al TextBox
                e.Handled = true;
            }
        }
    }

}



