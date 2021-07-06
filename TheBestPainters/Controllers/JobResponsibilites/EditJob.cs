using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Controllers.JobResponsibilites
{
    public class EditJob
    {
        public static JobEdit EditView(JobDetail detail)
        {
            var model =
                new JobEdit
                {
                    JobId = detail.JobId,
                    CustomerId = detail.CustomerId,
                    CrewId = detail.CrewId,
                    JobLocation = detail.JobLocation,
                    ScopeOfWork = detail.ScopeOfWork,
                    Interior = detail.Interior,
                    Exterior = detail.Exterior,
                    Price = detail.Price
                };
            return model;
        }
    }
}