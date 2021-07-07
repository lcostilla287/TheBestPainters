using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.EmployeeModels;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Models.CrewInterfaces
{
    public interface ICrewDetail : ICrewId, ICrewName
    {
        List<JobListItem> Jobs { get; set; }
        List<EmployeeListItem> Employees { get; set; }
    }
}
