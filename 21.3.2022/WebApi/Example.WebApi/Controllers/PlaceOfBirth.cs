using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.WebApi.Controllers
{
    public class PlaceOfBirth
    {
        public int ZIP { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public static List<PlaceOfBirth> Place { get; set; }
    }
}