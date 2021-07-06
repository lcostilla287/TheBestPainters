using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.CrewModels;

namespace TheBestPainters.Controllers.CrewResponsibilities
{
    public class EditCrew
    {
        public static CrewEdit EditView(CrewDetail detail)
        {
            var model =
                new CrewEdit
                {
                    CrewId = detail.CrewId,
                    CrewName = detail.CrewName
                };
            return model;
        }
    }
}