using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.EmployeeInterfaces;

namespace TheBestPainters.Models.EmployeeModels
{
    public class EmployeeListItem : IEmployeeListItem
    {
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }
        public int? CrewId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string PhoneNumber { get; set; }
        public bool IsCrewChief { get; set; }
    }
}
