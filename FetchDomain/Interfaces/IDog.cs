using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDomain.Interfaces
{
    public interface IDog
    {
        String Name { get; set; }
        String Breed { get; set; }
        String Description { get; set; }
        String Organization { get; set; }
        int OrganziationId { get; set; }


        void Details();

        void Create();

        void Update();

        void Hold();

        void Delete();

    }
}
