using CLMTB.ApplicationLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.ApplicationLayer.Services.Entites
{
    public interface ICategoryService : IService<CategoryDTO>
    {
    }

    public class CategoryService : ICategoryService
    {
        public void Add(CategoryDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<CategoryDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}