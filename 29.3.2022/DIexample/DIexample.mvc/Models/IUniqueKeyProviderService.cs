using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIexample.mvc.Models
{
    public interface IUniqueKeyProviderService
    {
        Guid UniqueKey { get; set; }
    }
    public interface ITransientUniqueKeyProvider : IUniqueKeyProviderService
    { }
    public interface IScopedUniqueKeyProvider : IUniqueKeyProviderService
    { }
    public interface ISingletonUniqueKeyProvider : IUniqueKeyProviderService
    { }
}
