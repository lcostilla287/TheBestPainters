using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TheBestPainters.Data;
using TheBestPainters.Models.CustomerModels;
using TheBestPainters.Services.CustomerResponsibilities;

namespace TheBestPainters.Services
{
    public class CustomerService
    {
        private readonly Guid _userId;

        public CustomerService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCustomer(CustomerCreate model)
        {
            Customer entity = CustomerDataCapture.Capture(model, _userId);

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Customers.Add(entity);
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
                
                return ReturnCustomerData.CustomerData(entity);
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

                foreach (var job in entity.Jobs)
                {
                    job.CustomerId = null;
                }

                ctx.Customers.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
