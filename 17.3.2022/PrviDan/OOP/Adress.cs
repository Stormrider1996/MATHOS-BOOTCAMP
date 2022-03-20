using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface IAdress
    {
        string country { get; set; }

        string city { get; set; }

        string street { get; set; }

        string streetNum { get; set; }

        int postalCode { get; set; }
    }
}
