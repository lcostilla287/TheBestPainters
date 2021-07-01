using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.EmployeeModels
{
    public class EmployeeDetail
    {
        public int EmployeeId { get; set; }
        public int? CrewId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Display(Name = "City Address")]
        public string CityAddress { get; set; }
        public string Email { get; set; }
        public bool IsCrewChief { get; set; }
    }
}
