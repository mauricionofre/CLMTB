using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLMTB.Domain.Entities
{
    public class Address
    {
        public Address()
        {
        }

        public Address(string street, string city)
        {
            this.Street = street;
            this.City = city;
        }

        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
    }
}