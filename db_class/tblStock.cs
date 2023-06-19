namespace db_class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblStock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblStock()
        {
            this.tblCustomerInvoiceDetails = new HashSet<tblCustomerInvoiceDetail>();
            this.tblSupplierInvoiceDetails = new HashSet<tblSupplierInvoiceDetail>();
        }
    
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public int CompanyID { get; set; }
        public int BranchID { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Product Title")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Sale Unit Price")]
        public int SaleUnitPrice { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "CP Price")]
        public int CurrentPurchaseUnitPrice { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Expiry Date")]
        public System.DateTime ExpiryDate { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Manufacture Date")]
        public System.DateTime Manufacture { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Treshold Qty")]
        public int StockTreshHoldQuantity { get; set; }
        public string Description { get; set; }
        public Nullable<int> Barcode { get; set; }
        public int UserID { get; set; }
    
        public virtual tblBranch tblBranch { get; set; }
        public virtual tblCategory tblCategory { get; set; }
        public virtual tblCompany tblCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomerInvoiceDetail> tblCustomerInvoiceDetails { get; set; }
        public virtual tblUser tblUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSupplierInvoiceDetail> tblSupplierInvoiceDetails { get; set; }
    }
}
