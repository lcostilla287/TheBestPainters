using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.EmployeeModels;

namespace TheBestPainters.Services.EmployeeResponsibilities
{
    public class EmployeeData
    {
        public static EmployeeDetail Return(Employee entity)
        {
            return
                    new EmployeeDetail
                    {
                        EmployeeId = entity.EmployeeId,
                        CrewId = entity.CrewId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        StreetAddress = entity.StreetAddress,
                        CityAddress = entity.CityAddress,
                        PhoneNumber = entity.PhoneNumber,
                        Email = entity.Email,
                        DateHired = entity.DateHired,
                        IsCrewChief = entity.IsCrewChief
                    };
        }
    }
}
