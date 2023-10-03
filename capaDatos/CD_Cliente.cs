using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace capaDatos
{
    public class CD_Cliente
    {
        
        public List<Cliente> listarr()
        {
            List<Cliente> clientes = new List<Cliente>();
            {
                new Cliente { DNI = "42743277", Nombre = "Leandro Moraes" };
                new Cliente { DNI = "1234", Nombre = "Usuario1" };
                new Cliente { DNI = "5678", Nombre = "Usuario2" };
                // Agrega más clientes aquí
            };
            clientes.Add(new Cliente()
            {
                DNI = "42743277", Nombre = "Leandro Moraes"

            });
            return clientes;
        }
    }
}
