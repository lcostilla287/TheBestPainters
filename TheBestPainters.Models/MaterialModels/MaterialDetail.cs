using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.MaterialModels
{
    public class MaterialDetail
    {
        public int MaterialId { get; set; }
        public int? JobId { get; set; }
        public string MaterialName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
