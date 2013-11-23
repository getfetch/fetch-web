using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FetchWeb.Models
{
    public class DogBaseModel
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

        public IEnumerable<SelectListItem> StatusItems
        {
            get
            {
                List<string> _statuses = new List<string>();
                _statuses.Add("Available");
                _statuses.Add("Adotpted");
                return new SelectList(_statuses);
            }
        }

        public string Type
        {
            get
            {
                return "dog";
            }
        }

        public int Id { get; set; }
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
        public string Status { get; set; }
    }
}