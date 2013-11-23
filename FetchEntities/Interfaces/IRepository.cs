using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchEntities.Interfaces
{
    public interface IRepository
    {
        void CreateDog(string Name, string Breed, string Description, string Type, bool AtRisk, string Age, string Sex, string Size, int OrganizationId);
        Pet FindDog(int id);
        List<Pet> FindDogs(int radius, decimal min_latitude, decimal max_latitude, decimal min_longitude, decimal max_longitude);
        List<Pet> FindDogs(int radius, decimal min_latitude, decimal max_latitude, decimal min_longitude, decimal max_longitude, string age = "", string sex = "", string size = "");
        void UpdateDog(int id, string name, string breed, string description, bool atRisk, string age, string sex, string size, string status);
    }
}
