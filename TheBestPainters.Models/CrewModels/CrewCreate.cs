using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.CrewInterfaces;

namespace TheBestPainters.Models.CrewModels
{
    public class CrewCreate : ICrewCreate
    {
        [Required]
        public string CrewName { get; set; }
    }
}
