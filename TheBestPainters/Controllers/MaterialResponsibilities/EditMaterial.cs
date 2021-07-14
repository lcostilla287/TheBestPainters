using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.MaterialInterfaces;
using TheBestPainters.Models.MaterialModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Controllers.MaterialResponsibilities
{
    public class EditMaterial
    {
        public static IMaterialEdit EditView(MaterialDetail detail)
        {
            var model = InstantiateModels.MaterialEdit();

            model.MaterialId = detail.MaterialId;
            model.MaterialName = detail.MaterialName;
            model.JobId = detail.JobId;
            model.Price = detail.Price;
            model.Quantity = detail.Quantity;

            return model;
        }
    }
}