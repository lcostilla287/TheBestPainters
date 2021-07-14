using System;
using System.Collections.Generic;
using System.Linq;
using TheBestPainters.Data;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Services.JobResponsibilities;

namespace TheBestPainters.Services
{
    public class JobService : IJobService
    {
        private readonly Guid _userId;

        public JobService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateJob(JobCreate model)
        {
            var entity = JobDataCapture.Capture(model, _userId);

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Jobs.Add((Job)entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<JobListItem> GetJobs()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = JobQuery.Query(ctx, _userId);

                return query.ToArray();
            }
        }

        public JobDetail GetJobById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindJob.GetJob(ctx, id, _userId);

                return (JobDetail)ReturnJobData.JobData(entity);
            }
        }

        public bool UpdateJob(JobEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindJob.GetJob(ctx, model.JobId, _userId);

                JobUpdate.Update(model, entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteJob(int jobId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindJob.GetJob(ctx, jobId, _userId);

                NullMaterials.Nullify(entity);

                ctx.Jobs.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
