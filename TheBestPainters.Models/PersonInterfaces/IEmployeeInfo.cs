using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.PersonInterfaces
{
    public interface IEmployeeInfo
    {
        int? CrewId { get; set; }
        bool IsCrewChief { get; set; }
    }
}
