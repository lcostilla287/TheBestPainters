using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.EmployeeModels
{
    public class EmployeeListItem
    {
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
