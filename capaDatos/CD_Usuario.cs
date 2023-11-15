using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace capaDatos
{
    public class CD_Usuario
    {
        private ProyectoTPII_MoraesLeandroEntities dbContext;

        public CD_Usuario(ProyectoTPII_MoraesLeandroEntities context)
        {
            dbContext = context;
        }

        public List<usuario> ObtenerUsuarios()
        {
            return dbContext.usuario.ToList();
        }

        public void AgregarUsuario(usuario nuevoUsuario)
        {
            // Hashear la contraseña antes de almacenarla
            nuevoUsuario.contraseña_usuario = BCrypt.Net.BCrypt.HashPassword(nuevoUsuario.contraseña_usuario);
            dbContext.usuario.Add(nuevoUsuario);
            dbContext.SaveChanges();
        }

        //public void ModificarUsuario(usuario usuarioModificado)
        //{
        //    // Hashear la contraseña antes de actualizarla
        //    usuarioModificado.contraseña_usuario = BCrypt.Net.BCrypt.HashPassword(usuarioModificado.contraseña_usuario);
        //    dbContext.Entry(usuarioModificado).State = EntityState.Modified;
        //    dbContext.SaveChanges();
        //}

        public void ModificarUsuario(usuario usuarioModificado, string nuevaContraseña)
        {
            var usuarioExistente = dbContext.usuario.Find(usuarioModificado.id_usuario);

            if (usuarioExistente != null)
            {
                // Copia los valores modificados al usuario existente
                dbContext.Entry(usuarioExistente).CurrentValues.SetValues(usuarioModificado);

                // Verifica si se proporcionó una nueva contraseña
                if (!string.IsNullOrEmpty(nuevaContraseña))
                {
                    // Hashea la nueva contraseña si se proporciona
                    usuarioExistente.contraseña_usuario = BCrypt.Net.BCrypt.HashPassword(nuevaContraseña);
                }

                // Guarda los cambios en la base de datos
                dbContext.SaveChanges();
            }
        }




        public string ObtenerContraseñaUsuario(int idUsuario)
        {
            var usuario = dbContext.usuario.Find(idUsuario);
            return usuario?.contraseña_usuario;
        }

        public void DarDeBajaUsuario(int idUsuario)
        {
            var usuarioADarDeBaja = dbContext.usuario.FirstOrDefault(p => p.id_usuario == idUsuario);
            if (usuarioADarDeBaja != null)
            {
                usuarioADarDeBaja.estado = 0; // Cambia el estado del producto a inactivo
                dbContext.SaveChanges();
            }
        }

        public bool VerificarContraseña(int usuarioDNI, string contraseña)
        {
            var usuario = dbContext.usuario.FirstOrDefault(u => u.DNI_usuario == usuarioDNI);

            if (usuario != null)
            {
                // Obtén el hash almacenado de la base de datos
                string hashAlmacenado = usuario.contraseña_usuario;

                // Compara el hash almacenado con el hash de la contraseña proporcionada
                return BCrypt.Net.BCrypt.Verify(contraseña, hashAlmacenado);
            }

            return false; // Usuario no encontrado
        }

        public List<usuario> ObtenerUsuariosInactivos()
        {
            return dbContext.usuario.Where(u => u.estado == 0).ToList();
        }

        public List<usuario> ObtenerUsuariosPorEstado(int estado)
        {
            return dbContext.usuario

                .Where(u => u.estado == estado).ToList();
        }

        public void CambiarEstadoUsuario(int idUsuario, int nuevoEstado)
        {
            var usuario = dbContext.usuario.FirstOrDefault(u => u.id_usuario == idUsuario);

            if (usuario != null)
            {
                usuario.estado = nuevoEstado;
                dbContext.Entry(usuario).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

    }
}

