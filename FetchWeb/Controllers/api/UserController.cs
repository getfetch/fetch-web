using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FetchWeb.Models.api;

namespace FetchWeb.Controllers.api
{
    public class UserController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Test()
        {
            return Ok();
        }

        [HttpGet]
        public IHttpActionResult AddToFavorites(string userToken, int petId)
        {
            UserAddToFavoritesModel model = new UserAddToFavoritesModel() { 
                UserToken = userToken,
                PetId = petId,
            };

            try
            {
                model.Save();
                var response = new
                {
                    Status = "succes",
                    Message = "This pet has been added.",
                };
                return Ok(response);
            }
            catch(Exception ex)
            {
                var response = new { 
                    Status = "error",
                    Message = ex.Message,
                };
                return Ok(response);
            }

        }
    }
}
