using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.PersonInterfaces
{
    public interface IContactInfo
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string PhoneNumber { get; set; }
    }
}
