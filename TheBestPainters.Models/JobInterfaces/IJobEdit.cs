using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.JobInterfaces
{
    public interface IJobEdit : IJobId, IBasicJobInfo, IPriceAndScope
    {
    }
}
