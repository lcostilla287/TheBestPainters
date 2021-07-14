using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.CrewInterfaces;

namespace TheBestPainters.Models.CrewModels
{
    public class CrewListItem : ICrewListItem
    {
        public int CrewId { get; set; }
        public string CrewName { get; set; }
    }
}
