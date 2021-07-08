using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Data.Interfaces;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.JobResponsibilities
{
    public class JobDataCapture
    {
        public static IJob Capture(JobCreate model, Guid _userId)
        {
            var entity = InstantiateModels.MakeJob();

            entity.OwnerId = _userId;
            entity.JobLocation = model.JobLocation;
            entity.ScopeOfWork = model.ScopeOfWork;
            entity.Interior = model.Interior;
            entity.Exterior = model.Exterior;
            entity.Id = model.CustomerId;
            entity.Price = model.Price;
            entity.CrewId = model.CrewId;

            return entity;
        }
    }
}
