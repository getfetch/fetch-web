using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FetchWeb.Models.api
{
    public class DogFilterOptions
    {
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Breed { get; set; }
    }
}