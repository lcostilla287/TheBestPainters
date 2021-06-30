using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.CrewModels
{
    public class CrewCreate
    {
        [Required]
        public string CrewName { get; set; }
    }
}
