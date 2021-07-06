using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Controllers.MaterialResponsibilities
{
    public class EditMaterial
    {
        public static MaterialEdit EditView(MaterialDetail detail)
        {
            var model =
                new MaterialEdit
                {
                    MaterialId = detail.MaterialId,
                    MaterialName = detail.MaterialName,
                    JobId = detail.JobId,
                    Price = detail.Price,
                    Quantity = detail.Quantity
                };
            return model;
        }
    }
}