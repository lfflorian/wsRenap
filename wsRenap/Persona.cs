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
    
    public partial class Persona
    {
        public int IdPersona { get; set; }
        public Nullable<int> IdDocumento { get; set; }
        public string Nombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellido { get; set; }
        public string SegundoApellido { get; set; }
        public string ApellidoCasada { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public Nullable<System.DateTime> FechaDeceso { get; set; }
        public Nullable<bool> PensiónAlimenticia { get; set; }
    
        public virtual Documento Documento { get; set; }
    }
}
