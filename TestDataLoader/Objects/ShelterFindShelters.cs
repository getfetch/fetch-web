using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FetchEntities;

namespace TestDataLoader.Objects
{
    class ShelterFindShelters
    {
        public List<ShelterFindShelter> shelter { get; set; }

        public void SaveToDb()
        {
            FetchEntities.FetchEntities _db = new FetchEntities.FetchEntities();
            foreach (ShelterFindShelter newShelter in shelter)
            {
                PetFinderOrganization orgEntity = newShelter.SaveToDb();
                if (orgEntity != null)
                {
                    _db.PetFinderOrganizations.Add(orgEntity);
                }
            }
            _db.SaveChanges();
        }
    }
}
