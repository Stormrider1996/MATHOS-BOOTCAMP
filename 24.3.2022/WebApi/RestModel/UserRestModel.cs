using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.RestModel
{
    public class UserRestModel : IUserRestModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
