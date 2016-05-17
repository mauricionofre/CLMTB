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
    public interface IEventService : IService<EventDTO>
    {
    }

    public class EventService : IEventService
    {
        private IEventRepository _eventRepository;
        private IUnitOfWork _unitOfWork;

        public EventService()
        {
            _eventRepository = Injection.Get<IEventRepository>();
            _unitOfWork = Injection.Get<IUnitOfWork>();
        }

        public void Add(EventDTO obj)
        {
            var evt = new Event();

            evt.Id = obj.Id;
            evt.Name = obj.Name;
            evt.InitialDate = obj.InitialDate;
            evt.FinalDate = obj.FinalDate;
            evt.City = obj.City;
            evt.State = obj.State;

            evt.Promotion = obj.Promotion;

            evt.Categories = obj.Categories;
            evt.Stages = obj.Stages;

            _eventRepository.Add(evt);
            _unitOfWork.Commit();
        }

        public void Update(EventDTO obj)
        {
            var evt = _eventRepository.GetById(obj.Id);
            evt.Name = obj.Name;
            evt.InitialDate = obj.InitialDate;
            evt.FinalDate = obj.FinalDate;
            evt.City = obj.City;
            evt.State = obj.State;

            evt.Promotion = obj.Promotion;

            evt.Categories = obj.Categories;
            evt.Stages = obj.Stages;

            _eventRepository.Update(evt);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            _eventRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public EventDTO GetById(int id)
        {
            var evt = _eventRepository.GetById(id);
            return new EventDTO(evt);
        }

        public IList<EventDTO> GetAll()
        {
            return _eventRepository
                .GetAll()
                .Select(e => new EventDTO(e))
                .ToList();
        }
    }
}