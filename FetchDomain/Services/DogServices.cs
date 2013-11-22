using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FetchDomain.Interfaces;
using FetchDomain.Objects;
using FetchEntities;
using FetchEntities.Interfaces;
using FetchEntities.Repositories;

namespace FetchDomain.Services
{
    public class DogServices : BaseService
    {
        public List<IDog> FindDogs(int radius, decimal latitude, decimal longitude)
        {
            return FindDogs(radius, latitude, longitude, "", "", "");
        }
        public List<IDog> FindDogs(int radius, decimal latitude, decimal longitude, string age = "", string sex = "", string size = "")
        {
            // Determine a lat/long range
            Decimal lat_range = radius / (Decimal)69.172;
            Decimal lon_range = Convert.ToDecimal(Math.Abs(radius / (Math.Cos(3959) * 69.172)));
            Decimal min_lat = latitude - lat_range;
            Decimal max_lat = latitude + lat_range;
            Decimal min_lon = longitude - lon_range;
            Decimal max_lon = longitude + lon_range;

            // TODO: Remove dependency
            IRepository repo = new DatabaseRepository();

            List<Pet> pets = repo.FindDogs(radius, min_lat, max_lat, min_lon, max_lon);
            List<IDog> dogs = new List<IDog>();
            foreach (Pet pet in pets)
            {
                // TODO: remove dependency
                IDog newDog = new Dog() {
                    Name = pet.Name,
                    Breed = pet.Breed,
                    Description = pet.Description,
                    Organization = pet.Organization.Name,
                    Id = pet.Id,
                    Sex = pet.Sex,
                    Size = pet.Size,
                };

                dogs.Add(newDog);
            }
            return dogs;
        }
    }
}
