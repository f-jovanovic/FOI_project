//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PocetniZaslon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Investicija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Investicija()
        {
            this.Stanje_investicije = new HashSet<Stanje_investicije>();
            this.Transakcija_investicije = new HashSet<Transakcija_investicije>();
        }
    
        public int id_investicije { get; set; }
        public int id_vrsta_investicije { get; set; }
        public string naziv_investicije { get; set; }
    
        public virtual Vrsta_investicije Vrsta_investicije { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stanje_investicije> Stanje_investicije { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transakcija_investicije> Transakcija_investicije { get; set; }
    }
}
