using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CustomerModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.CustomerResponsibilities
{
    public class CustomerDataCapture
    {
        public static ICustomer Capture(CustomerCreate model, Guid _userId)
        {
            var entity = InstantiateModels.MakeCustomer();

            entity.OwnerId = _userId;
            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.PhoneNumber = model.PhoneNumber;
            entity.StreetAddress = model.StreetAddress;
            entity.CityAddress = model.CityAddress;
            entity.Email = model.Email;

            return entity;
        }
    }
}
