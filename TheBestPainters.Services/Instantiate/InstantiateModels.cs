using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data;
using TheBestPainters.Data.Interfaces;
using TheBestPainters.Models.CrewInterfaces;
using TheBestPainters.Models.CrewModels;
using TheBestPainters.Models.CustomerInterfaces;
using TheBestPainters.Models.CustomerModels;
using TheBestPainters.Models.EmployeeInterfaces;
using TheBestPainters.Models.EmployeeModels;
using TheBestPainters.Models.JobInterfaces;
using TheBestPainters.Models.JobModels;
using TheBestPainters.Models.MaterialInterfaces;
using TheBestPainters.Models.MaterialModels;

namespace TheBestPainters.Services.Instantiate
{
    public class InstantiateModels
    {
        //Customer
        public static ICustomer MakeCustomer()
        {
            return new Customer();
        }
        public static ICustomerDetail CustomerDetail()
        {
            return new CustomerDetail();
        }
        public static ICustomerCreate CustomerCreate()
        {
            return new CustomerCreate();
        }
        public static ICustomerEdit CustomerEdit()
        {
            return new CustomerEdit();
        }
        public static ICustomerListItem CustomerListItem()
        {
            return new CustomerListItem();
        }
        //Job
        public static IJob MakeJob()
        {
            return new Job();
        }
        public static IJobDetail JobDetail()
        {
            return new JobDetail();
        }
        public static IJobCreate JobCreate()
        {
            return new JobCreate();
        }
        public static IJobEdit JobEdit()
        {
            return new JobEdit();
        }
        public static IJobListItem JobListItem()
        {
            return new JobListItem();
        }
        //Material
        public static IMaterial MakeMaterial()
        {
            return new Material();
        }
        public static IMaterialDetail MaterialDetail()
        {
            return new MaterialDetail();
        }
        public static IMaterialCreate MaterialCreate()
        {
            return new MaterialCreate();
        }
        public static IMaterialEdit MaterialEdit()
        {
            return new MaterialEdit();
        }
        public static IMaterialListItem MaterialListItem()
        {
            return new MaterialListItem();
        }
        //Crew
        public static ICrew MakeCrew()
        {
            return new Crew();
        }
        public static ICrewDetail CrewDetail()
        {
            return new CrewDetail();
        }
        public static ICrewCreate CrewCreate()
        {
            return new CrewCreate();
        }
        public static ICrewEdit CrewEdit()
        {
            return new CrewEdit();
        }
        public static ICrewListItem CrewListItem()
        {
            return new CrewListItem();
        }
        //Employee
        public static IEmployee MakeEmployee()
        {
            return new Employee();
        }
        public static IEmployeeDetail EmployeeDetail()
        {
            return new EmployeeDetail();
        }
        public static IEmployeeCreate EmployeeCreate()
        {
            return new EmployeeCreate();
        }
        public static IEmployeeEdit EmployeeEdit()
        {
            return new EmployeeEdit();
        }
        public static IEmployeeListItem EmployeeListItem()
        {
            return new EmployeeListItem();
        }
    }
}
