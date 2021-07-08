using System.Collections.Generic;
using TheBestPainters.Models.EmployeeModels;

namespace TheBestPainters.Services
{
    public interface IEmployeeService
    {
        bool CreateEmployee(EmployeeCreate model);
        bool DeleteEmployee(int employeeId);
        EmployeeDetail GetEmployeeById(int id);
        IEnumerable<EmployeeListItem> GetEmployees();
        bool UpdateEmployee(EmployeeEdit model);
    }
}