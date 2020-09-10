using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Employee.Data;
using Employee.DTO;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepo _repository;
        private readonly IMapper _mapper;

        public EmployeesController(IEmployeeRepo repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        

        // GET: api/<EmployeesController>
        [HttpGet]
        public ActionResult <IEnumerable<EmployeeReadDto>> Get()
        {
            var emp = _repository.GetEmployees();
            //return Ok(emp);
            return Ok(_mapper.Map<IEnumerable<EmployeeReadDto>>(emp));
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public ActionResult <EmployeeReadDto> Get(int id)
        {
            var emp = _repository.GetEmployeeById(id);
            if(emp != null)
            {
                return Ok(_mapper.Map<EmployeeReadDto>(emp));
            }
            else
            {
                return NotFound();
            }
 
        }


        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<EmployeeReadDto> Post(EmployeeCreateDto employeeCreateDto)
        {
            var employee = _mapper.Map<EmployeeModel>(employeeCreateDto);
            _repository.CreateEmployee(employee);

            _repository.SaveChanges();

            var employeeReadDTO = _mapper.Map<EmployeeReadDto>(employee);
            // return Ok(employee);
            return Ok(employeeReadDTO);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id,EmployeeUpdateDto employeeUpdateDto)
        {
            var checkAvailability_emp = _repository.GetEmployeeById(id);
            if(checkAvailability_emp != null)
            {
                _mapper.Map(employeeUpdateDto, checkAvailability_emp);
                _repository.UpdateEmployee(checkAvailability_emp);

                _repository.SaveChanges();
                return Ok(checkAvailability_emp);
            }
            else
            {
                return NotFound();
            }
        } 

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var checkAvailability_emp = _repository.GetEmployeeById(id);
            if (checkAvailability_emp == null)
            {
                return NotFound();
            }
            else
            {
                _repository.DeleteEmployee(checkAvailability_emp);
                _repository.SaveChanges();
                return Ok(checkAvailability_emp);
            }
        }
    }
}
