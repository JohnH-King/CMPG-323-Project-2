using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models.ViewModels
{
    public class PersonalAndEmployeeViewModel
    {
        public IEnumerable<Employee> EmployeeList { get; set; }
        public Personal Personal { get; set; }
        public List<int> PersonalList { get; set; }
        public string StatusMessage { get; set; }
    }
}
