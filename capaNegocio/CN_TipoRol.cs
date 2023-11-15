using capaDatos.Models;
using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class CN_TipoRol
    {
        private CD_TipoRol cdTipoRol;
        public List<tipo_rol> ObtenerTiposRol()
        {
            return cdTipoRol.ObtenerTiposRol();
        }
        public CN_TipoRol()
        {
            var dbContext = new ProyectoTPII_MoraesLeandroEntities();
            cdTipoRol = new CD_TipoRol(dbContext); // Inicializa cdTipoRol con el contexto
        }

    }

}
