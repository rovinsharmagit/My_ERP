//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace db_class
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAccountHead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAccountHead()
        {
            this.tblAccountSubControls = new HashSet<tblAccountSubControl>();
            this.tblTransactions = new HashSet<tblTransaction>();
            this.tblTransactions1 = new HashSet<tblTransaction>();
        }
    
        public int AccountHeadID { get; set; }
        public int CompanyID { get; set; }
        public int BranchID { get; set; }
        public string AccountHeadName { get; set; }
        public int Code { get; set; }
        public int UserID { get; set; }
    
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAccountSubControl> tblAccountSubControls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions1 { get; set; }
    }
}
