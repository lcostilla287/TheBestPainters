using System.Linq;
using TheBestPainters.Data;
using TheBestPainters.Models.JobInterfaces;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Models.MaterialModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.JobResponsibilities
{
    public class ReturnJobData
    {
        public static IJobDetail JobData(Job entity)
        {
            var job = InstantiateModels.JobDetail();

            job.JobId = entity.JobId;
            job.CustomerId = entity.Id;
            job.CrewId = entity.CrewId;
            job.ScopeOfWork = entity.ScopeOfWork;
            job.JobLocation = entity.JobLocation;
            job.Interior = entity.Interior;
            job.Exterior = entity.Exterior;
            job.Price = entity.Price;
            job.Materials = entity.Materials
            .Select(e => new MaterialListItem()
            {
                MaterialId = e.MaterialId,
                MaterialName = e.MaterialName,
                Quantity = e.Quantity
            }).ToList();

            return job;
        }
    }
}
