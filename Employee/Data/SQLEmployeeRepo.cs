using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Data
{
    public class SQLEmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeContext _context;
        public SQLEmployeeRepo(EmployeeContext context)
        {
            _context = context;
        }

        public void CreateEmployee(EmployeeModel employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            else
            {
                _context.Add(employee);
            }
        }

        public void DeleteEmployee(EmployeeModel employee)
        {
            if(employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            else
            {
                _context.Employees.Remove(employee);
            }
           
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            //Nothing
        }
    }
}
