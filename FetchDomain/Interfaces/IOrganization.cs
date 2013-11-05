using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDomain.Interfaces
{
    public interface IOrganization
    {
        String Name { get; set; }
        String Address { get; set; }
        String Phone { get; set; }
        String EMail { get; set; }
        String MainContact { get; set; }
        List<IDog> Dogs { get; set; }

        void Details(int id);

        void Create();

        void Edit();

        void Delete();

        void DownloadDogs();

        void LoadDogs();
    }
}
