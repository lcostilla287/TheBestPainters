using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.MaterialModels
{
    public class MaterialEdit
    {
        [Required]
        public int MaterialId { get; set; }
        public int? JobId { get; set; }

        [Required]
        public string MaterialName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
