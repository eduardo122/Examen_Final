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
    
    public partial class Visita
    {
        public int ID { get; set; }
        public string Motivo { get; set; }
        public System.DateTime fecha { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> Recibido { get; set; }
    
        public virtual contacto contacto { get; set; }
    }
}
