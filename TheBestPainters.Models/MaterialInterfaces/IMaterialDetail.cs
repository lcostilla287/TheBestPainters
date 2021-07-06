using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.MaterialInterfaces
{
    public interface IMaterialDetail : IBasicMaterialInfo, IPrice, ITotalPrice, IMaterialId
    {
    }
}
