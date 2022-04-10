using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TTSSCoreMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName field is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName field is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please provide email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public string Phone { get; set; }
        
        public string Address { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime Created_at { get; set; } = DateTime.Now;
    }
}
