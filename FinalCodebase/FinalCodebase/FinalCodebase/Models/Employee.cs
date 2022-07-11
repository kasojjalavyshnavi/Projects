using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalCodebase.Models
{
    public class Employee
    {
        
        [Key]

    public int EmpId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string Address { get; set; }


    }
}
