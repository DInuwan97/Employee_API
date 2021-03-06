﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public String FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public String LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public Double Salary { get; set; }
    }
}
