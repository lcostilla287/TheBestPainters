using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;

namespace TheBestPainters.Services.EmployeeResponsibilities
{
    public class FindEmployee
    {
        public static Employee GetEmployee(ApplicationDbContext ctx, int id, Guid _userId)
        {
            var entity =
                    ctx
                        .Employees
                        .Single(e => e.EmployeeId == id && e.OwnerId == _userId);
            return entity;
        }
    }
}
