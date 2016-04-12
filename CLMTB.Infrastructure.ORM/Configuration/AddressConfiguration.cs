using CLMTB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Infrastructure.ORM.Configuration
{
    public class AddressConfiguration : ComplexTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
            Property(p => p.City);
            Property(p => p.Street);
            Property(p => p.Neighborhood);
            Property(p => p.Number);
            Property(p => p.UF);
        }
    }
}