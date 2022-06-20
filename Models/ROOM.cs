namespace QL_Quan_Kara
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROOM")]
    public partial class ROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROOM()
        {
            ROOM_ORDER = new HashSet<ROOM_ORDER>();
        }

        [Key]
        [StringLength(10)]
        public string ID_ROOM { get; set; }

        [StringLength(20)]
        public string ROOM_NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string ROOM_TYPE { get; set; }

        public long PRICE { get; set; }

        public int? CAPACITY { get; set; }

        [StringLength(20)]
        public string STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROOM_ORDER> ROOM_ORDER { get; set; }
    }
}
