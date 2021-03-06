using System;
using System.Collections.Generic;
using System.Linq;
using TheBestPainters.Data;
using TheBestPainters.Models.CustomerModels;
using TheBestPainters.Services.CustomerResponsibilities;
using TheBestPainters.Services.Instantiate;

namespace TheBestPainters.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly Guid _userId;

        public CustomerService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCustomer(CustomerCreate model)
        {
            var entity = CustomerDataCapture.Capture(model, _userId);
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Customers.Add((Customer)entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CustomerListItem> GetCustomers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = CustomerQuery.Query(ctx, _userId);

                return query.ToArray();
            }
        }

        public CustomerDetail GetCustomerById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindCustomer.GetCustomer(ctx, id, _userId);

                return (CustomerDetail)ReturnCustomerData.CustomerData(entity);
            }
        }

        public bool UpdateCustomer(CustomerEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindCustomer.GetCustomer(ctx, model.CustomerId, _userId);

                CustomerUpdate.Update(model, entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = FindCustomer.GetCustomer(ctx, customerId, _userId);

                NullJobs.Nullify(entity);

                ctx.Customers.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
