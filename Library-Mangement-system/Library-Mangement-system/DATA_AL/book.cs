//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Mangement_system.DATA_AL
{
    using System;
    using System.Collections.Generic;
    
    public partial class book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public book()
        {
            this.borrow = new HashSet<borrow>();
            this.publisher = new HashSet<publisher>();
        }
    
        public int bk_id { get; set; }
        public string bk_name { get; set; }
        public Nullable<int> bk_pages { get; set; }
        public string map_plates { get; set; }
        public Nullable<int> bk_rate { get; set; }
        public string bk_notes { get; set; }
        public string language { get; set; }
        public Nullable<int> bk_volume { get; set; }
        public Nullable<System.DateTime> publication_year { get; set; }
        public Nullable<int> authors_id { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<System.DateTime> bk_entry_date { get; set; }
        public Nullable<bool> del { get; set; }
        public Nullable<int> bk_parts { get; set; }
        public Nullable<int> categories_id { get; set; }
    
        public virtual author author { get; set; }
        public virtual categorie categorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<borrow> borrow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<publisher> publisher { get; set; }
    }
}
