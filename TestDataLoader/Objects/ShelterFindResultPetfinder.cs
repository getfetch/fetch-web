using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataLoader.Objects
{
    class ShelterFindResultPetfinder
    {
        public ShelterFindShelters shelters { get; set; }

        public void SaveToDb()
        {
            shelters.SaveToDb();
        }
    }
}
