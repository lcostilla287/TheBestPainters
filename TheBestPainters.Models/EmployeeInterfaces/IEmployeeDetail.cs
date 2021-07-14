using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.PersonInterfaces;

namespace TheBestPainters.Models.EmployeeInterfaces
{
    public interface IEmployeeDetail : IEmployeeInfo, IContactInfo, IAddresses, IEmployeeId
    {
        DateTimeOffset DateHired { get; set; }
    }
}
