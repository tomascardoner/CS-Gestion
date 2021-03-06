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
    
    public partial class EntidadDomicilio
    {
        public int IdEntidad { get; set; }
        public byte IdDomicilio { get; set; }
        public byte IdDomicilioTipo { get; set; }
        public string TipoOtro { get; set; }
        public string Calle1 { get; set; }
        public string Numero { get; set; }
        public string Piso { get; set; }
        public string Departamento { get; set; }
        public string Calle2 { get; set; }
        public string Calle3 { get; set; }
        public string Barrio { get; set; }
        public string DomicilioParaMostrar { get; set; }
        public string CodigoPostal { get; set; }
        public Nullable<byte> IdProvincia { get; set; }
        public Nullable<short> IdLocalidad { get; set; }
        public string Notas { get; set; }
        public bool EsActivo { get; set; }
        public short IdUsuarioCreacion { get; set; }
        public System.DateTime FechaHoraCreacion { get; set; }
        public short IdUsuarioModificacion { get; set; }
        public System.DateTime FechaHoraModificacion { get; set; }
    
        public virtual DomicilioTipo DomicilioTipo { get; set; }
        public virtual Entidad Entidad { get; set; }
        public virtual Localidad Localidad { get; set; }
        public virtual Usuario UsuarioCreacion { get; set; }
        public virtual Usuario UsuarioModificacion { get; set; }
    }
}
