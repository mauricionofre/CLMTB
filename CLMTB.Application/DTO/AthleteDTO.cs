using CLMTB.Domain.Entities;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.ApplicationLayer.DTO
{
    public class AthleteDTO
    {
        public AthleteDTO()
        {
            BirthDate = DateTime.Now;
        }

        public AthleteDTO(Athlete athlete)
        {
            Id = athlete.Id;
            Name = athlete.Name;
            CPF = athlete.CPF;
            RG = athlete.RG;
            BirthDate = athlete.BirthDate;
            BloodType = athlete.BloodType;
            Email = athlete.Email;
            Fone = athlete.Fone;
            Gender = athlete.Gender;
            Street = athlete.Address.Street;
            Neighborhood = athlete.Address.Neighborhood;
            Number = athlete.Address.Number;
            City = athlete.Address.City;
            State = athlete.Address.UF;
        }

        public int Id { get; set; }

        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("RG")]
        public string RG { get; set; }

        [DisplayName("Data Nascimento")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Tipo Sanguineo")]
        public BloodGroupEnum BloodType { get; set; }

        [Browsable(false)]
        public string Email { get; set; }

        [DisplayName("Telefone")]
        public string Fone { get; set; }

        [DisplayName("Sexo")]
        public string Gender { get; set; }

        [Browsable(false)]
        public string Street { get; set; }

        [Browsable(false)]
        public string Neighborhood { get; set; }

        [Browsable(false)]
        public string Number { get; set; }

        [Browsable(false)]
        public string City { get; set; }

        [Browsable(false)]
        public string State { get; set; }

        public bool Validate()
        {
            if (this.Name.Length.Equals(0))
                return false;

            if (this.CPF.Length.Equals(0))
                return false;

            if (this.BirthDate == null)
                return false;

            return true;
        }
    }
}