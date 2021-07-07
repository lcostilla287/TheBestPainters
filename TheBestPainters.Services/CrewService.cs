using System;
using System.Collections.Generic;
using System.Linq;
using TheBestPainters.Data;
using TheBestPainters.Models.CrewModels;
using TheBestPainters.Services.CrewResponsibilities;

namespace TheBestPainters.Services
{
    public class CrewService : ICrewService
    {
        private readonly Guid _userId;

        public CrewService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCrew(CrewCreate model)
        {
            var entity = CrewDataCapture.Capture(model, _userId);

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
                var query = CrewQuery.Query(ctx, _userId);
                    
                return query.ToArray();
            }
        }

        public CrewDetail GetCrewById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindCrew.GetCrew(ctx, id, _userId);

                return ReturnCrewData.CrewData(entity);
            }
        }

        public bool UpdateCrew(CrewEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindCrew.GetCrew(ctx, model.CrewId, _userId);
                    
                CrewUpdate.Update(model, entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCrew(int crewId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindCrew.GetCrew(ctx, crewId, _userId);
                   
                NullEmployees.Nullify(entity);
                NullJobs.NullId(entity);

                ctx.Crews.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
