//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestionnaire_de_depenses
{
    using System;
    using System.Collections.Generic;
    
    public partial class Budget
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Budget()
        {
            this.Transactions = new HashSet<Transactions>();
        }
    
        public int ID_Budget { get; set; }
        public Nullable<double> Montant { get; set; }
        public string Mois_Budget { get; set; }
        public string Utilisateur_Username { get; set; }
    
        public virtual Utilisateurs Utilisateurs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
