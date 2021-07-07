using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CustomerModels;
using TheBestPainters.Models.JobModels;

namespace TheBestPainters.Services.CustomerResponsibilities
{
    public class ReturnCustomerData
    {
        public static CustomerDetail CustomerData(Customer customer)
        {
            return
                    new CustomerDetail
                    {
                        Id = customer.Id,
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        PhoneNumber = customer.PhoneNumber,
                        StreetAddress = customer.StreetAddress,
                        CityAddress = customer.CityAddress,
                        Email = customer.Email,

                        Jobs = customer.Jobs
                        .Select(e => new JobListItem()
                        {
                            JobId = e.JobId,
                            JobLocation = e.JobLocation,
                        }).ToList()
                    };
        }
    }
}
