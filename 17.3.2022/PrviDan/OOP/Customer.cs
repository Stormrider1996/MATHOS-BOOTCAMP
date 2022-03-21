using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer : CarBrand, ICustomer
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

        private string IBAN;

        public string Account
        {
            get { return $"{FirstName} ${LastName} ${OrderNum}"; }
            set { IBAN = value; }
        }

    }
}



