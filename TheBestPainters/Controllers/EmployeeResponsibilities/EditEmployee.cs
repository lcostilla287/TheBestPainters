using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.EmployeeInterfaces;
using TheBestPainters.Models.EmployeeModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Controllers.EmployeeResponsibilities
{
    public class EditEmployee
    {
        public static IEmployeeEdit EditView(EmployeeDetail detail)
        {
            var model = InstantiateModels.EmployeeEdit();

            model.EmployeeId = detail.EmployeeId;
            model.FirstName = detail.FirstName;
            model.LastName = detail.LastName;
            model.CrewId = detail.CrewId;
            model.IsCrewChief = detail.IsCrewChief;
            model.StreetAddress = detail.StreetAddress;
            model.CityAddress = detail.CityAddress;
            model.PhoneNumber = detail.PhoneNumber;
            model.Email = detail.Email;

            return model;
        }
    }
}