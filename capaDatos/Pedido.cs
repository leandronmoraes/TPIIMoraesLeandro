using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Pedido
    {
        public int id_pedido { get; set; }
        public DateTime fecha_pedido { get; set; }
        public string nombre_producto_pedido { get; set; }
        public int cantidad_pedido { get; set; }
        public string descripcion_pedido { get; set; }
        public string direccion_pedido { get; set; }
        public int? id_proveedor { get; set; }
        public int estado { get; set; }
        public int? id_producto { get; set; }
    }

}
