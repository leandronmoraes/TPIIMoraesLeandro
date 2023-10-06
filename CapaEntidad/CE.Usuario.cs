using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class CE
    {
        public class Usuario
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string NombreUsuario { get; set; }
            public string DNI { get; set; }
            public string Direccion { get; set; }
            public string Contrasena { get; set; }
            public string Perfil { get; set; }
            public byte[] Imagen { get; set; }
        }
    }
}
