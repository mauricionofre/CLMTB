using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Domain.Common
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(int id);

        T GetById(int id);

        T GetByIdIncluding(int id, params Expression<Func<T, object>>[] includeProperties);

        IList<T> GetAll();

        IList<T> GetMany(Expression<Func<T, bool>> where);

        IList<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

        int GetCount();
    }
}