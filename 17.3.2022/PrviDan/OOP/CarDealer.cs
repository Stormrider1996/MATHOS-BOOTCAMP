using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class CarDealer : Customer
    {
        public string NameOfDealer { get; set; }
        public override string GetAddress()
        {
            return $"Address: {Address.Country} {Address.City} {Address.Street} {Address.StreetNum} {Address.PostalCode} ";
        }

    }
}