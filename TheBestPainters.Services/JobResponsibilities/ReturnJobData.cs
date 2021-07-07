using System.Linq;
using TheBestPainters.Data;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Services.JobResponsibilities
{
    public class ReturnJobData
    {
        public static JobDetail JobData(Job entity)
        {
            return
                    new JobDetail
                    {
                        JobId = entity.JobId,
                        CustomerId = entity.Id,
                        CrewId = entity.CrewId,
                        ScopeOfWork = entity.ScopeOfWork,
                        JobLocation = entity.JobLocation,
                        Interior = entity.Interior,
                        Exterior = entity.Exterior,
                        Price = entity.Price,
                        Materials = entity.Materials
                        .Select(e => new MaterialListItem()
                        {
                            MaterialId = e.MaterialId,
                            MaterialName = e.MaterialName,
                            Quantity = e.Quantity
                        }).ToList()
                    };
        }
    }
}
