//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public int DNI_usuario { get; set; }
        public Nullable<int> id_rol { get; set; }
        public string nombre_usuario { get; set; }
        public string apellido_usuario { get; set; }
        public string direccion_usuario { get; set; }
        public string contraseña_usuario { get; set; }
        public byte[] avatar { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual tipo_rol tipo_rol { get; set; }
    }
}
