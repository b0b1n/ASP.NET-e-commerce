//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonPCapplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUIT()
        {
            this.CLIENT_PRODUIT = new HashSet<CLIENT_PRODUIT>();
        }
    
        public int id { get; set; }
        public string nomProduit { get; set; }
        public string Description { get; set; }
        public string image { get; set; }
        public Nullable<decimal> prix { get; set; }
        public Nullable<int> quantité { get; set; }
        public int ajoute_par { get; set; }
        public int appartient_a { get; set; }
    
        public virtual CATEGORIE CATEGORIE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENT_PRODUIT> CLIENT_PRODUIT { get; set; }
        public virtual FOURNISSEUR FOURNISSEUR { get; set; }
    }
}
