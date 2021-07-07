using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Services.JobResponsibilities
{
    public class JobQuery
    {
        public static IQueryable<JobListItem> Query(ApplicationDbContext ctx, Guid _userId)
        {
            var query =
                    ctx
                    .Jobs
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new JobListItem
                            {
                                JobId = e.JobId,
                                CustomerId = e.Id,
                                CrewId = e.CrewId,
                                JobLocation = e.JobLocation,
                                Interior = e.Interior,
                                Exterior = e.Exterior
                            }
                        );
            return query;
        }
    }
}
