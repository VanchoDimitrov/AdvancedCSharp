using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Interfaces;

namespace BackEnd.Entities
{
    public class Customer : ICustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public City City { get; set; }
        public Region Region { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
        public virtual double Balance { get; set; }
    }
}
