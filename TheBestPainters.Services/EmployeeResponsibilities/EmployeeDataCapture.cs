using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.EmployeeModels;

namespace TheBestPainters.Services.EmployeeResponsibilities
{
    public class EmployeeDataCapture
    {
        public static Employee Capture(EmployeeCreate model, Guid _userId)
        {
            var entity =
                new Employee()
                {
                    OwnerId = _userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    CrewId = model.CrewId,
                    StreetAddress = model.StreetAddress,
                    CityAddress = model.CityAddress,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    IsCrewChief = model.IsCrewChief,
                    DateHired = DateTimeOffset.Now
                };
            return entity;
        }
    }
}
