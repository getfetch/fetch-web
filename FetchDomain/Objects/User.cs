using FetchDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDomain.Objects
{
    public class User : IUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        private FetchEntities.FetchEntities _db = new FetchEntities.FetchEntities(); 

        public void Load(int id)
        {
            var user = _db.Users.Find(id);
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Phone = user.Phone;
        }

    }
}
