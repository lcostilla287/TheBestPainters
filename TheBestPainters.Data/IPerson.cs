using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data
{
    interface IPerson
    {
        int Id { get; set; }

        Guid OwnerId { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string FullName { get;}

        string PhoneNumber { get; set; }

        string StreetAddress { get; set; }

        string CityAddress { get; set; }

        string Email { get; set; }
    }
}
