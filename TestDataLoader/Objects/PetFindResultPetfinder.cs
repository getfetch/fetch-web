using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataLoader.Objects
{
    public class PetFindResultPetfinder
    {
        public PetFindPets pets { get; set; }

        public void SaveToDb()
        {
            pets.SaveToDb();
        }

    }
}
