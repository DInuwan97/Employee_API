using Employee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Data
{
    public class EmployeeContext :DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> opt) : base(opt)
        {

        }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}
