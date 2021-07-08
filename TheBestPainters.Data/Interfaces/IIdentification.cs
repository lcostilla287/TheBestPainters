using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data.Interfaces
{
    public interface IIdentification
    {
        Guid OwnerId { get; set; }
    }
}
