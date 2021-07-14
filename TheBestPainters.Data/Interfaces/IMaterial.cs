using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data.Interfaces
{
    public interface IMaterial : IIdentification
    {
        int MaterialId { get; set; }
        int? JobId { get; set; }
        Job Job { get; set; }

        string MaterialName { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
        double TotalPrice { get; }
    }
}
