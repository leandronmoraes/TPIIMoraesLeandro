using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace capaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objCliente = new CD_Cliente();//instanciamos un cliente
        public List<Cliente> listarCliente()
        {
            return objCliente.listarr();
        }
        
    }
}
