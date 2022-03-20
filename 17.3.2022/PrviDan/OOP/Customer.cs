using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface ICustomer
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string OIB { get; set; }
        Guid orderNum { get; set; }
    }
}
