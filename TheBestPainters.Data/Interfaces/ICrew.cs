using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data.Interfaces
{
    public interface ICrew : IIdentification
    {
        string CrewName { get; set; }
        List<Job> Jobs { get; set; }
        List<IEmployee> Employees { get; set; }
    }
}
