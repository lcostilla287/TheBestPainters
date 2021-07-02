using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;

namespace TheBestPainters.Services.CustomerResponsibilities
{
    public class NullJobs
    {
        public static void Nullify(Customer entity)
        {
            foreach (var job in entity.Jobs)
            {
                job.CustomerId = null;
            }
        }
    }
}
