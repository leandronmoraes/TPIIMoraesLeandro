using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using System.Globalization;
using Microsoft.Win32;
using System.Data.Entity;
using System.Windows.Forms;
using BCrypt.Net;

namespace capaNegocio
{
    public class CN_Login
    {
        private CD_Login cdLogin;
        private ProyectoTPII_MoraesLeandroEntities dbContext;

        public CN_Login()
        {
            cdLogin = new CD_Login();
        }

       
        public int IniciarSesion(int usuarioDNI, string sPass)
        {
            CD_Login cdLogin = new CD_Login();
            var user = cdLogin.IniciarSesion(usuarioDNI, sPass);

            if (user != null)
            {
                // Almacena el ID del usuario en el contexto compartido
                ContextoCompartido.UsuarioId = user.id_usuario;

                // Además, puedes guardar un registro de inicio de sesión si es necesario
                GuardarRegistroInicioSesion(user.id_usuario);

                return user.id_usuario; // Devuelve el ID del usuario
            }

            return 0; // Indica que el inicio de sesión falló
        }

        public bool VerificarContraseña(int usuarioDNI, string contraseña)
        {
            return cdLogin.VerificarContraseña(usuarioDNI, contraseña);
        }

        public static class ContextoCompartido
        {
            public static int UsuarioId { get; set; }
        }

        // guardar el registro de inicio de sesión
        private void GuardarRegistroInicioSesion(int id_usuario)
        {
            // Lógica para guardar el registro en la base de datos

            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                // Formatea la fecha y hora actual en el formato deseado
                string fechaIngresoFormateada = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Convierte la cadena formateada en un objeto DateTime
                DateTime fechaIngreso = DateTime.ParseExact(fechaIngresoFormateada, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                RegistroUsuario nuevoRegistro = new RegistroUsuario
                {
                    id_usuario = id_usuario,
                    fecha_ingreso = fechaIngreso
                };

                db.RegistroUsuario.Add(nuevoRegistro);
                db.SaveChanges(); // Guardamos los cambios en la base de datos.
            }
        }

        public int ObtenerIdVendedor(int usuarioDNI)
        {
            
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var user = db.usuario.FirstOrDefault(u => u.DNI_usuario == usuarioDNI && u.id_rol == 3);
                if (user != null)
                {
                    MessageBox.Show("ID del Vendedor obtenido: " + user.id_usuario);
                    return user.id_usuario;
                }
                return 0; // Otra lógica si no se encuentra un vendedor
            }
        }


        // Aquí puedes obtener el id_rol del usuario desde la base de datos si es necesario
        public int ObtenerIdRol(int usuarioDNI)
        {
            using (ProyectoTPII_MoraesLeandroEntities db = new ProyectoTPII_MoraesLeandroEntities())
            {
                var user = (from u in db.usuario
                            where u.DNI_usuario == usuarioDNI
                            select u).FirstOrDefault();

                if (user != null)
                {
                    // Si el usuario no es nulo, devuelve el valor de id_rol.
                    return user.id_rol ?? 0; // Si es nulo, se devuelve 0 (o cualquier otro valor predeterminado).
                }

               
                throw new Exception("Usuario no encontrado");
            }
        }

        public string ObtenerNombreUsuario(int usuarioDNI)
        {
            return cdLogin.ObtenerNombreUsuario(usuarioDNI);
        }
    }
}

