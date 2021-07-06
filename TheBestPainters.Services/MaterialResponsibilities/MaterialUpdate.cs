using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Services.MaterialResponsibilities
{
    public class MaterialUpdate
    {
        public static void Update(MaterialEdit model, Material entity)
        {
            entity.MaterialName = model.MaterialName;
            entity.JobId = model.JobId;
            entity.Price = model.Price;
            entity.Quantity = model.Quantity;
        }
    }
}
