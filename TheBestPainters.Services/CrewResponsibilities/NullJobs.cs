using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;

namespace TheBestPainters.Services.CrewResponsibilities
{
    public class NullJobs
    {
        public static void NullId(Crew entity)
        {
            foreach (var job in entity.Jobs)
            {
                job.CrewId = null;
            }
        }
    }
}
