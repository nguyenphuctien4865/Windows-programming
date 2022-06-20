using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace QL_Quan_Kara.Maps
{
    public class EmployeeMap : EntityTypeConfiguration<EMPLOYEE>
    {
        public EmployeeMap()
        {

            Property(e => e.PHONE)
                .IsFixedLength()
                .IsUnicode(false);

            Property(e => e.EMAIL)
                .IsUnicode(false);

            Property(e => e.ID_CARD)
                .IsUnicode(false);

            HasMany(e => e.BILLs)
                .WithRequired(e => e.EMPLOYEE)
                .WillCascadeOnDelete(false);

            HasOptional(a => a.ACCOUNT)
                .WithRequired(b => b.EMPLOYEE)
                .WillCascadeOnDelete(true);
        }
    }
}
