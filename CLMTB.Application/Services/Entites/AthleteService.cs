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
    public interface IAthleteService : IService<Athlete>
    {
    }

    public class AthleteService : IAthleteService
    {
        private IAthleteRepository _athleteRepository;
        private IUnitOfWork _unitOfWork;

        public AthleteService()
        {
            _unitOfWork = Injection.Get<IUnitOfWork>();
            _athleteRepository = Injection.Get<IAthleteRepository>();
        }

        public void Add(Athlete athlete)
        {
            _athleteRepository.Add(athlete);

            _unitOfWork.Commit();
        }

        public void Update(Athlete obj)
        {
            _athleteRepository.Update(obj);

            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _athleteRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public Athlete GetById(int id)
        {
            return _athleteRepository.GetById(id);
        }

        public IList<Athlete> GetAll()
        {
            return _athleteRepository.GetAll();
        }
    }
}