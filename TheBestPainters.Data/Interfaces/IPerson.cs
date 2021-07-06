using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data.Interfaces;

namespace TheBestPainters.Data
{
    public interface IPerson : IIdentification
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get;}

        string PhoneNumber { get; set; }

        string StreetAddress { get; set; }

        string CityAddress { get; set; }

        string Email { get; set; }
    }
}
