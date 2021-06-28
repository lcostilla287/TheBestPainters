using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.JobModels
{
    public class JobCreate
    {
        [Required]
        public int? CustomerId { get; set; }
        [Required]
        public string JobLocation { get; set; }
        [Required]
        public string ScopeOfWork { get; set; }
        public bool Interior { get; set; }
        public bool Exterior { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
