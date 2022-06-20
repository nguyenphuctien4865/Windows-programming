namespace QL_Quan_Kara
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BILL")]
    public partial class BILL
    {
        [Key]
        public int ID_BILL { get; set; }

        public int ID_ROOM_ORDER { get; set; }

        public int ID_EMPLOYEE { get; set; }

        public long? TOTAL { get; set; }

        public int? TAX { get; set; }

        public virtual EMPLOYEE EMPLOYEE { get; set; }

        public virtual ROOM_ORDER ROOM_ORDER { get; set; }
    }
}
