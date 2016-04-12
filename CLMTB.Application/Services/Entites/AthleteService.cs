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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Athlete GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Athlete> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}