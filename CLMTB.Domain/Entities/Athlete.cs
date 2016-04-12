using CLMTB.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Domain.Entities
{
    public class Athlete : Entity
    {
        public Athlete(string name, DateTime birthDate, Address address)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Address = address;
        }

        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime BirthDate { get; set; }
        public string BloodType { get; set; }
        public string Fone { get; set; }

        public Address Address { get; set; }
    }
}