using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data
{
    public class Crew
    {
        public int CrewId { get; set; }
        public string CrewName { get; set; }
        public virtual List<Job> Jobs { get; set; } = new List<Job>();
    }
}
