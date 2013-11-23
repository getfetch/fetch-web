using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using FetchDomain.Services;

namespace FetchWeb.Models
{
    public class DogCreateModel
    {
        public IEnumerable<SelectListItem> GenderItems
        {
            get 
            {
                List<string> _genders = new List<string>();
                _genders.Add("M");
                _genders.Add("F");
                return new SelectList(_genders); 
            }
        }

        public IEnumerable<SelectListItem> SizeItems
        {
            get
            {
                List<string> _sizes = new List<string>();
                _sizes.Add("XS");
                _sizes.Add("S");
                _sizes.Add("M");
                _sizes.Add("L");
                _sizes.Add("XL");
                return new SelectList(_sizes);
            }
        }
        
        public string Type {
            get
            {
                return "dog";
            }
        }
        [Required]
        public string Name { get; set; }
        public string OrganizationId { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool AtRisk { get; set; }
        [Required]
        public string Age { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public string Size { get; set; }


        public void Create()
        {
            // TODO: Tie in organization lookup
            DogServices services = new DogServices();
            services.CreateDog(Name, Breed, Description, Type, AtRisk, Age, Sex, Size, 1);
        }
    }
}