using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data
{
    public interface IEmployee : IPerson
    {
        int EmployeeId { get; set; }
        int? CrewId { get; set; }
        Crew Crew { get; set; }
        bool IsCrewChief { get; set; }
        DateTimeOffset DateHired { get; set; }
    }
}
