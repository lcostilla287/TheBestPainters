using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.JobInterfaces;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Controllers.JobResponsibilites
{
    public class EditJob
    {
        public static IJobEdit EditView(JobDetail detail)
        {
            var model = InstantiateModels.JobEdit();

            model.JobId = detail.JobId;
            model.CustomerId = detail.CustomerId;
            model.CrewId = detail.CrewId;
            model.JobLocation = detail.JobLocation;
            model.ScopeOfWork = detail.ScopeOfWork;
            model.Interior = detail.Interior;
            model.Exterior = detail.Exterior;
            model.Price = detail.Price;

            return model;
        }
    }
}