using FetchEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public Pet FindDog(int id)
        {
            return _db.Pets.Find(id);
        }


        public List<Pet> FindDogs(int radius, decimal min_latitude, decimal max_latitude, decimal min_longitude, decimal max_longitude, string status)
        {
            return FindDogs(radius, min_latitude, max_latitude, min_longitude, max_longitude, status, "", "", "");
        }

        public List<Pet> FindDogs(int radius, decimal min_latitude, decimal max_latitude, decimal min_longitude, decimal max_longitude, string status, string age = "", string sex = "", string size = "")
        {
            List<Pet> dogs = new List<Pet>();
            var orgs = _db.Organizations.Where(m => m.Address.Latitude >= min_latitude && m.Address.Latitude <= max_latitude && m.Address.Longitude >= min_longitude && m.Address.Longitude <= max_longitude).Select(m => m);
            bool filterByStatus = (status != null && status != "") ? true : false;

            foreach (var org in orgs)
            {
                foreach (var dog in org.Pets.Where(m => m.Type == "dog"))
                {
                    if(!filterByStatus || dog.Status.ToLower() == status.ToLower())
                    {
                        dogs.Add(dog);
                    }
                }
            }
            return dogs;
        }

        public Pet GetFeatured()
        {
            Random rnd = new Random();
            int? start = _db.Pets.OrderBy(m => m.Id).Select(m => m.Id).FirstOrDefault() as int?;
            int? end = _db.Pets.OrderByDescending(m => m.Id).Select(m => m.Id).FirstOrDefault() as int?;

            Pet featured = null;
            int randId;
            while(featured == null)
            {
                randId = rnd.Next(start.Value, end.Value);
                featured = _db.Pets.Find(randId);
            }
            return featured;
        }

        public void UpdateDog(int id, string name, string breed, string description, bool atRisk, string age, string sex, string size, string status)
        {
            Pet pet = FindDog(id);
            if(pet != null)
            {
                pet.Name = name;
                pet.Breed = breed;
                pet.Description = description;
                pet.AtRisk = atRisk;
                pet.Age = age;
                pet.Sex = sex;
                pet.Size = size;
                pet.Status = status;

                _db.Entry(pet).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
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

        #region UserMethods
        public void SavePetToUserFavorites(string userToken, int petId)
        {
            // TODO: find user id from userToken
            int userId = 1;

            // Add only if it's not already added
            var alreadySaved = _db.UserPetFavorites.Where(m => m.UserId == userId && m.PetId == petId).FirstOrDefault();
            if (alreadySaved == null)
            {
                UserPetFavorite fav = new UserPetFavorite()
                {
                    PetId = petId,
                    UserId = userId,
                };
                _db.UserPetFavorites.Add(fav);
                _db.SaveChanges();
            }
        }
        #endregion
    }
}
