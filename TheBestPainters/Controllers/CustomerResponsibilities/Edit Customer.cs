using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Models.CustomerInterfaces;
using TheBestPainters.Models.CustomerModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Controllers.CustomerResponsibilities
{
    public class Edit_Customer
    {
        public static ICustomerEdit EditView(CustomerDetail detail)
        {
            var model = InstantiateModels.CustomerEdit();

            model.CustomerId = detail.CustomerId;
            model.FirstName = detail.FirstName;
            model.LastName = detail.LastName;
            model.PhoneNumber = detail.PhoneNumber;
            model.StreetAddress = detail.StreetAddress;
            model.CityAddress = detail.CityAddress;
            model.Email = detail.Email;

            return model;
        }
    }
}