using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QL_Quan_Kara.Maps
{
    public class RoomOrderMap: EntityTypeConfiguration<ROOM_ORDER>
    {
        public RoomOrderMap()
        {

            Property(e => e.ID_ROOM)
                .IsUnicode(false);

            HasMany(e => e.BILLs)
                .WithRequired(e => e.ROOM_ORDER)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ORDER_S)
                .WithRequired(e => e.ROOM_ORDER)
                .WillCascadeOnDelete(false);
        }
    }
}
