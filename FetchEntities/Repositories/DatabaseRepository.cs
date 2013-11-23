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

        #region DogMethods
        public void CreateDog(string Name, string Breed, string Description, string Type, bool AtRisk, string Age, string Sex, string Size, int OrganizationId)
        {
            Pet pet = new Pet() { 
                Type = Type,
                Name = Name,
                Description = Description,
                AtRisk = AtRisk,
                Age = Age,
                Sex = Sex,
                Size = Size,
                Breed = Breed,
                // TODO: Remove this
                OrganizationId = OrganizationId,
            };

            _db.Pets.Add(pet);
            _db.SaveChanges();
        }
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
        #endregion

        #region OrganizationMethods
        public void CreateOrganziation(string Name, string Phone, string Email, string AddrLine1, string AddrLine2, string City, string State, string Zip, string FirstName, string LastName, string ContactEmail, string ContactPhone)
        {
            Organization org = new Organization()
            {
                Name = Name,
                Phone = Phone,
                Email = Email,
                Type = "shelter",
            };
            org.Address = new Address()
            { 
                Line1 = AddrLine1,
                Line2 = AddrLine2,
                City = City,
                State = State,
                Zip = Zip,
            };

            org.User = new User() { 
                FirstName = FirstName,
                LastName = LastName,
                Phone = ContactPhone,
                Email = ContactEmail,
            };

            _db.Organizations.Add(org);
            _db.SaveChanges();
        }
        #endregion
    }
}
