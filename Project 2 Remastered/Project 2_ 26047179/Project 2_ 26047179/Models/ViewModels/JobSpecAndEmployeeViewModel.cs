﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Models.ViewModels
{
    public class JobSpecAndEmployeeViewModel
    {
        public IEnumerable<Employee> EmployeeList { get; set; }
        public JobSpecs JobSpecs { get; set; }
        public List<string> JobSpecsList { get; set; }
        public string StatusMessage { get; set; }
    }
}
