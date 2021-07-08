using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.JobInterfaces
{
    public interface IPriceAndScope
    {
        string ScopeOfWork { get; set; }
        double Price { get; set; }
    }
}
