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
    
    public partial class borrower
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public borrower()
        {
            this.borrow = new HashSet<borrow>();
        }
    
        public int bwr_id { get; set; }
        public string bwr_name { get; set; }
        public string bwr_address { get; set; }
        public string bwr_code { get; set; }
        public string bwr_phone { get; set; }
        public string bwr_rank { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<borrow> borrow { get; set; }
    }
}