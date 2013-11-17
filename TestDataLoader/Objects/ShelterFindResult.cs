using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataLoader.Objects
{
    class ShelterFindResult
    {
        public ShelterFindResultPetfinder petfinder { get; set; }

        public void SaveToDb()
        {
            petfinder.SaveToDb();
        }
    }
}
