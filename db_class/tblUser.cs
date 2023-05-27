using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace db_class
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUser()
        {
            this.tblAccountControls = new HashSet<tblAccountControl>();
            this.tblAccountHeads = new HashSet<tblAccountHead>();
            this.tblAccountSubControls = new HashSet<tblAccountSubControl>();
            this.tblCategories = new HashSet<tblCategory>();
            this.tblCustomers = new HashSet<tblCustomer>();
            this.tblCustomerInvoices = new HashSet<tblCustomerInvoice>();
            this.tblCustomerPayments = new HashSet<tblCustomerPayment>();
            this.tblFinancialYears = new HashSet<tblFinancialYear>();
            this.tblPayrolls = new HashSet<tblPayroll>();
            this.tblStocks = new HashSet<tblStock>();
            this.tblSuppliers = new HashSet<tblSupplier>();
            this.tblSupplierInvoices = new HashSet<tblSupplierInvoice>();
            this.tblSupplierPayments = new HashSet<tblSupplierPayment>();
            this.tblTransactions = new HashSet<tblTransaction>();
        }
    
        public int UserID { get; set; }
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="*Required!")]
        [StringLength(50, ErrorMessage ="*Max length is 50!")]
        [Display(Name ="Select User Type")]
        public int UserTypeID { get; set; }

        [Required(ErrorMessage ="*Required!")]
        [StringLength(50, ErrorMessage ="*Max length is 50!")]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="*Required!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email Adsress")]
        public string Email { get; set; }

        [Required(ErrorMessage ="*Required!")]
        [Display(Name ="Contact No")]
        public int ContactNo { get; set; }

        [Required(ErrorMessage ="*Required!")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="*Required!")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        public string Password { get; set; }

        [Display(Name = "Status")]
        public string IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAccountControl> tblAccountControls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAccountHead> tblAccountHeads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAccountSubControl> tblAccountSubControls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCategory> tblCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomer> tblCustomers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomerInvoice> tblCustomerInvoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomerPayment> tblCustomerPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFinancialYear> tblFinancialYears { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPayroll> tblPayrolls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblStock> tblStocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSupplier> tblSuppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSupplierInvoice> tblSupplierInvoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSupplierPayment> tblSupplierPayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
        public virtual tblUserType tblUserType { get; set; }
    }
}
