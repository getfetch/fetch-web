using FetchDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchWeb.Tests
{
    public class TestUser : IUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public void Load(int id)
        {
            if (id == 0)
            {

            }
            else
            {
                FirstName = "Chris";
                LastName = "Wargula";
                Email = "Chris@GetFetch.co";
                Phone = "321.321.3211";
            }
        }
    }
}
