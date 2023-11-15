using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CD_TipoRol
    {
        private ProyectoTPII_MoraesLeandroEntities dbContext;

        public CD_TipoRol(ProyectoTPII_MoraesLeandroEntities context)
        {
            dbContext = context;
        }

        public List<tipo_rol> ObtenerTiposRol()
        {
            return dbContext.tipo_rol.ToList();
        }
 
    }
}
