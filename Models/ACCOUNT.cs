namespace QL_Quan_Kara
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {


        [Key]
        [ForeignKey("EMPLOYEE")]
        public int ID_EMPLOYEE { get; set; }

        [StringLength(20)]
        public string ACCOUNT_NAME { get; set; }

        [StringLength(40)]
        public string PASSWORD { get; set; }

        [StringLength(20)]
        public string ROLE { get; set; }

        //[ForeignKey("EMPLOYEE")]

        public virtual EMPLOYEE EMPLOYEE { get; set; }
    }
}
