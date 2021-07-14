using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Models.JobInterfaces
{
    public interface IJobDetail : IJobId, IBasicJobInfo, IPriceAndScope
    {
        List<MaterialListItem> Materials { get; set; }
    }
}
