using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TheBestPainters.Models.PersonInterfaces;

namespace TheBestPainters.Models.EmployeeInterfaces
{
    public interface IEmployeeCreate : IEmployeeInfo, IContactInfo, IAddresses
    {
        SelectList Crews { get; set; }
    }
}
