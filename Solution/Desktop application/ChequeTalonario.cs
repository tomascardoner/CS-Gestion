//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS_Gestion
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChequeTalonario
    {
        public int IdEntidad { get; set; }
        public byte IdCuentaBancaria { get; set; }
        public short IdChequeTalonario { get; set; }
        public byte IdChequeTalonarioTipo { get; set; }
        public string Serie { get; set; }
        public Nullable<int> NumeroInicio { get; set; }
        public Nullable<int> NumeroFin { get; set; }
        public string Notas { get; set; }
        public bool EsActivo { get; set; }
        public short IdUsuarioCreacion { get; set; }
        public System.DateTime FechaHoraCreacion { get; set; }
        public short IdUsuarioModificacion { get; set; }
        public System.DateTime FechaHoraModificacion { get; set; }
    
        public virtual ChequeTalonarioTipo ChequeTalonarioTipo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}