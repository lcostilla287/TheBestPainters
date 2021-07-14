using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.JobInterfaces;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Models.JobModels
{
    public class JobDetail : IJobDetail
    {
        public int JobId { get; set; }

        public int? CustomerId { get; set; }
        public int? CrewId { get; set; }

        public string JobLocation { get; set; }
        public string ScopeOfWork { get; set; }
        public bool Interior { get; set; }
        public bool Exterior { get; set; }
        public double Price { get; set; }

        public virtual List<MaterialListItem> Materials { get; set; }
    }
}
