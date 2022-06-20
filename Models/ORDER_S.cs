namespace QL_Quan_Kara
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDER_S
    {
        [Key]
        public int ID_ORDER { get; set; }

        public int ID_ROOM_ORDER { get; set; }

        public int? ID_MENU { get; set; }

        public int? QTY { get; set; }

        [StringLength(99)]
        public string NOTE { get; set; }

        public long? TOTAL_PRICE { get; set; }

        public virtual MENU MENU { get; set; }

        public virtual ROOM_ORDER ROOM_ORDER { get; set; }
    }
}
