using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace db_class
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUserType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUserType()
        {
            this.tblUsers = new HashSet<tblUser>();
        }
    
        public int UserTypeID { get; set; }

        [Required(ErrorMessage ="*Required!")]
        [StringLength(50, ErrorMessage ="*Max length is 50!")]
        [Display(Name ="User Type")]
        public string UserType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser> tblUsers { get; set; }
    }
}
