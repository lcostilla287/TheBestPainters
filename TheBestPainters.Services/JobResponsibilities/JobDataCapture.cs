using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Services.JobResponsibilities
{
    public class JobDataCapture
    {
        public static Job Capture(JobCreate model, Guid _userId)
        {
            var entity =
            new Job()
            {
                OwnerId = _userId,
                JobLocation = model.JobLocation,
                ScopeOfWork = model.ScopeOfWork,
                Interior = model.Interior,
                Exterior = model.Exterior,
                Id = model.CustomerId,
                Price = model.Price,
                CrewId = model.CrewId
            };
            return entity;
        }
    }
}
