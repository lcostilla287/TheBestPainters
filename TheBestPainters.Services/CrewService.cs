using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CrewModels;
using TheBestPainters.Models.EmployeeModels;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Services
{
    public class CrewService
    {
        private readonly Guid _userId;

        public CrewService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCrew(CrewCreate model)
        {
            var entity =
                new Crew()
                {
                    OwnerId = _userId,
                    CrewName = model.CrewName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Crews.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }
        public IEnumerable<CrewListItem> GetCrews()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Crews
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new CrewListItem
                            {
                                CrewId = e.CrewId,
                                CrewName = e.CrewName
                            }
                        );
                return query.ToArray();
            }
        }

        public CrewDetail GetCrewById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Crews
                        .Single(e => e.CrewId == id && e.OwnerId == _userId);

                return
                    new CrewDetail
                    {
                        CrewId = entity.CrewId,
                        CrewName = entity.CrewName,
                        Jobs = entity.Jobs
                        .Select(e => new JobListItem()
                        {
                            JobId = e.JobId,
                            JobLocation = e.JobLocation
                        }).ToList(),
                        Employees = entity.Employees
                        .Select(e => new EmployeeListItem()
                        {
                            EmployeeId = e.EmployeeId,
                            FirstName = e.FirstName,
                            LastName = e.LastName
                        }).ToList()
                        
                    };
            }
        }

        public bool UpdateCrew(CrewEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Crews
                        .Single(e => e.CrewId == model.CrewId && e.OwnerId == _userId);

                entity.CrewName = model.CrewName;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCrew(int crewId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Crews
                        .Single(e => e.CrewId == crewId && e.OwnerId == _userId);

                foreach(var employee in entity.Employees)
                {
                    employee.CrewId = null;
                }
                foreach(var job in entity.Jobs)
                {
                    job.CrewId = null;
                }

                ctx.Crews.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
