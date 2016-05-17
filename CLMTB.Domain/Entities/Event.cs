using CLMTB.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Domain.Entities
{
    public class Event : Entity
    {
        public Event()
        {
            Stages = new List<Stage>();
        }

        public string Name { get; set; }

        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }

        public List<Stage> Stages { get; set; }

        public List<Category> Categories { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        public string Promotion { get; set; }
    }
}