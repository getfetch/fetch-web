using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects
{
    public class Organization : IOrganization
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        public string MainContact { get; set; }

        public List<IDog> Dogs { get; set; }

        public void Details(int id)
        {
            Name = "Beagle Rescue of America";
            Address = "3025 Belleville St, Pittsburgh PA";
            Phone = "321.321.3211";
            EMail = "test@test.com";
            MainContact = "Paul Bunyan";
        }

        public void Create()
        {
            throw new NotImplementedException();
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
