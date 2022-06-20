using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QL_Quan_Kara.Maps
{
    public class AccountMap: EntityTypeConfiguration<ACCOUNT>
    {
        public AccountMap()
        {
            Property(e => e.ACCOUNT_NAME)
                .IsUnicode(false);

            Property(e => e.PASSWORD)
                .IsUnicode(false);

            Property(e => e.ROLE)
                .IsUnicode(false);
        }
    }
        
 }
    

