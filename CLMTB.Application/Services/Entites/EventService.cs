using CLMTB.ApplicationLayer.DTO;
using CLMTB.Domain.Contracts;
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
            throw new NotImplementedException();
        }

        public void Update(EventDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public EventDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<EventDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}