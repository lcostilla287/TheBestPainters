using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Models.CustomerModels;

namespace TheBestPainters.Services.CustomerResponsibilities
{
    public class CustomerQuery
    {
        public static IQueryable<CustomerListItem> Query(ApplicationDbContext ctx, Guid userId)
        {
            var query =
                ctx
                         .Customers
                         .Where(e => e.OwnerId == userId)
                         .Select(
                             e =>
                                 new CustomerListItem
                                 {
                                     Id = e.Id,
                                     FirstName = e.FirstName,
                                     LastName = e.LastName,
                                     PhoneNumber = e.PhoneNumber
                                 }
                         );
            return query;
        }
    }
}
