using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CD_Venta
    {
        private ProyectoTPII_MoraesLeandroEntities dbContext;

        public CD_Venta(ProyectoTPII_MoraesLeandroEntities context)
        {
            dbContext = context;
        }

        public List<venta> ObtenerVentasPorVendedor(int idVendedor)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var ventas = db.venta
                    .Where(v => v.id_vendedor == idVendedor)
                    .ToList();

                return ventas;
            }
        }
    }
}
