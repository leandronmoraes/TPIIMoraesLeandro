using capaDatos;
using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaNegocio
{

    public class CN_Venta
    {
        private CD_Venta cdVenta;
        private ProyectoTPII_MoraesLeandroEntities dbContext;

        public CN_Venta()
        {
            dbContext = new ProyectoTPII_MoraesLeandroEntities();
            cdVenta = new CD_Venta(dbContext);
        }

        public void CargarVentasPorVendedor(DataGridView dataGrid, int idVendedor)
        {
            // Obtener las ventas solo para el vendedor específico
            var ventas = cdVenta.ObtenerVentasPorVendedor(idVendedor);

            // Asignar datos al DataGridView
            dataGrid.DataSource = ventas;
        }
    }
}
