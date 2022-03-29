using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIexample.mvc.Models
{
    public class UniqueKeyProviderService : ITransientUniqueKeyProvider, ISingletonUniqueKeyProvider, IScopedUniqueKeyProvider
    {
        public Guid UniqueKey { get; set; }

        public UniqueKeyProviderService(Guid uniqueKey)
        {
            UniqueKey = uniqueKey;
        }
    }
}
