using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models.ViewModels
{
    public class JobInfoAndEmployeeViewModel
    {
        public IEnumerable<Employee> EmployeeList { get; set; }
        public JobInfo JobInfo { get; set; }
        public List<string> JobInfoList { get; set; }
        public string StatusMessage { get; set; }
    }
}
