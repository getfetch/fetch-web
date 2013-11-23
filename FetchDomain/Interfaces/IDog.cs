using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDomain.Interfaces
{
    public interface IDog
    {
        int Id { get; set; }
        String Name { get; set; }
        String Breed { get; set; }
        String Description { get; set; }
        String Organization { get; set; }
        String Sex { get; set; }
        String Size { get; set; }
        String Age { get; set; }
        Boolean AtRisk { get; set; }
        int OrganziationId { get; set; }
        string Status { get; set; }


        void Details();

        void Create();

        void Update();

        void Hold();

        void Delete();

    }
}
