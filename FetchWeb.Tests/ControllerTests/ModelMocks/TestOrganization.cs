using FetchDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchWeb.Tests
{
    public class TestOrganization : IOrganization
    {
        public const string ValidName = "Valid Org";

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        public IUser MainContact { get; set; }

        public List<IDog> Dogs { get; set; }

        public void Details(int id)
        {
            if (id == 0)
            {
                throw new Exception("User not found");
            }
            else
            {
                Name = ValidName;
                Address = "321 Main St";
                Phone = "321.321.3211";
                EMail = "ValidEmail";
            }
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
