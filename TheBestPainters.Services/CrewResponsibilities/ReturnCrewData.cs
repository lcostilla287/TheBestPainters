using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CrewModels;
using TheBestPainters.Models.EmployeeModels;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Services.CrewResponsibilities
{
    public class ReturnCrewData
    {
        public static CrewDetail CrewData(Crew entity)
        {
            return
                    new CrewDetail
                    {
                        CrewId = entity.CrewId,
                        CrewName = entity.CrewName,
                        Jobs = entity.Jobs
                        .Select(e => new JobListItem()
                        {
                            JobId = e.JobId,
                            JobLocation = e.JobLocation
                        }).ToList(),
                        Employees = entity.Employees
                        .Select(e => new EmployeeListItem()
                        {
                            EmployeeId = e.EmployeeId,
                            FirstName = e.FirstName,
                            LastName = e.LastName
                        }).ToList()
                    };
        }
    }
}
