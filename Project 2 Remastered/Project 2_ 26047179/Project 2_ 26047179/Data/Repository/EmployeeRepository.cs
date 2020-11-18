using Microsoft.AspNetCore.Mvc.Rendering;
using Project_2__26047179.Data.Repository.IRepository;
using Project_2__26047179.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_2__26047179.Data.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;

        public EmployeeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetEmployeeList()
        {
            return _db.Employee.Select(i=> new SelectListItem()
            {
                Text = i.Education,
                Value = i.Id.ToString()
            });
        }

        public void Update(Employee employee)
        {
            var objFromDb = _db.Employee.FirstOrDefault(s => s.Id == employee.Id);

            objFromDb.Id = employee.Id;
            objFromDb.EmployeeNumber = employee.EmployeeNumber;

            _db.SaveChanges();
        }
    }
}
