using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FetchDomain.Services;

namespace FetchWeb.Models
{
    public class DogEditModel : DogBaseModel
    {
        private DogServices _services = new DogServices();

        public void Load(int id)
        {
            var dog = _services.FindDog(id);
            if(dog != null)
            {
                Id = dog.Id;
                Name = dog.Name;
                Breed = dog.Breed;
                Description = dog.Description;
                AtRisk = dog.AtRisk;
                Age = dog.Age;
                Sex = dog.Sex;
                Size = dog.Size;
                Status = dog.Status;
            }
        }

        public void Update()
        {
            _services.UpdateDog(Id, Name, Breed, Description, AtRisk, Age, Sex, Size, Status);
        }
    }
}