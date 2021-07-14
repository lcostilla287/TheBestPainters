using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;

namespace TheBestPainters.Services.JobResponsibilities
{
    public class FindJob
    {
        public static Job GetJob(ApplicationDbContext ctx, int id, Guid _userId)
        {
            var entity =
                    ctx
                        .Jobs
                        .Single(e => e.JobId == id && e.OwnerId == _userId);
            return entity;
        }
    }
}
