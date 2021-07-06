using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data
{
    public interface ICustomer
    {
        List<Job> Jobs { get; set; }
    }
}
