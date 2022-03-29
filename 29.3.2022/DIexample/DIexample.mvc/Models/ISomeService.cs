using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIexample.mvc.Models
{
    public interface ISomeService 
    {
        ITransientUniqueKeyProvider TransientUniquekeyProvider { get; set; }
       
        IScopedUniqueKeyProvider ScopedUniquekeyProvider { get; set; }

        ISingletonUniqueKeyProvider SingletonUniquekeyProvider { get; set; }

    }
}
