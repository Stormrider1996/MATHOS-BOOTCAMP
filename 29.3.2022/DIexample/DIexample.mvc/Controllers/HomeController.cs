using DIexample.mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DIexample.mvc.Controllers
{
    public class HomeController : Controller
    {
        private ITransientUniqueKeyProvider _transientUniquekeyProvider;
        private IScopedUniqueKeyProvider _scopedUniquekeyProvider;
        private ISingletonUniqueKeyProvider _singletonUniquekeyProvider;
        private ISomeService _someserviceProvider;
        public HomeController
           (ITransientUniqueKeyProvider transientprovider,
            IScopedUniqueKeyProvider scopedprovider,
            ISingletonUniqueKeyProvider singletonprovider, 
            ISomeService someserviceprovider)
        {
            _transientUniquekeyProvider = transientprovider;
            _scopedUniquekeyProvider = scopedprovider;
            _singletonUniquekeyProvider = singletonprovider;
            _someserviceProvider = someserviceprovider;
        }
        public IActionResult Index()
        {
            ViewBag.transientID = _transientUniquekeyProvider.UniqueKey;
            ViewBag.scopedID = _scopedUniquekeyProvider.UniqueKey;
            ViewBag.singletonID = _singletonUniquekeyProvider.UniqueKey;
            ViewBag.someServiceProvider = _someserviceProvider;
            return View();
        }
    }
}
