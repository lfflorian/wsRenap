//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wsRenap
{
    using System;
    using System.Collections.Generic;
    
    public partial class Documento
    {
        public Documento()
        {
            this.Personas = new HashSet<Persona>();
        }
    
        public int IdDocumento { get; set; }
        public string numeroDPI { get; set; }
        public Nullable<System.DateTime> fechaEmisiòn { get; set; }
        public Nullable<System.DateTime> fechaVencimiento { get; set; }
    
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
