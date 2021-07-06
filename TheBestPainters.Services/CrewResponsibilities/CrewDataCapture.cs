using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CrewModels;

namespace TheBestPainters.Services.CrewResponsibilities
{
    public class CrewDataCapture
    {
        public static Crew Capture(CrewCreate model, Guid _userId)
        {
            var entity =
               new Crew()
               {
                   OwnerId = _userId,
                   CrewName = model.CrewName
               };
            return entity;
        }
    }
}
