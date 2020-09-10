using AutoMapper;
using Employee.DTO;
using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Profiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeModel, EmployeeReadDto>();
            CreateMap<EmployeeCreateDto, EmployeeModel>();
            CreateMap<EmployeeUpdateDto, EmployeeModel>();
        }
    }
}
