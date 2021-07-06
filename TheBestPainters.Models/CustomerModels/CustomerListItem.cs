using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.CustomerInterfaces;

namespace TheBestPainters.Models.CustomerModels
{
    public class CustomerListItem : ICustomerListItem
    {
        [Display(Name = "Customer Id")]
        public int Id { get; set; }
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
    }
}
