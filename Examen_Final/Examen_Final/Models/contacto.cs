//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class contacto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contacto()
        {
            this.Visitas = new HashSet<Visita>();
        }
    
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string identidad { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visita> Visitas { get; set; }
    }
}
