using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QL_Quan_Kara.Maps
{
    public class MenuMap: EntityTypeConfiguration<MENU>
    {
        public MenuMap()
        {

             HasMany(e => e.ORDER_S)
                .WithOptional(e => e.MENU)
                .HasForeignKey(e => e.ID_MENU);

        }
    }
}
