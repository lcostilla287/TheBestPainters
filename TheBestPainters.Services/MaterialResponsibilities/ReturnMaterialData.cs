using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Services.MaterialResponsibilities
{
    public class ReturnMaterialData
    {
        public static MaterialDetail MaterialData(Material entity)
        {
            return
                    new MaterialDetail
                    {
                        MaterialId = entity.MaterialId,
                        JobId = entity.JobId,
                        MaterialName = entity.MaterialName,
                        Price = entity.Price,
                        Quantity = entity.Quantity,
                        TotalPrice = entity.TotalPrice
                    };
        }
    }
}
