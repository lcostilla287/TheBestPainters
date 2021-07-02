using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;

namespace TheBestPainters.Services.CrewResponsibilities
{
    public class NullEmployees
    {
        public static void Nullify(Crew entity)
        {
            foreach (var employee in entity.Employees)
            {
                employee.CrewId = null;
            }
        }
    }
}
