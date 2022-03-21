using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface ICustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        Guid OrderNum { get; set; }
        Address Address { get; set; }
        string GetAddress();
    }
}
