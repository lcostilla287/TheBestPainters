using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Services.JobResponsibilities
{
    public class JobUpdate
    {
        public static void Update(JobEdit model, Job entity)
        {
            entity.JobLocation = model.JobLocation;
            entity.CustomerId = model.CustomerId;
            entity.CrewId = model.CrewId;
            entity.ScopeOfWork = model.ScopeOfWork;
            entity.Interior = model.Interior;
            entity.Exterior = model.Exterior;
            entity.Price = model.Price;
        }
    }
}
