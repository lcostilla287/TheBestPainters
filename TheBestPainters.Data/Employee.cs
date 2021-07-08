using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Data.Interfaces;

namespace TheBestPainters.Data
{
    public class IEmployee : IEmployee
    {
        
        [Key]
        [Display(Name = "EmployeeId")]
        public int EmployeeId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }
        [ForeignKey(nameof(Crew))]
        public int? CrewId { get; set; }
        public virtual Crew Crew { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string CityAddress { get; set; }

        public string Email { get; set; }
        public bool IsCrewChief { get; set; }

        public DateTimeOffset DateHired { get; set; }
    }
}
