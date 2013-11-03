using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FetchWeb.Controllers.api
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public string Organization { get; set; }
    }

    public class DogsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Browse(int id)
        {
            int zip = id;

            Dog Tess = new Dog
            {
                Name = "Tess",
                Breed = "Beagles",
                Description = "She be KAAAARAAAAZY",
                Organization = "Beagle Rescue of America"
            };

            Dog Shannon = new Dog
            {
                Name = "Shannon",
                Breed = "Pembroke Welsh Corgi/Boston Terrier",
                Description = "Whose the boss? She is.",
                Organization = "Bob's Breeder"
            };

            List<Dog> DogList = new List<Dog>();
            DogList.Add(Tess);
            DogList.Add(Shannon);

            var response = new
            {
                Zip = zip,
                Dogs = DogList,
            };
            return Ok(response);
        }
    }
}
