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
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int SaleUnitPrice { get; set; }
        public int CurrentPurchaseUnitPrice { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public System.DateTime Manufacture { get; set; }
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
