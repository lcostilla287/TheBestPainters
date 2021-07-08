using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.PersonInterfaces
{
    public interface IAddresses
    {
        string StreetAddress { get; set; }

        string CityAddress { get; set; }

        string Email { get; set; }
    }
}
