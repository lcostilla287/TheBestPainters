using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.CustomerInterfaces;

namespace TheBestPainters.Models.CustomerModels
{
    public class CustomerCreate : ICustomerCreate
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        [Required]
        public string CityAddress { get; set; }

        public string Email { get; set; }
    }
}
