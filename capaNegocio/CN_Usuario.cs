using capaDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos.Models;
using static capaDatos.CD_Usuario;
using System.Runtime.Remoting.Contexts;
using System.ComponentModel.Design;

namespace capaNegocio
{
    
    public class CN_Usuario
    {

        private CD_Usuario cdUsuario;
        private CD_TipoRol cdTipoRol; // Agregar esta línea
        private ProyectoTPII_MoraesLeandroEntities dbContext; // Agregar esta línea
        
        public CN_Usuario()
        {
            dbContext = new ProyectoTPII_MoraesLeandroEntities();
            cdUsuario = new CD_Usuario(dbContext);
            cdTipoRol = new CD_TipoRol(dbContext); // Inicializa cdTipoRol con el contexto
        }

        public CN_Usuario(CD_Usuario cdUsuario)
        {
            this.cdUsuario = cdUsuario;
        }

        public List<usuario> ObtenerUsuarios()
        {
        var usuarios = dbContext.usuario.ToList(); // Obtén todos los usuarios de la base de datos
            
        
        
        return usuarios;
        }

        public void AgregarUsuario(usuario nuevoUsuario)
        {
            // Puedes agregar lógica de validación aquí si es necesario
            cdUsuario.AgregarUsuario(nuevoUsuario);
        }

        public void ModificarUsuario(usuario usuarioModificado, string nuevaContraseña)
        {
            // Puedes agregar lógica de validación aquí si es necesario

            // Llama al método de la capa de datos para modificar el usuario
            cdUsuario.ModificarUsuario(usuarioModificado, nuevaContraseña);
        }


        public void DarDeBajaUsuario(int idUsuario)
        {
            // Puedes agregar lógica de validación aquí si es necesario
            cdUsuario.DarDeBajaUsuario(idUsuario);
        }

        public List<tipo_rol> ObtenerTiposRol()
        {
            CD_TipoRol cdTipoRol = new CD_TipoRol(dbContext); // Crea una instancia de CD_TipoRol pasando el contexto

            return cdTipoRol.ObtenerTiposRol();
        }

        public List<usuario> ObtenerUsuariosInactivos()
        {
            return cdUsuario.ObtenerUsuariosInactivos();
        }

        public List<usuario> ObtenerUsuariosPorEstado(int estado)
        {
            return cdUsuario.ObtenerUsuariosPorEstado(estado);
        }

        public void CambiarEstadoUsuario(int idUsuario, int nuevoEstado)
        {
            cdUsuario.CambiarEstadoUsuario(idUsuario, nuevoEstado);
        }

        public List<usuario> BuscarUsuariosPorDNIEnTiempoReal(string textoBusqueda, int estado)
        {
            int DNI;
            // Verificar si el texto de búsqueda es un número válido
            if (int.TryParse(textoBusqueda, out DNI))
            {
                return cdUsuario.ObtenerUsuariosPorEstado(estado)
                    .Where(u => u.DNI_usuario.ToString().StartsWith(textoBusqueda))
                    .ToList();
            }
            else
            {
                // Devolver todos los usuarios del estado especificado si el texto de búsqueda no es un número válido
                return cdUsuario.ObtenerUsuariosPorEstado(estado);
            }
        }
    }

}
