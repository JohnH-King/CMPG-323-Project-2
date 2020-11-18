using Microsoft.AspNetCore.Mvc.Rendering;
using Project_2__26047179.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Data.Repository.IRepository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<SelectListItem> GetEmployeeList();

        void Update(Employee employee);
    }
}
