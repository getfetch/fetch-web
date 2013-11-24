using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FetchDomain.Services;
using FetchDomain.Interfaces;

namespace FetchWeb.Models.api
{
    public class UserAddToFavoritesModel
    {
        private readonly UserServices _services = new UserServices();

        public string UserToken { get; set; }
        public int PetId { get; set; }

        public void Save()
        {
            _services.AddToFavorites(UserToken, PetId);
        }
    }
}