using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Services
{
    public class JobService
    {
        private readonly Guid _userId;

        public JobService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateJob(JobCreate model)
        {
            var entity =
                new Job()
                {
                    OwnerId = _userId,
                    JobLocation = model.JobLocation,
                    ScopeOfWork = model.ScopeOfWork,
                    Interior = model.Interior,
                    Exterior = model.Exterior,
                    CustomerId = model.CustomerId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Jobs.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<JobListItem> GetJobs()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Jobs
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new JobListItem
                            {
                                JobId = e.JobId,
                                CustomerId = e.CustomerId,
                                JobLocation = e.JobLocation,
                                Interior = e.Interior,
                                Exterior = e.Exterior
                            }
                        );
                return query.ToArray();
            }
        }

        public JobDetail GetJobById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Jobs
                        .Single(e => e.JobId == id && e.OwnerId == _userId);
                return
                    new JobDetail
                    {
                        JobId = entity.JobId,
                        CustomerId = entity.CustomerId,
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

        public bool UpdateJob(JobEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Jobs
                        .Single(e => e.JobId == model.JobId && e.OwnerId == _userId);

                entity.JobLocation = model.JobLocation;
                entity.CustomerId = model.CustomerId;
                entity.ScopeOfWork = model.ScopeOfWork;
                entity.Interior = model.Interior;
                entity.Exterior = model.Exterior;
                entity.Price = model.Price;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteJob(int jobId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Jobs
                        .Single(e => e.JobId == jobId && e.OwnerId == _userId);

                ctx.Jobs.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
