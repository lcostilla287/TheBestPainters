using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.CrewModels;

namespace TheBestPainters.Services
{
    public interface ICrewService
    {
        bool CreateCrew(CrewCreate model);
        IEnumerable<CrewListItem> GetCrews();
        CrewDetail GetCrewById(int id);
        bool UpdateCrew(CrewEdit model);
        bool DeleteCrew(int crewId);
    }
}
