using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.EmployeeModels;

namespace TheBestPainters.Controllers.EmployeeResponsibilities
{
    public class EditEmployee
    {
        public static EmployeeEdit EditView(EmployeeDetail detail)
        {
            var model =
               new EmployeeEdit
               {
                   Id = detail.Id,
                   FirstName = detail.FirstName,
                   LastName = detail.LastName,
                   CrewId = detail.CrewId,
                   IsCrewChief = detail.IsCrewChief,
                   StreetAddress = detail.StreetAddress,
                   CityAddress = detail.CityAddress,
                   PhoneNumber = detail.PhoneNumber,
                   Email = detail.Email
               };
            return model;
        }
    }
}