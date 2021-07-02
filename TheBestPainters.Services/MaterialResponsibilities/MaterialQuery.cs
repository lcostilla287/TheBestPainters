using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Services.MaterialResponsibilities
{
    public class MaterialQuery
    {
        public static IQueryable<MaterialListItem> Query(ApplicationDbContext ctx, Guid _userId)
        {
            var query =
                    ctx
                    .Materials
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                            new MaterialListItem
                            {
                                MaterialId = e.MaterialId,
                                JobId = e.JobId,
                                MaterialName = e.MaterialName,
                                Quantity = e.Quantity
                            }
                        );
            return query;
        }
    }
}
