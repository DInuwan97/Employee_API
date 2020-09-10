using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Models;

namespace Employee.Data
{
    public interface IEmployeeRepo
    {
        IEnumerable<EmployeeModel> GetEmployees();
        EmployeeModel GetEmployeeById(int id);
        public void CreateEmployee(EmployeeModel employee);
        public void UpdateEmployee(EmployeeModel employee);
        public void DeleteEmployee(EmployeeModel employee);
        public bool SaveChanges();
    }
}
