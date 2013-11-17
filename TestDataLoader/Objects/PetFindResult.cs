using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataLoader.Objects
{
    public class PetFindResult
    {
        public PetFindResultPetfinder petfinder { get; set; }

        public void SaveToDb()
        {
            petfinder.SaveToDb();
        }

    }
}
