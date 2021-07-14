using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data.Interfaces;

namespace TheBestPainters.Data
{
    public interface ICustomer : IPerson, IIdentification
    {
        int CustomerId { get; set; }
        List<Job> Jobs { get; set; }
    }
}
