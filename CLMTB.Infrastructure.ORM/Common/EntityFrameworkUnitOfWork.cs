using CLMTB.Infrastructure.DAO.Common.Uow;
using CLMTB.Infrastructure.ORM.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Infrastructure.ORM.Common
{
    public class EntityFrameworkUnitOfWork : IUnitOfWork
    {
        private EntityFrameworkContext dbContext;

        private readonly EntityFrameworkFactory dbFactory;

        protected EntityFrameworkContext DbContext
        {
            get
            {
                return dbContext = dbContext ?? dbFactory.Get();
            }
        }

        public DbContext Test()
        {
            return dbContext;
        }

        public EntityFrameworkUnitOfWork(EntityFrameworkFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        public void CommitAndRefreshChanges()
        {
            bool saveFailed = false;

            do
            {
                try
                {
                    DbContext.SaveChanges();

                    saveFailed = false;
                }
                catch (Exception)
                {
                    saveFailed = true;

                    var context = ((IObjectContextAdapter)DbContext).ObjectContext;

                    var refreshableObjects = (from entry in context.ObjectStateManager.GetObjectStateEntries(
                                                                 EntityState.Added
                                                               | EntityState.Deleted
                                                               | EntityState.Modified
                                                               | EntityState.Unchanged)
                                              where entry.EntityKey != null && entry.Entity != null
                                              select entry.Entity)

                                              .ToList();

                    context.Refresh(RefreshMode.StoreWins, refreshableObjects);

                    context.SaveChanges();
                }
            } while (saveFailed);
        }

        public void Rollback()
        {
            DbContext.Dispose();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}