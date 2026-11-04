using Microsoft.AspNetCore.Mvc;
using RRHH.API.Entities;
using RRHH.API.Services.Employees;

namespace RRHH.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly List<EmployeeEntity> _employees;

        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            _employees = new List<EmployeeEntity>
            {
                new EmployeeEntity { Id = 1, FirstName = "Juan", LastName = "Peres", DNI = "0401-2000-12345", Gender = "M" },
                new EmployeeEntity { Id = 2, FirstName = "Maria", LastName = "Lopez", DNI = "0401-2000-00002", Gender = "F" }
            };
            
        }
        [HttpGet]
        public IActionResult GetAll(string DNI)
        {
           return Ok(_employees);
        }
        [HttpGet("{DNI}")]
        public IActionResult GetOne(string DNI)
        {
        //  EmployeeEntity emp = new EmployeeEntity();

        //  foreach(var employee in _employees)
        //     {
                
        //         if(employee.DNI != null && employee.DNI.Equals(DNI))
        //         {
        //             emp = employee;
                    
        //         }
        //     }  
           
           var emp = _employees.FirstOrDefault(e => e.DNI == DNI);
           return Ok( _employees.FirstOrDefault(e => e.DNI == DNI));
 
        }
        [HttpPost]
        public IActionResult Post(EmployeeEntity employee)
        {
            _employees.Add(employee);

            return Ok(new{Id = employee.Id});
        }

        [HttpPut("{DNI}")]

        public IActionResult Put(String DNI, [FromBody] EmployeeEntity employee)
        {
            var oldEmployee = _employees.FirstOrDefault(e => e.DNI == DNI);
            if (oldEmployee != null)
            {
                _employees.Remove(oldEmployee);
                _employees.Add(employee);
    
            }
            return Ok(_employees);
        }
        [HttpDelete("{DNI}")]
        public IActionResult Delete(string DNI)
        {
            var oldemployee = _employees.FirstOrDefault(e => e.DNI == DNI);
            if (oldemployee != null)
            {
                _employees.Remove(oldemployee);

            }
          return Ok(_employees);
        }
        

        
    
    }
}