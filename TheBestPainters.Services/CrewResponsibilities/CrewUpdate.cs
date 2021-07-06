using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CrewModels;

namespace TheBestPainters.Services.CrewResponsibilities
{
    public class CrewUpdate
    {
        public static void Update(CrewEdit model, Crew entity)
        {
            entity.CrewName = model.CrewName;
        }
    }
}
