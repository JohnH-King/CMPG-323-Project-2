using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EmployeeNumber { get; set; }
    }
}
