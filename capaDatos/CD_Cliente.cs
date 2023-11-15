using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CD_Cliente
    {
        private ProyectoTPII_MoraesLeandroEntities dbContext;

        public CD_Cliente(ProyectoTPII_MoraesLeandroEntities context)
        {
            dbContext = context;
        }
    }
}
