using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Models.CrewModels
{
    public class CrewDetail
    {
        public int CrewId { get; set; }
        public string CrewName { get; set; }
        public virtual List<JobListItem> Jobs { get; set; }
    }
}
