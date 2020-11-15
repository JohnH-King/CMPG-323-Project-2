using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string UserRole { get; set; }
        public string EmployeeNumber { get; set; }
    }
}
