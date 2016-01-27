//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityF
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER()
        {
            this.ORDERDETAILS = new HashSet<ORDERDETAILS>();
            this.PROJECT1 = new HashSet<PROJECT>();
        }
    
        public decimal ORDER_ID { get; set; }
        public decimal CLIENT_ID { get; set; }
        public Nullable<decimal> PROJECT_ID { get; set; }
        public decimal CURRENCY_ID { get; set; }
        public decimal STATUS_ID { get; set; }
        public Nullable<decimal> TOTALAMOUNT { get; set; }
        public Nullable<int> TOTALQUANTITY { get; set; }
    
        public virtual CURRENCY CURRENCY { get; set; }
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual PROJECT PROJECT { get; set; }
        public virtual ORDERSTATUS ORDERSTATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDERDETAILS> ORDERDETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROJECT> PROJECT1 { get; set; }
    }
}