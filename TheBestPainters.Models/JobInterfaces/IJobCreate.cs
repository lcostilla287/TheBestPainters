using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TheBestPainters.Models.JobInterfaces
{
    public interface IJobCreate : IBasicJobInfo, IPriceAndScope
    {
        SelectList Crews { get; set; }
    }
}
