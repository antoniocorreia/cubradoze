//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CubraDoze.WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partida()
        {
            this.Jogada = new HashSet<Jogada>();
        }
    
        public int Id { get; set; }
        public string Time1 { get; set; }
        public string Time2 { get; set; }
        public Nullable<System.DateTime> DataRegistro { get; set; }
        public Nullable<bool> Vencedor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jogada> Jogada { get; set; }
    }
}
