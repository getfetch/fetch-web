using FetchEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchEntities.Repositories
{
    public class DatabaseRepository : IRepository
    {
        private static FetchEntities _db = new FetchEntities();

        public List<Pet> FindDogs(int radius, decimal min_latitude, decimal max_latitude, decimal min_longitude, decimal max_longitude)
        {
            return FindDogs(radius, min_latitude, max_latitude, min_longitude, max_longitude, "", "", "");
        }

        public List<Pet> FindDogs(int radius, decimal min_latitude, decimal max_latitude, decimal min_longitude, decimal max_longitude, string age = "", string sex = "", string size = "")
        {
            List<Pet> dogs = new List<Pet>();
            var orgs = _db.Organizations.Where(m => m.Address.Latitude >= min_latitude && m.Address.Latitude <= max_latitude && m.Address.Longitude >= min_longitude && m.Address.Longitude <= max_longitude).Select(m => m);

            foreach (var org in orgs)
            {
                foreach (var dog in org.Pets.Where(m => m.Type == "dog"))
                {
                    dogs.Add(dog);
                }
            }
            return dogs;
        }
    }
}
