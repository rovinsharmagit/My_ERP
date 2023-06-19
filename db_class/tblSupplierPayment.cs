namespace db_class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblSupplierPayment
    {
        public int SupplierPaymentID { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Select Supplier")]
        public int SupplierID { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Enter Invoice No")]
        public int SupplierInvoiceID { get; set; }
        public int CompanyID { get; set; }
        public int BranchID { get; set; }
        public int invoiceNo { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [DataType(DataType.Currency)]
        [Display(Name = "Total Amount")]
        public int TotalAmount { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [DataType(DataType.Currency)]
        [Display(Name = "Enter Payment Amount")]
        public int PaymentAmount { get; set; }
        public int RemainingBalance { get; set; }
        public int UserID { get; set; }
    
        public virtual tblSupplier tblSupplier { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
