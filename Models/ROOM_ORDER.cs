namespace QL_Quan_Kara
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ROOM_ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROOM_ORDER()
        {
            BILLs = new HashSet<BILL>();
            ORDER_S = new HashSet<ORDER_S>();
        }

        [Key]
        public int ID_ROOM_ORDER { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_ROOM { get; set; }

        public int ID_CUSTOMER { get; set; }

        public DateTime TIME_IN { get; set; }

        public DateTime? TIME_OUT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_S> ORDER_S { get; set; }

        public virtual ROOM ROOM { get; set; }
    }
}
