using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid OrderNum { get; set; }
        public Address Address { get; set; }
        public virtual string GetAddress()
        {
            return $"Address: {Address.Country} {Address.City} {Address.Street} {Address.StreetNum} {Address.PostalCode} ";
        }

        protected string OIB { get; set; }
    }
}
