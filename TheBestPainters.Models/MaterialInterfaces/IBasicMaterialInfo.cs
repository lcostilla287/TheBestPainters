using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.MaterialInterfaces
{
    public interface IBasicMaterialInfo
    {
        int? JobId { get; set; }
        string MaterialName { get; set; }
        int Quantity { get; set; }
    }
}
