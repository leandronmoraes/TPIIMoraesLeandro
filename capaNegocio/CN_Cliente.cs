using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace capaNegocio
{
    public class CN_Cliente
    {
        public static List<capaDatos.cliente> Get ()
        {
            using (capaDatos.ProyectoTPII_MoraesLeandroEntities db = new capaDatos.ProyectoTPII_MoraesLeandroEntities())
            {
                return db.cliente.ToList();
            }
        }
    }
}
