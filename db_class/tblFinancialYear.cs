namespace db_class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblFinancialYear
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFinancialYear()
        {
            this.tblTransactions = new HashSet<tblTransaction>();
            this.tblTransactions1 = new HashSet<tblTransaction>();
        }
    
        public int FinancialYearID { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [DataType(DataType.Date)]
        [Display(Name = "Select Financial Year Start Date")]
        public System.DateTime FinancialYear { get; set; }

        [Display(Name = "Status")]
        public string IsActive { get; set; }
        public int UserID { get; set; }
    
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions1 { get; set; }
    }
}
