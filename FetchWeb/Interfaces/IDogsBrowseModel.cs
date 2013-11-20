using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FetchDomain.Interfaces;

namespace FetchWeb.Interfaces
{
    public interface IDogsBrowseModel
    {
        string Longitude { get; set; }
        string Latitude { get; set; }
        int Distance { get; set; }
        string FilterOptions { get; set; }
        int Offset { get; set; }


        List<IDog> FindDogs();
    }
}
