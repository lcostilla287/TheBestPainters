using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.EmployeeModels;

namespace TheBestPainters.Services.EmployeeResponsibilities
{
    public class EmployeeQuery
    {
        public static IQueryable<EmployeeListItem> Query (ApplicationDbContext ctx, Guid _userId)
        {
            var query =
                    ctx
                    .Employees
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new EmployeeListItem
                            {
                                EmployeeId = e.EmployeeId,
                                FirstName = e.FirstName,
                                LastName = e.LastName,
                                CrewId = e.CrewId,
                                PhoneNumber = e.PhoneNumber,
                                IsCrewChief = e.IsCrewChief
                            }
                        );
            return query;
        }
    }
}
