using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Data.Interfaces;
using TheBestPainters.Models.MaterialModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.MaterialResponsibilities
{
    public class MaterialDataCapture
    {
        public static IMaterial Capture(MaterialCreate model, Guid _userId)
        {
            var entity = InstantiateModels.MakeMaterial();

            entity.OwnerId = _userId;
            entity.MaterialName = model.MaterialName;
            entity.Price = model.Price;
            entity.Quantity = model.Quantity;
            entity.JobId = model.JobId;
                
            return entity;

        }
    }
}
