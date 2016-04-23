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
    public interface IAthleteService : IService<AthleteDTO>
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

        public void Add(AthleteDTO athleteDto)
        {
            Athlete athlete = new Athlete(athleteDto.Name, athleteDto.BirthDate, athleteDto.CPF);

            athlete.RG = athleteDto.RG;
            athlete.Gender = athleteDto.Gender;

            athlete.BloodType = athleteDto.BloodType;
            athlete.Email = athleteDto.Email;
            athlete.Fone = athleteDto.Fone;

            athlete.Address = new Address();
            athlete.Address.Street = athleteDto.Street;
            athlete.Address.Number = athleteDto.Number;
            athlete.Address.Neighborhood = athleteDto.Neighborhood;
            athlete.Address.City = athleteDto.City;
            athlete.Address.UF = athleteDto.State;

            _athleteRepository.Add(athlete);

            _unitOfWork.Commit();
        }

        public void Update(AthleteDTO athlete)
        {
            Athlete ath = _athleteRepository.GetById(athlete.Id);

            ath.Name = athlete.Name;
            ath.CPF = athlete.CPF;
            ath.RG = athlete.RG;
            ath.BirthDate = athlete.BirthDate;
            ath.BloodType = athlete.BloodType;
            ath.Gender = athlete.Gender;

            ath.Email = athlete.Email;
            ath.Fone = athlete.Fone;

            ath.Address.Street = athlete.Street;
            ath.Address.Number = athlete.Number;
            ath.Address.Neighborhood = athlete.Neighborhood;
            ath.Address.City = athlete.City;
            ath.Address.UF = athlete.State;

            _athleteRepository.Update(ath);

            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _athleteRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public AthleteDTO GetById(int id)
        {
            var ath = _athleteRepository.GetById(id);
            return new AthleteDTO(ath);
        }

        public IList<AthleteDTO> GetAll()
        {
            return _athleteRepository
                .GetAll()
                .Select(a => new AthleteDTO(a))
                .ToList();
        }
    }
}