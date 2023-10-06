using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    // En la capa de Datos
    public class UsuarioContext : DbContext
    {
        public UsuarioContext() : base("ProyectoTPII_MoraesLeandro")
        {
        }

        public DbSet<usuario> Usuarios { get; set; }
    }

}
