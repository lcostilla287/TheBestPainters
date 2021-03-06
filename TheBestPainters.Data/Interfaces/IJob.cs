using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data.Interfaces
{
    public interface IJob : IIdentification
    {
        int JobId { get; set; }

        int? CustomerId { get; set; }
        Customer Customer { get; set; }

        int? CrewId { get; set; }
        Crew Crew { get; set; }

        string JobLocation { get; set; }
        string ScopeOfWork { get; set; }

        bool Interior { get; set; }

        bool Exterior { get; set; }
        double Price { get; set; }

        List<Material> Materials { get; set; }
    }
}
