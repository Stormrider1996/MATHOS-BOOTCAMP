using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public class CarDealer : CarBrand, IAdress, ICustomer
    {
        public string nameOfDealer;

        public string country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string city { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string street { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string streetNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int postalCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string firstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string lastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string OIB { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Guid orderNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
