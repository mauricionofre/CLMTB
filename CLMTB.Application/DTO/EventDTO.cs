using CLMTB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.ApplicationLayer.DTO
{
    public class EventDTO
    {
        public EventDTO()
        {
        }

        public EventDTO(Event evt)
        {
            Id = evt.Id;
            Name = evt.Name;
            InitialDate = evt.InitialDate;
            FinalDate = evt.FinalDate;
            City = evt.City;
            State = evt.State;
            Promotion = evt.Promotion;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime InitialDate { get; set; }

        public DateTime FinalDate { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Promotion { get; set; }

        public List<Category> Categories { get; set; }

        public List<Stage> Stages { get; set; }
    }
}