//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace capaDatos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.RegistroUsuario = new HashSet<RegistroUsuario>();
            this.venta = new HashSet<venta>();
        }
    
        public int id_usuario { get; set; }
        public Nullable<int> DNI_usuario { get; set; }
        public Nullable<int> id_rol { get; set; }
        public string nombre_usuario { get; set; }
        public string apellido_usuario { get; set; }
        public string direccion_usuario { get; set; }
        public string contraseña_usuario { get; set; }
        public Nullable<int> estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroUsuario> RegistroUsuario { get; set; }
        public virtual tipo_rol tipo_rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta> venta { get; set; }
    }
}