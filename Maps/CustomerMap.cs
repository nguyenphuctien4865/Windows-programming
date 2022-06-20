using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QL_Quan_Kara.Maps
{
    public class CustomerMap: EntityTypeConfiguration<CUSTOMER>
    {
        public CustomerMap()
        {
            Property(e => e.PHONE)
                .IsFixedLength()
                .IsUnicode(false);

            Property(e => e.EMAIL)
                .IsUnicode(false);

            Property(e => e.ID_CARD)
                .IsUnicode(false);

            HasMany(e => e.ROOM_ORDER)
                .WithRequired(e => e.CUSTOMER)
                .WillCascadeOnDelete(false);
        }
    }
}
