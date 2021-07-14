using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Data.Interfaces;
using TheBestPainters.Models.CrewModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.CrewResponsibilities
{
    public class CrewDataCapture
    {
        public static ICrew Capture(CrewCreate model, Guid _userId)
        {
            var entity = InstantiateModels.MakeCrew();

            entity.OwnerId = _userId;
            entity.CrewName = model.CrewName;

            return entity;
        }
    }
}
