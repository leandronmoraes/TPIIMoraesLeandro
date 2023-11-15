using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace capaDatos
{
    public class CD_Login
    {
        private ProyectoTPII_MoraesLeandroEntities dbContext;

        

        public usuario IniciarSesion(int usuarioDNI, string sPass)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var hashedPassword = BCrypt.Net.BCrypt.HashPassword(sPass);

                var user = (from u in db.usuario
                            where u.DNI_usuario == usuarioDNI && u.contraseña_usuario == hashedPassword
                            select u).FirstOrDefault();

                return user;
            }
        }

        public usuario ObtenerUsuario(int dni, string sPass)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                return db.usuario.FirstOrDefault(u => u.DNI_usuario == dni && u.contraseña_usuario == sPass);
            }

        }

        public int ObtenerIdVendedor(int usuarioDNI)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var user = db.usuario.FirstOrDefault(u => u.DNI_usuario == usuarioDNI && u.id_rol == 3);
                if (user != null)
                {
                    return user.id_usuario;
                }
                return 0; // Otra lógica si no se encuentra un vendedor
            }
        }

      
        public bool VerificarContraseña(int usuarioDNI, string contraseña)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var user = db.usuario.FirstOrDefault(u => u.DNI_usuario == usuarioDNI);

                if (user != null)
                {
                    // Si la contraseña almacenada tiene el formato de un hash BCrypt
                    if (user.contraseña_usuario.Length == 60 && user.contraseña_usuario[0] == '$')
                    {
                        // Verifica la contraseña utilizando BCrypt.Verify
                        return BCrypt.Net.BCrypt.Verify(contraseña, user.contraseña_usuario);
                    }
                    else
                    {
                        // Si la contraseña sin cifrar coincide con la almacenada, devuelve true
                        return contraseña == user.contraseña_usuario;
                    }
                }

                // Si el usuario no existe, la contraseña no puede ser verificada
                return false;
            }
        }

        public string ObtenerNombreUsuario(int usuarioDNI)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var usuario = db.usuario.FirstOrDefault(u => u.DNI_usuario == usuarioDNI);
                return usuario?.nombre_usuario;
            }
        }



    }
}
