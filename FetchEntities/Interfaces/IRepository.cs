using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchEntities.Interfaces
{
    public interface IRepository
    {
        List<Pet> FindDogs(int radius, decimal min_latitude, decimal max_latitude, decimal min_longitude, decimal max_longitude);
        List<Pet> FindDogs(int radius, decimal min_latitude, decimal max_latitude, decimal min_longitude, decimal max_longitude, string age = "", string sex = "", string size = "");
    }
}
