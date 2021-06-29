using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.JobModels
{
    public class JobDetail
    {
        public int JobId { get; set; }

        public int? CustomerId { get; set; }
        //public string FullName { get; set; }

        public string JobLocation { get; set; }
        public string ScopeOfWork { get; set; }
        public bool Interior { get; set; }
        public bool Exterior { get; set; }
        public double Price { get; set; }
    }
}
