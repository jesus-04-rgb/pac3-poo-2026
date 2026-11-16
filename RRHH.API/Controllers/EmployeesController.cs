using Microsoft.AspNetCore.Mvc;
using RRHH.API.Dtos.Common;
using RRHH.API.Dtos.Employees;
using RRHH.API.Employees;
using RRHH.API.Entities;
using RRHH.API.Services.Employees;

namespace RRHH.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

            
        }
        [HttpGet]
        public ActionResult<ResponseDto<PageDto<List<EmployeeDtos>>>>GetAll(string searchTerm = "", int page = 1, int pageSize = 10)
        {
            
         var response = _employeeService.GetPage(searchTerm, page, pageSize);

           return StatusCode(response.StatusCode, new ResponseDto<PageDto<List<EmployeeDtos>>>

            {
                Status = response.Status,
                Message = response.Message,
                Data = response.Data
            });
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseDto<EmployeeOneDto>>> GetOne(Guid id)
        {
            var response = await _employeeService.GetOneByIdAsync(id);
            return StatusCode(response.StatusCode, new ResponseDto<EmployeeOneDto>
            {
            Status = response.Status,
                Message = response.Message,
                Data = response.Data
            });
        }
        [HttpPost]
          public async Task<ActionResult<ResponseDto<EmployeeActionResponseDto>>> Post([FromBody] EmployeeCreateDto Dto)
        {
            var response = await _employeeService.CreateAsync(Dto);
              return StatusCode(response.StatusCode, new ResponseDto<EmployeeActionResponseDto> 
         {
             Status = response.Status,
                Message = response.Message,
                Data = response.Data
         } );
        }

        [HttpPut("{id}")]

        public ActionResult<ResponseDto<EmployeeActionResponseDto>> Put(Guid id,[FromBody] EmployeeEditDto Dto)
        {
            var response = _employeeService.Edit(id, Dto);
            return StatusCode(response.StatusCode, new ResponseDto<EmployeeActionResponseDto>
            {
                Status = response.Status,
                Message = response.Message,
                Data = response.Data
            });
        }
        [HttpDelete("{id}")]
        public ActionResult<ResponseDto<EmployeeActionResponseDto>> Delete(Guid id)
        {
            var response = _employeeService.Delete(id);
            return StatusCode(response.StatusCode, new ResponseDto<EmployeeActionResponseDto>
            {
                Status = response.Status,
                Message = response.Message,
                Data = response.Data
            });
        }
        

        
    
    }
}