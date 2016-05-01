using CLMTB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Infrastructure.ORM.Configuration
{
    public class StageConfiguration : EntityTypeConfiguration<Stage>
    {
        public StageConfiguration()
        {
            ToTable("Stage");
            HasKey(s => s.Id);

            Property(s => s.Name);
        }
    }
}