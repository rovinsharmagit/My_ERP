namespace db_class
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTransaction
    {
        public int TransactionID { get; set; }
        public int FinancialYearID { get; set; }
        public int AccountHeadID { get; set; }
        public int AccountControlID { get; set; }
        public int AccountSubControlID { get; set; }
        public int InvoiceNo { get; set; }
        public int CompanyID { get; set; }
        public int BranchID { get; set; }
        public int Credit { get; set; }
        public int Debit { get; set; }
        public System.DateTime TransectionDate { get; set; }
        public string TransectionTitle { get; set; }
        public int UserID { get; set; }
    
        public virtual tblAccountControl tblAccountControl { get; set; }
        public virtual tblAccountHead tblAccountHead { get; set; }
        public virtual tblAccountHead tblAccountHead1 { get; set; }
        public virtual tblAccountSubControl tblAccountSubControl { get; set; }
        public virtual tblFinancialYear tblFinancialYear { get; set; }
        public virtual tblFinancialYear tblFinancialYear1 { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
