using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FetchEntities.Repositories;

namespace FetchDomain.Services
{
    public class OrganizationServices : BaseService
    {
        public void Create(string Name, string Phone, string Email, string AddrLine1, string AddrLine2, string City, string State, string Zip, string FirstName, string LastName, string ContactEmail, string ContactPhone)
        {
            //TODO: Remove dependency
            DatabaseRepository repo = new DatabaseRepository();            
            repo.CreateOrganziation(Name, Phone, Email, AddrLine1, AddrLine2, City, State, Zip, FirstName, LastName, ContactEmail, ContactPhone);
        }
    }
}
