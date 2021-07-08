using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.MaterialInterfaces;

namespace TheBestPainters.Models.MaterialModels
{
    public class MaterialCreate : IMaterialCreate
    {
        public int? JobId { get; set; }

        [Required]
        public string MaterialName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }

    }
}
