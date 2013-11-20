using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FetchWeb.Models.api;
using FetchDomain.Interfaces;

namespace FetchWeb.Controllers.api
{
    public class DogsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Browse(string Longitude, string Latitude, int Distance)
        {
            DogsBrowseModel model = new DogsBrowseModel() { 
                Longitude = Longitude,
                Latitude = Latitude,
                Distance = Distance
            };

            List<IDog> DogList = model.FindDogs();

            var response = new
            {
                Latitude = model.Latitude,
                Longitude = model.Longitude,
                Dogs = DogList,
            };
            return Ok(response);
        }
    }
}


//http://localhost:2088/api/dogs/browse/?Longitude=-80.00&Latitude=40.40&Distance=100
