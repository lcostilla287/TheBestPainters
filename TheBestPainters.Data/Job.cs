using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [ForeignKey(nameof(Customer))]
        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

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
