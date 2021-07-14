using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.EmployeeModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.EmployeeResponsibilities
{
    public class EmployeeDataCapture
    {
        public static IEmployee Capture(EmployeeCreate model, Guid _userId)
        {
            var entity = InstantiateModels.MakeEmployee();

            entity.OwnerId = _userId;
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.CrewId = model.CrewId;
            entity.StreetAddress = model.StreetAddress;
            entity.CityAddress = model.CityAddress;
            entity.PhoneNumber = model.PhoneNumber;
            entity.Email = model.Email;
            entity.IsCrewChief = model.IsCrewChief;
            entity.DateHired = DateTimeOffset.Now;
            return entity;
        }
    }
}
