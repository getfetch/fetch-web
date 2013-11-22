using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FetchDomain.Services;

namespace FetchWeb.Models
{
    public class OrganizationCreateModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Display(Name = "Address Line 1")]
        [Required]
        public string AddrLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddrLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Contact Email")]
        public string ContactEmail { get; set; }
        [Display(Name = "Contact Phone")]
        public string ContactPhone { get; set; }

        public void Create()
        {
            //TODO: Remove dependency
            OrganizationServices orgServices = new OrganizationServices();
            orgServices.Create(Name, Phone, Email, AddrLine1, AddrLine2, City, State, Zip, FirstName, LastName, ContactEmail, ContactPhone);

        }
    }
}