using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;

namespace TheBestPainters.Services.CrewResponsibilities
{
    public class FindCrew
    {
        public static Crew GetCrew(ApplicationDbContext ctx, int id, Guid _userId)
        {
            var entity =
                    ctx
                        .Crews
                        .Single(e => e.CrewId == id && e.OwnerId == _userId);
            return entity;
        }
    }
}
