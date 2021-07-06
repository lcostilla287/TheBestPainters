using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CustomerModels;

namespace TheBestPainters.Services.CustomerResponsibilities
{
    public class CustomerDataCapture
    {
        public static Customer Capture(CustomerCreate model, Guid _userId)
        {
            var entity =
                new Customer()
                {
                OwnerId = _userId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                StreetAddress = model.StreetAddress,
                CityAddress = model.CityAddress,
                Email = model.Email
                };
            return entity;
        }
    }
}
