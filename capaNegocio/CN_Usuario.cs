using capaDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    internal class CN_Usuario
    {
        // En la capa de Negocio
        public class UsuarioService
        {
            private UsuarioContext dbContext;

            public UsuarioService()
            {
                dbContext = new UsuarioContext();
            }

            public void CrearUsuario(usuario usuario)
            {
                dbContext.Usuarios.Add(usuario);
                dbContext.SaveChanges();
            }

            public List<usuario> ObtenerUsuarios()
            {
                return dbContext.Usuarios.ToList();
            }

            public void ActualizarUsuario(usuario usuario)
            {
                dbContext.Entry(usuario).State = EntityState.Modified;
                dbContext.SaveChanges();
            }

            public void EliminarUsuario(int id)
            {
                var usuario = dbContext.Usuarios.Find(id);
                if (usuario != null)
                {
                    dbContext.Usuarios.Remove(usuario);
                    dbContext.SaveChanges();
                }
            }
        }

    }
}
