using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos.Models;

namespace capaNegocio
{
    public class CN_Cliente
    {
        public static List<capaDatos.Models.cliente> Get ()
        {
            using (capaDatos.Models.ProyectoTPII_MoraesLeandroEntities db = new capaDatos.Models.ProyectoTPII_MoraesLeandroEntities())
            {
                return db.cliente.ToList();
            }
        }
    }
}
