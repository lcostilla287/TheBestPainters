using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CrewModels;

namespace TheBestPainters.Services.CrewResponsibilities
{
    public class CrewQuery
    {
        public static IQueryable<CrewListItem> Query(ApplicationDbContext ctx, Guid _userId)
        {
            var query =
                    ctx
                    .Crews
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new CrewListItem
                            {
                                CrewId = e.CrewId,
                                CrewName = e.CrewName
                            }
                        );
            return query;
        }
    }
}
