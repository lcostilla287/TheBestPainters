using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.JobModels
{
    public class JobListItem
    {
        public int JobId { get; set; }
        public int? CustomerId { get; set; }
        public int? CrewId { get; set; }
        public string JobLocation { get; set; }
        public bool Interior { get; set; }
        public bool Exterior { get; set; }
    }
}
