using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestPainters.Models.EmployeeModels
{
    public class EmployeeEdit
    {
        [Required]
        public int EmployeeId { get; set; }
        public int? CrewId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Required]
        [Display(Name = "City Address")]
        public string CityAddress { get; set; }
        public string Email { get; set; }
        public bool IsCrewChief { get; set; }
    }
}
