using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Infrastructure.DAO.Common.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();

        void Rollback();
    }

    public interface IAuthUnitOfWork : IUnitOfWork { }
}