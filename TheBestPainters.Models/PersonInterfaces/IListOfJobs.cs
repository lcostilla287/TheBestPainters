using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Models.PersonInterfaces
{
    public interface IListOfJobs
    {
        List<JobListItem> Jobs { get; set; }
    }
}
