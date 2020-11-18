using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project_2__26047179.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string UserRole { get; set; }
        public string EmployeeNumber { get; set; }

        public static implicit operator ApplicationUser(string v)
        {
            throw new NotImplementedException();
        }
    }
}
