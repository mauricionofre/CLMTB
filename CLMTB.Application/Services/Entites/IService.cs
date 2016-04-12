using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.ApplicationLayer.Services.Entites
{
    public interface IService<T>
    {
        void Add(T obj);

        void Update(T obj);

        void Delete(int id);

        T GetById(int id);

        IList<T> GetAll();
    }
}