using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FetchEntities;

namespace TestDataLoader.Objects
{
    public class PetFindPets
    {
        public List<PetFindPet> pet { get; set; }

        public void SaveToDb()
        {
            FetchEntities.FetchEntities _db = new FetchEntities.FetchEntities();
            foreach (PetFindPet newPet in pet)
            {
                Pet petEntity = newPet.SaveToDb();
                if(petEntity != null)
                {
                    _db.Pets.Add(petEntity);
                }
            }
            _db.SaveChanges();
        }

    }
}
