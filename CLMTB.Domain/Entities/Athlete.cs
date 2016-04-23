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
        public Athlete()
        {
            BloodType = BloodGroupEnum.ONeg;
        }

        public Athlete(string name, DateTime birthDate, string cpf)
            : this()
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.CPF = cpf;
        }

        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime BirthDate { get; set; }
        public BloodGroupEnum BloodType { get; set; }
        public string Email { get; set; }
        public string Fone { get; set; }

        public string Gender { get; set; }

        public Address Address { get; set; }
    }
}