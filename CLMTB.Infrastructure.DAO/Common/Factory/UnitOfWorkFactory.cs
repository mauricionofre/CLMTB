using CLMTB.Infrastructure.DAO.Common.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Infrastructure.DAO.Common.Factory
{
    public abstract class UnitOfWorkFactory
    {
        public abstract IUnitOfWork Create();
    }
}