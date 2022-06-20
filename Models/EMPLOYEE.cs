namespace QL_Quan_Kara
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPLOYEE")]
    public partial class EMPLOYEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLOYEE()
        {
            BILLs = new HashSet<BILL>();
            ACCOUNT = new ACCOUNT();

        }

        [Key]
        public int ID_EMPLOYEE { get; set; }

        [Required]
        [StringLength(99)]
        public string NAME { get; set; }

        [StringLength(15)]
        public string PHONE { get; set; }

        [StringLength(99)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(20)]
        public string ID_CARD { get; set; }

        [Required]
        [StringLength(99)]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(20)]
        public string ROLE_EMOLOYEE { get; set; }

      
        public DateTime DoB { get; set; }



        public virtual ACCOUNT ACCOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }
    }
}
