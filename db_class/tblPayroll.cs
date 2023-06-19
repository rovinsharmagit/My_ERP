namespace db_class
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblPayroll
    {
        public int PayrollID { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Select Employee")]
        public int EmployeeID { get; set; }
        public int BranchID { get; set; }
        public int CompanyID { get; set; }

        [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Salary Amount")]
        public int TransferAmount { get; set; }
        public int PayrollInvoiceNo { get; set; }
        public System.DateTime PaymentDate { get; set; }

         [Required(ErrorMessage = "*Required!")]
        [Display(Name = "Salary Of Month")]
        public string SalaryMonth { get; set; }
        public System.DateTime SalaryYear { get; set; }
        public int UserID { get; set; }
    
        public virtual tblBranch tblBranch { get; set; }
        public virtual tblCompany tblCompany { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual tblUser tblUser { get; set; }
    }
}
