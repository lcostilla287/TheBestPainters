using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.MaterialInterfaces;
using TheBestPainters.Models.MaterialModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.MaterialResponsibilities
{
    public class ReturnMaterialData
    {
        public static IMaterialDetail MaterialData(Material entity)
        {
            var mat = InstantiateModels.MaterialDetail();
            //return
            //new MaterialDetail
            //{
            mat.MaterialId = entity.MaterialId;
            mat.JobId = entity.JobId;
            mat.MaterialName = entity.MaterialName;
            mat.Price = entity.Price;
            mat.Quantity = entity.Quantity;
            mat.TotalPrice = entity.TotalPrice;

            return mat;
        }
    }
}
