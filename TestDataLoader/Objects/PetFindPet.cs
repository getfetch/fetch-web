using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FetchEntities;

namespace TestDataLoader.Objects
{
    public class PetFindPet
    {
        //public PetFindPetBreeds breeds { get; set; }
        public Dictionary<string, object> shelterPetId { get; set; }
        public Dictionary<string, object> status { get; set; }
        public Dictionary<string, object> name { get; set; }
        public Dictionary<string, object> contact { get; set; }
        public Dictionary<string, object> description { get; set; }
        public Dictionary<string, object> sex { get; set; }
        public Dictionary<string, object> age { get; set; }
        public Dictionary<string, object> size { get; set; }
        public Dictionary<string, object> mix { get; set; }
        public Dictionary<string, object> shelterId { get; set; }
        public Dictionary<string, object> media { get; set; }
        public Dictionary<string, object> id { get; set; }
        public Dictionary<string, object> animal { get; set; }

        FetchEntities.FetchEntities _db = new FetchEntities.FetchEntities();

        public Pet SaveToDb()
        {
            if (animal.ElementAt(0).Value.ToString().ToLower() == "dog")
            {
                Pet pet = new Pet()
                {
                    Name = name.ElementAt(0).Value.ToString(),
                    Description = description.ElementAt(0).Value.ToString(),
                    Sex = sex.ElementAt(0).Value.ToString(),
                    Age = age.ElementAt(0).Value.ToString(),
                    Size = size.ElementAt(0).Value.ToString(),
                    Breed = "",
                    Type = "dog",
                };

                // Assign a pet to an organization
                if (shelterId.Count > 0)
                {
                    string petFinderId = shelterId.ElementAt(0).Value.ToString();
                    var petOrg = _db.PetFinderOrganizations.Where(m => m.PetFInderId == petFinderId).FirstOrDefault();
                    if (petOrg == null)
                    {
                        return null;
                    }
                    pet.OrganizationId = (petOrg as PetFinderOrganization).OrganizationId;
                }
                return pet;
            }
            return null;
        }
    }
}
