using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FetchEntities;

namespace TestDataLoader.Objects
{
    class ShelterFindShelter
    {
        public Dictionary<string, object> name { get; set; }
        public Dictionary<string, object> longitude { get; set; }
        public Dictionary<string, object> latitude { get; set; }
        public Dictionary<string, object> address1 { get; set; }
        public Dictionary<string, object> address2 { get; set; }
        public Dictionary<string, object> city { get; set; }
        public Dictionary<string, object> state { get; set; }
        public Dictionary<string, object> zip { get; set; }
        public Dictionary<string, object> country { get; set; }
        public Dictionary<string, object> phone { get; set; }
        public Dictionary<string, object> email { get; set; }
        public Dictionary<string, object> fax { get; set; }
        public Dictionary<string, object> id { get; set; }

        public PetFinderOrganization SaveToDb()
        {
            Organization org = new Organization()
            {
                Name = name.ElementAt(0).Value.ToString(),
                Type = "Shelter",
                MainContactId = 1,
            };
            if(phone.Count > 0)
            {
                org.Phone = phone.ElementAt(0).Value.ToString();
            }
            else
            {
                org.Phone = "Unavailable";
            }
            if(email.Count > 0)
            {
                org.Email = email.ElementAt(0).Value.ToString();
            }
            else
            {
                org.Email = "Unavailable";
            }

            org.Address = new Address() {
                City = city.ElementAt(0).Value.ToString(),
                State = state.ElementAt(0).Value.ToString(),
                Zip = zip.ElementAt(0).Value.ToString(),
                Longitude = Decimal.Parse(longitude.ElementAt(0).Value.ToString()),
                Latitude = Decimal.Parse(latitude.ElementAt(0).Value.ToString()),
            };
            if (address1.Count > 0)
            {
                org.Address.Line1 = address1.ElementAt(0).Value.ToString();
            }
            else
            {
                org.Address.Line1 = "Unavailable";
            }
            if (address2.Count > 0)
            {
                org.Address.Line2 = address2.ElementAt(0).Value.ToString();
            }

            PetFinderOrganization petOrg = new PetFinderOrganization() { 
                PetFInderId = id.ElementAt(0).Value.ToString(),
                Organization = org
            };

            return petOrg;
        }
    }
}
