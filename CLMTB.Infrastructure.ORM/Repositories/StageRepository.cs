using CLMTB.Domain.Contracts;
using CLMTB.Domain.Entities;
using CLMTB.Infrastructure.ORM.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Infrastructure.ORM.Repositories
{
    public class StageRepository : RepositoryBase<Stage>, IStageRepository
    {
        public StageRepository(EntityFrameworkFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IQueryable<Stage> GetCategory()
        {
            return GetQueryable();
        }
    }
}