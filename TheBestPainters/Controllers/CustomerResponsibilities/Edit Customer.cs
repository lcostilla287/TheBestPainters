using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.CustomerModels;

namespace TheBestPainters.Controllers.CustomerResponsibilities
{
    public class Edit_Customer
    {
        public static CustomerEdit EditView(CustomerDetail detail)
        {
            var model =
            new CustomerEdit
            {
                CustomerId = detail.CustomerId,
                FirstName = detail.FirstName,
                LastName = detail.LastName,
                PhoneNumber = detail.PhoneNumber,
                StreetAddress = detail.StreetAddress,
                CityAddress = detail.CityAddress,
                Email = detail.Email
            };
            return model;
        }
    }
}