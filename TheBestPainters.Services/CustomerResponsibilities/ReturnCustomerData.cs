using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CustomerInterfaces;
using TheBestPainters.Models.CustomerModels;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services.CustomerResponsibilities
{
    public class ReturnCustomerData
    {
        public static ICustomerDetail CustomerData(Customer customer)
        {
            var cust = InstantiateModels.CustomerDetail();

            cust.CustomerId = customer.CustomerId;
            cust.FirstName = customer.FirstName;
            cust.LastName = customer.LastName;
            cust.PhoneNumber = customer.PhoneNumber;
            cust.StreetAddress = customer.StreetAddress;
            cust.CityAddress = customer.CityAddress;
            cust.Email = customer.Email;

            cust.Jobs = customer.Jobs
            .Select(e => new JobListItem()
            {
                JobId = e.JobId,
                JobLocation = e.JobLocation,
            }).ToList();

            return cust;
        }
    }
}
