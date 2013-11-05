using FetchDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDomain.Objects
{
    public class Organization : IOrganization
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        public string MainContact { get; set; }

        public List<IDog> Dogs { get; set; }

        private FetchEntities.FetchEntities _db = new FetchEntities.FetchEntities(); 

        public void Details(int id)
        {
            FetchEntities.Organization org = _db.Organizations.Find(id);

            Name = org.Name;
            Address = org.Address.Line1 + " " + org.Address.Line2 + " " + org.Address.City + ", " + org.Address.State +  " " + org.Address.Zip;
            Phone = org.Phone;
            EMail = org.Email;
            MainContact = org.User.FirstName + " " + org.User.LastName;
        }

        public void Create()
        {
            string[] mainContactSplit = MainContact.Split(' ');
            string firstName = mainContactSplit[0];
            FetchEntities.User mainContact = new FetchEntities.User() { 
                FirstName = mainContactSplit[0],
                LastName = mainContactSplit[1],
            };

            FetchEntities.Organization org = new FetchEntities.Organization()
            {
                Name = Name,
                Phone = Phone,
                Email = EMail,
            };

            org.User = mainContact;
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
