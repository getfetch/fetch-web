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
        // TODO : Remove Dependency
        private IRepository _repo = new DatabaseRepository();

        public void CreateDog(string Name, string Breed, string Description, string Type, bool AtRisk, string Age, string Sex, string Size, int OrganizationId)
        {
            _repo.CreateDog(Name, Breed, Description, Type, AtRisk, Age, Sex, Size, OrganizationId);
        }

        public IDog FindDog(int id)
        {
            Pet pet = _repo.FindDog(id);
            // TODO: remove dependency
            IDog newDog = new Dog()
            {
                Name = pet.Name,
                Breed = pet.Breed,
                Description = pet.Description,
                Organization = pet.Organization.Name,
                Id = pet.Id,
                Sex = pet.Sex,
                Size = pet.Size,
                Age = pet.Age,
                AtRisk = pet.AtRisk,
                Status = pet.Status,
            };

            return newDog;
        }

        public List<IDog> FindDogs(int radius, decimal latitude, decimal longitude, string status)
        {
            return FindDogs(radius, latitude, longitude, status, "", "", "");
        }
        public List<IDog> FindDogs(int radius, decimal latitude, decimal longitude, string status, string age = "", string sex = "", string size = "")
        {
            // Determine a lat/long range
            Decimal lat_range = radius / (Decimal)69.172;
            Decimal lon_range = Convert.ToDecimal(Math.Abs(radius / (Math.Cos(3959) * 69.172)));
            Decimal min_lat = latitude - lat_range;
            Decimal max_lat = latitude + lat_range;
            Decimal min_lon = longitude - lon_range;
            Decimal max_lon = longitude + lon_range;

            List<Pet> pets = _repo.FindDogs(radius, min_lat, max_lat, min_lon, max_lon, status);
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
                    Age = pet.Age,
                    AtRisk = pet.AtRisk,
                    Status = pet.Status,
                };

                dogs.Add(newDog);
            }
            return dogs;
        }

        public IDog GetFeatured()
        {
            Pet pet = _repo.GetFeatured();
            IDog featured = new Dog() {
                    Name = pet.Name,
                    Breed = pet.Breed,
                    Description = pet.Description,
                    Organization = pet.Organization.Name,
                    Id = pet.Id,
                    Sex = pet.Sex,
                    Size = pet.Size,
                    Age = pet.Age,
                    AtRisk = pet.AtRisk,
                    Status = pet.Status,
            };
            return featured;
        }

        public void UpdateDog(int id, string name, string breed, string description, bool atRisk, string age, string sex, string size, string status)
        {
            _repo.UpdateDog(id, name, breed, description, atRisk, age, sex, size, status);
        }

    }
}
