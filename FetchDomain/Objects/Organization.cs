﻿using FetchDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Mvc;

namespace FetchDomain.Objects
{
    public class Organization : IOrganization
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        public IUser MainContact { get; set; }

        public List<IDog> Dogs { get; set; }

        private FetchEntities.FetchEntities _db = new FetchEntities.FetchEntities(); 

        public void Details(int id)
        {
            FetchEntities.Organization org = _db.Organizations.Find(id);

            Name = org.Name;
            Address = org.Address.Line1 + " " + org.Address.Line2 + " " + org.Address.City + ", " + org.Address.State +  " " + org.Address.Zip;
            Phone = org.Phone;
            EMail = org.Email;
            MainContact = DependencyResolver.Current.GetService<IUser>();
            MainContact.Load(org.MainContactId);
        }

        public void Create()
        {
            FetchEntities.Organization org = new FetchEntities.Organization()
            {
                Name = Name,
                Phone = Phone,
                Email = EMail,
            };

            _db.Organizations.Add(org);
            _db.SaveChanges();

        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }


        public void DownloadDogs()
        {
            throw new NotImplementedException();
        }

        public void LoadDogs()
        {
            throw new NotImplementedException();
        }
    }
}
