namespace QL_Quan_Kara
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMER")]
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            ROOM_ORDER = new HashSet<ROOM_ORDER>();
        }

        [Key]
        public int ID_CUSTOMER { get; set; }

        [Required]
        [StringLength(99)]
        public string CUSTOMER_NAME { get; set; }

        [StringLength(15)]
        public string PHONE { get; set; }

        [StringLength(99)]
        public string EMAIL { get; set; }

        [StringLength(20)]
        public string ID_CARD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROOM_ORDER> ROOM_ORDER { get; set; }
    }
}
