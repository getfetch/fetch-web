using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FetchEntities.Repositories;
using FetchEntities.Interfaces;

namespace FetchDomain.Services
{
    public class UserServices
    {
        private readonly IRepository _repo = new DatabaseRepository();
        public void AddToFavorites(string userToken, int petId)
        {
            _repo.SavePetToUserFavorites(userToken, petId);
        }
    }
}
