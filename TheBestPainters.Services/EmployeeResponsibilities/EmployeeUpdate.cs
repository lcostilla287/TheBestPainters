using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.EmployeeModels;

namespace TheBestPainters.Services.EmployeeResponsibilities
{
    public class EmployeeUpdate
    {
        public static void Update(IEmployee entity, EmployeeEdit model)
        {
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.StreetAddress = model.StreetAddress;
            entity.CityAddress = model.CityAddress;
            entity.CrewId = model.CrewId;
            entity.PhoneNumber = model.PhoneNumber;
            entity.Email = model.Email;
            entity.IsCrewChief = model.IsCrewChief;
        }
    }
}
