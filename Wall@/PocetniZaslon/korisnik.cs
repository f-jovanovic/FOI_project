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
    
    public partial class korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public korisnik()
        {
            this.bankovni_racun = new HashSet<bankovni_racun>();
            this.investicijski_portfolio = new HashSet<investicijski_portfolio>();
        }
    
        public int id_korisnik { get; set; }
        public string ime_korisnika { get; set; }
        public string prezime_korisnika { get; set; }
        public string email { get; set; }
        public string lozinka { get; set; }
        public System.DateTime datum_registracije { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bankovni_racun> bankovni_racun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<investicijski_portfolio> investicijski_portfolio { get; set; }
    }
}
