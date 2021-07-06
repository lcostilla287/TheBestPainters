using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Services.MaterialResponsibilities
{
    public class MaterialDataCapture
    {
        public static Material Capture(MaterialCreate model, Guid _userId)
        {
            var entity =
                new Material()
                {
                    OwnerId = _userId,
                    MaterialName = model.MaterialName,
                    Price = model.Price,
                    Quantity = model.Quantity,
                    JobId = model.JobId
                };
            return entity;

        }
    }
}
