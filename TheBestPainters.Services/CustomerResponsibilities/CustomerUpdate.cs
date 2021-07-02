using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CustomerModels;

namespace TheBestPainters.Services.CustomerResponsibilities
{
    public class CustomerUpdate
    {
        public static void Update(CustomerEdit model, Customer entity)
        {

            entity.FirstName = model.FirstName;
            entity.LastName = model.LastName;
            entity.PhoneNumber = model.PhoneNumber;
            entity.StreetAddress = model.StreetAddress;
            entity.CityAddress = model.CityAddress;
            entity.Email = model.Email;
        }
    }
}
