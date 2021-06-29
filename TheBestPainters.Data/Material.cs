using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Data
{
    public class Material
    {
        [Key]
        public int MaterialId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }

        [ForeignKey(nameof(Job))]
        public int? JobId { get; set; }
        public virtual Job Job { get; set; }

        [Required]
        public string MaterialName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public double TotalPrice 
        {
            get
            {
                return (Price * Quantity);
            } 
        }
    }
}
