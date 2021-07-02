using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;

namespace TheBestPainters.Services.MaterialResponsibilities
{
    public class FindMaterial
    {
        public static Material GetMaterial(ApplicationDbContext ctx, int id, Guid _userId)
        {
            var entity =
                    ctx
                        .Materials
                        .Single(e => e.MaterialId == id && e.OwnerId == _userId);
            return entity;
        }
    }
}
