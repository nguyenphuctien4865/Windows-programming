using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QL_Quan_Kara.Maps
{
    public class RoomMap: EntityTypeConfiguration<ROOM>
    {
        public RoomMap()
        {

            Property(e => e.ID_ROOM)
                .IsUnicode(false);

            HasMany(e => e.ROOM_ORDER)
                .WithRequired(e => e.ROOM)
                .WillCascadeOnDelete(false);
        }
    }
}
