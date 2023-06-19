namespace db_class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblSupplierInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSupplierInvoice()
        {
            this.tblSupplierInvoiceDetails = new HashSet<tblSupplierInvoiceDetail>();
        }
    
        public int SupplierInvoiceID { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Select Supplier")]
        public int SupplierID { get; set; }
        public int CompanyID { get; set; }
        public int BranchID { get; set; }
        public int InvoiceNo { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [DataType(DataType.Currency)]
        [Display(Name = "Total Amount")]
        public int TotalAmount { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
    
        public virtual tblBranch tblBranch { get; set; }
        public virtual tblCompany tblCompany { get; set; }
        public virtual tblSupplier tblSupplier { get; set; }
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSupplierInvoiceDetail> tblSupplierInvoiceDetails { get; set; }
    }
}
