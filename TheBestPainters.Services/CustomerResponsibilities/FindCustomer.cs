using System;
using System.Linq;
using TheBestPainters.Data;

namespace TheBestPainters.Services.CustomerResponsibilities
{
    public class FindCustomer
    {
        public static Customer GetCustomer(ApplicationDbContext ctx, int id, Guid _userId)
        {
            var entity =
                    ctx
                        .Customers
                        .Single(e => e.CustomerId == id && e.OwnerId == _userId);
            return entity;
        }
    }
}
