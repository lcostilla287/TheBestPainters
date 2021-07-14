using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.EmployeeInterfaces;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.EmployeeResponsibilities
{
    public class EmployeeData
    {
        public static IEmployeeDetail Return(IEmployee entity)
        {
            var emp = InstantiateModels.EmployeeDetail();

            emp.EmployeeId = entity.EmployeeId;
            emp.CrewId = entity.CrewId;
            emp.FirstName = entity.FirstName;
            emp.LastName = entity.LastName;
            emp.StreetAddress = entity.StreetAddress;
            emp.CityAddress = entity.CityAddress;
            emp.PhoneNumber = entity.PhoneNumber;
            emp.Email = entity.Email;
            emp.DateHired = entity.DateHired;
            emp.IsCrewChief = entity.IsCrewChief;

            return emp;
        }
    }
}
