using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CrewInterfaces;
using TheBestPainters.Models.CrewModels;
using TheBestPainters.Models.EmployeeModels;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.CrewResponsibilities
{
    public class ReturnCrewData
    {
        public static ICrewDetail CrewData(Crew entity)
        {
            var crew = InstantiateModels.CrewDetail();
            //return
            //new CrewDetail
            //{
            crew.CrewId = entity.CrewId;
            crew.CrewName = entity.CrewName;
            crew.Jobs = entity.Jobs
                        .Select(e => new JobListItem()
                        {
                            JobId = e.JobId,
                            JobLocation = e.JobLocation
                        }).ToList();

            crew.Employees = entity.Employees
            .Select(e => new EmployeeListItem()
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName
            }).ToList();

            return crew;
        }
    }
}
