using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.CrewInterfaces;
using TheBestPainters.Models.CrewModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Controllers.CrewResponsibilities
{
    public class EditCrew
    {
        public static ICrewEdit EditView(CrewDetail detail)
        {
            var model = InstantiateModels.CrewEdit();

            model.CrewId = detail.CrewId;
            model.CrewName = detail.CrewName;

            return model;
        }
    }
}