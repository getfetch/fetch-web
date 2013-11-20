using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using FetchDomain.Interfaces;
using FetchWeb.Interfaces;
using FetchDomain.Services;

namespace FetchWeb.Models.api
{
    public class DogsBrowseModel : BaseModel, IDogsBrowseModel
    {
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public int Distance { get; set; }
        public string FilterOptions { get; set; }
        public int Offset { get; set; }

        //TODO: Remove dependency
        private readonly DogServices _services = new DogServices();

        public List<IDog> FindDogs()
        {
            JavaScriptSerializer Json = new JavaScriptSerializer();

            // TODO: try to make the FilterOptions an object of type DogFilterOptions
            //DogFilterOptions responseObj = Json.Deserialize<DogFilterOptions>(FilterOptions);


            List<IDog> dogs = _services.FindDogs(Distance, Decimal.Parse(Latitude), Decimal.Parse(Longitude));
            return dogs;
        }
    }
}