using System.Collections.Generic;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Services
{
    public interface IJobService
    {
        bool CreateJob(JobCreate model);
        bool DeleteJob(int jobId);
        JobDetail GetJobById(int id);
        IEnumerable<JobListItem> GetJobs();
        bool UpdateJob(JobEdit model);
    }
}