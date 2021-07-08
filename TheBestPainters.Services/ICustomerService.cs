using System.Collections.Generic;
using TheBestPainters.Models.CustomerModels;

namespace TheBestPainters.Services
{
    public interface ICustomerService
    {
        bool CreateCustomer(CustomerCreate model);
        bool DeleteCustomer(int customerId);
        CustomerDetail GetCustomerById(int id);
        IEnumerable<CustomerListItem> GetCustomers();
        bool UpdateCustomer(CustomerEdit model);
    }
}