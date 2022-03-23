using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Example.WebApi.Controllers
{
    public class PlaceOfBirthController : ApiController
    {
        static List<PlaceOfBirth> places = new List<PlaceOfBirth>();

        //CREATE 
        [HttpPost]
        [Route("api/AddPlace")]
        public HttpResponseMessage CreateUser(PlaceOfBirth place)
        {
            places.Add(place);
            return Request.CreateResponse(HttpStatusCode.OK, place);
        }

        //READ
        [HttpGet]
        [Route("api/GetUsers")]
        public HttpResponseMessage GetPlaces()
        {
            if (places.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, places);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "No places of birth have been registered!");
            }
        }

        //DELETE
        [HttpDelete]
        [Route("api/DeleteUser")]
        public HttpResponseMessage DeletePlaceByZIP(PlaceOfBirth place)
        {
            PlaceOfBirth output = places.Find(x => x.ZIP == place.ZIP);

            if (output != null)
            {
                places.Remove(output);
                return Request.CreateResponse(HttpStatusCode.OK, output);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, $"Place not found");
            }
        }

        //UPDATE
        [HttpPut]
        [Route("api/UpdateUser")]
        public HttpResponseMessage UpdatePlaceByZIP(PlaceOfBirth place)
        {
            PlaceOfBirth output = places.Find(x => x.ZIP == place.ZIP);
            if (output != null)
            {
                output.ZIP = place.ZIP;
                output.CityName = place.CityName;
                output.CountryName = place.CountryName;
                return Request.CreateResponse(HttpStatusCode.OK, output);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, $"Developer not found");
            }
        }
    }
}