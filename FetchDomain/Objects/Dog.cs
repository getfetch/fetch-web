using FetchDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDomain.Objects
{
    public class Dog : IDog
    {
        public string Name { get; set; }

        public string Breed { get; set; }

        public string Description { get; set; }

        public string Organization { get; set; }

        public int OrganziationId { get; set; }

        public int Id { get; set; }
        
        public string Sex { get; set; }
        
        public string Size { get; set; }
        public string Age { get; set; }

        public Boolean AtRisk { get; set; }
        public String Status { get; set; }

        public void Details()
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Hold()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
