using CLMTB.ApplicationLayer.DTO;
using CLMTB.Domain.Contracts;
using CLMTB.Domain.Entities;
using CLMTB.Infrastructure.DAO.Common.Uow;
using CLMTB.Infrastructure.IoC;
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
        private ICategoryRepository _categoryRepository;
        private IUnitOfWork _unitOfWork;

        public CategoryService()
        {
            _unitOfWork = Injection.Get<IUnitOfWork>();
            _categoryRepository = Injection.Get<ICategoryRepository>();
        }

        public void Add(CategoryDTO category)
        {
            Category cat = new Category();
            cat.Name = category.Name;
            cat.Description = category.Description;
            cat.Type = category.Type;

            _categoryRepository.Add(cat);

            _unitOfWork.Commit();
        }

        public void Update(CategoryDTO category)
        {
            Category cat = _categoryRepository.GetById(category.Id);

            cat.Name = category.Name;
            cat.Description = category.Description;
            cat.Type = category.Type;

            _categoryRepository.Update(cat);

            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public CategoryDTO GetById(int id)
        {
            var cat = _categoryRepository.GetById(id);
            return new CategoryDTO(cat);
        }

        public IList<CategoryDTO> GetAll()
        {
            return _categoryRepository
                   .GetAll()
                   .Select(c => new CategoryDTO(c))
                   .ToList();
        }
    }
}