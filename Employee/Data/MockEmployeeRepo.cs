using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Data
{
    public class MockEmployeeRepo : IEmployeeRepo
    {
        public void CreateEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return new EmployeeModel { Id = id, FirstName = "Dinuwan", LastName = "Kalubowila", Age = 23, Salary = 15000.00 };
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {
            var employee = new List<EmployeeModel>
            {
                new EmployeeModel{ Id = 1,FirstName="Dinuwan",LastName="Kalubowila",Age=23,Salary=15000.00},
                new EmployeeModel{ Id = 2,FirstName="Sajith",LastName="Jonathan",Age=25,Salary=16000.00},
                new EmployeeModel{ Id = 3,FirstName="Gihan",LastName="Saranga",Age=26,Salary=17000.00}
            };

            return employee;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
