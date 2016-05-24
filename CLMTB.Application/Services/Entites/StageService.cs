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
    public interface IStageService : IService<StageDTO>
    {
    }

    public class StageService : IStageService
    {
        private IStageRepository _stageRepository;
        private IUnitOfWork _unitOfWork;

        public StageService()
        {
            _unitOfWork = Injection.Get<IUnitOfWork>();
            _stageRepository = Injection.Get<IStageRepository>();
        }

        /// <summary>
        /// FinalDate equals InitialDate
        /// </summary>
        /// <param name="obj"></param>
        public void Add(StageDTO obj)
        {
            Stage stage = new Stage();

            stage.Id = obj.Id;
            stage.Name = obj.Name;
            stage.Sequential = obj.Sequential;
            stage.InitialDate = obj.InitialDate;
            stage.FinalDate = obj.InitialDate;
            stage.GpxFile = obj.GpxFile;
            stage.StageType = obj.StageType;

            _stageRepository.Add(stage);
            _unitOfWork.Commit();
        }

        /// <summary>
        /// FinalDate equals InitialDate
        /// </summary>
        /// <param name="obj"></param>
        public void Update(StageDTO obj)
        {
            var stage = _stageRepository.GetById(obj.Id);

            stage.Name = obj.Name;
            stage.Sequential = obj.Sequential;
            stage.InitialDate = obj.InitialDate;
            stage.FinalDate = obj.InitialDate;
            stage.GpxFile = obj.GpxFile;
            stage.StageType = obj.StageType;

            _stageRepository.Update(stage);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _stageRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public StageDTO GetById(int id)
        {
            var stage = _stageRepository.GetById(id);
            return new StageDTO(stage);
        }

        public IList<StageDTO> GetAll()
        {
            return _stageRepository
                   .GetAll()
                   .Select(c => new StageDTO(c))
                   .ToList();
        }
    }
}