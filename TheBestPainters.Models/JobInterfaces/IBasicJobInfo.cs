using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.JobInterfaces
{
    public interface IBasicJobInfo
    {
        int? CustomerId { get; set; }
        int? CrewId { get; set; }
        string JobLocation { get; set; }
        bool Interior { get; set; }
        bool Exterior { get; set; }
    }
}
