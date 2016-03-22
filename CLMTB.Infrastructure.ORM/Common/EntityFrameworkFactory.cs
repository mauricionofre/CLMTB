using CLMTB.Infrastructure.DAO.Common.Factory;
using CLMTB.Infrastructure.DAO.Common.Uow;
using CLMTB.Infrastructure.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Infrastructure.ORM.Common
{
    public class EntityFrameworkFactory : UnitOfWorkFactory, IDisposable
    {
        private EntityFrameworkContext dataContext;

        public EntityFrameworkContext Get()
        {
            if (dataContext == null)
            {
                dataContext = new EntityFrameworkContext();
            }
            return dataContext;
        }

        public void Dispose()
        {
            // dataContext?.Dispose(); todo: c# 6
            if (dataContext != null)
                dataContext.Dispose();
        }

        public override IUnitOfWork Create()
        {
            return new EntityFrameworkUnitOfWork(null);
        }
    }
}