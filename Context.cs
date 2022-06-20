using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using QL_Quan_Kara.Maps;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace QL_Quan_Kara
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=QLKara")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BILL> BILLs { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public virtual DbSet<MENU> MENUs { get; set; }
        public virtual DbSet<ORDER_S> ORDER_S { get; set; }
        public virtual DbSet<ROOM> ROOMs { get; set; }
        public virtual DbSet<ROOM_ORDER> ROOM_ORDER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new RoomMap());
            modelBuilder.Configurations.Add(new RoomOrderMap());
        
        }
    }
    
}
