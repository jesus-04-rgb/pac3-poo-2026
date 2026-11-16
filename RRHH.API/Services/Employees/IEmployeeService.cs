using RRHH.API.Dtos.Employees;
using RRHH.API.Dtos.Common;
using RRHH.API.Employees;
using RRHH.API.Entities;

namespace RRHH.API.Services.Employees
{
    public interface IEmployeeService
    {

        ResponseDto<PageDto<List<EmployeeDtos>>> GetPage(string searchTerm = "", int page = 1, int pageSize = 10);
        
        Task<ResponseDto<EmployeeOneDto>> GetOneByIdAsync(Guid id);

        Task<ResponseDto<EmployeeActionResponseDto>> CreateAsync(EmployeeCreateDto dto);

         ResponseDto<EmployeeActionResponseDto> Edit(Guid id,EmployeeEditDto Dto);

         ResponseDto<EmployeeActionResponseDto> Delete(Guid id);
  

  
    }

    
}
