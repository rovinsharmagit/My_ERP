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
    
    public partial class tblSupplierInvoiceDetail
    {
        public int SupplierInvoiceDetailID { get; set; }
        public int SupplierInvoiceID { get; set; }
        public int ProductID { get; set; }
        public int PurchaseQuantity { get; set; }
        public int purchaseUnitPrice { get; set; }
    
        public virtual tblStock tblStock { get; set; }
        public virtual tblSupplierInvoice tblSupplierInvoice { get; set; }
    }
}
