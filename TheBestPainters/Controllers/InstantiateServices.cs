using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheBestPainters.Services;

namespace TheBestPainters.Controllers
{
    public class InstantiateServices
    {
        //Factory
        //Dependency Inversion? 
        public static ICustomerService CustomerService(Guid userId)
        {
            return new CustomerService(userId);
        }
        public static IJobService JobService(Guid userId)
        {
            return new JobService(userId);
        }
        public static IMaterialService MaterialService(Guid userId)
        {
            return new MaterialService(userId);
        }
        public static ICrewService CrewService(Guid userId)
        {
            return new CrewService(userId);
        }
        public static IEmployeeService EmployeeService(Guid userId)
        {
            return new EmployeeService(userId);
        }
    }
}