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
    
    public partial class DomicilioTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DomicilioTipo()
        {
            this.EntidadDomicilio = new HashSet<EntidadDomicilio>();
        }
    
        public byte IdDomicilioTipo { get; set; }
        public string Nombre { get; set; }
        public bool EsActivo { get; set; }
        public short IdUsuarioCreacion { get; set; }
        public System.DateTime FechaHoraCreacion { get; set; }
        public short IdUsuarioModificacion { get; set; }
        public System.DateTime FechaHoraModificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntidadDomicilio> EntidadDomicilio { get; set; }
        public virtual Usuario UsuarioCreacion { get; set; }
        public virtual Usuario UsuarioModificacion { get; set; }
    }
}
