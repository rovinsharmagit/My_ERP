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
    
    public partial class tblEmployee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEmployee()
        {
            this.tblPayrolls = new HashSet<tblPayroll>();
        }
    
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CNIC { get; set; }
        public string Designation { get; set; }
        public byte[] Description { get; set; }
        public double MonthlySalary { get; set; }
        public int BranchID { get; set; }
        public int CompanyID { get; set; }
    
        public virtual tblBranch tblBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPayroll> tblPayrolls { get; set; }
        public virtual tblCompany tblCompany { get; set; }
    }
}
