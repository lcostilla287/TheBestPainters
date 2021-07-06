using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data.Interfaces
{
    public interface ICrew
    {
        int CrewId { get; set; }
        Guid OwnerId { get; set; }
        string CrewName { get; set; }
        List<Job> Jobs { get; set; }
        List<Employee> Employees { get; set; }
    }
}
