using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data
{
    interface ICustomer
    {
        List<Job> Jobs { get; set; }
    }
}
