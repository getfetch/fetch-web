using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FetchDomain.Services;

namespace FetchWeb.Models
{
    public class DogCreateModel : DogBaseModel
    {
        public void Create()
        {
            // TODO: Tie in organization lookup
            DogServices services = new DogServices();
            services.CreateDog(Name, Breed, Description, Type, AtRisk, Age, Sex, Size, 1);
        }
    }
}