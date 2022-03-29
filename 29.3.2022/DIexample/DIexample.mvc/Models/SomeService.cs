using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIexample.mvc.Models
{
    public class SomeService : ISomeService
    {
       
        public ITransientUniqueKeyProvider TransientUniquekeyProvider { get; set; }
     
        public IScopedUniqueKeyProvider ScopedUniquekeyProvider { get; set; }

        public ISingletonUniqueKeyProvider SingletonUniquekeyProvider { get; set; }

        public SomeService
           (ITransientUniqueKeyProvider transientprovider,
            IScopedUniqueKeyProvider scopedprovider,
            ISingletonUniqueKeyProvider singletonprovider)
        {
            TransientUniquekeyProvider = transientprovider;
            ScopedUniquekeyProvider = scopedprovider;
            SingletonUniquekeyProvider = singletonprovider;
        }
    }
}
