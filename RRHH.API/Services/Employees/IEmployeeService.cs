using RRHH.API.Dtos.Employees;
using RRHH.API.Dtos.Common;
using RRHH.API.Employees;
using RRHH.API.Entities;

namespace RRHH.API.Services.Employees
{
    public interface IEmployeeService
    {

        Task<ResponseDto<PageDto<List<EmployeeDtos>>>> GetPageAsync(string searchTerm = "", int page = 1, int pageSize = 10);
        
        Task<ResponseDto<EmployeeOneDto>> GetOneByIdAsync(Guid id);

        Task<ResponseDto<EmployeeActionResponseDto>> CreateAsync(EmployeeCreateDto dto);

         Task<ResponseDto<EmployeeActionResponseDto>> EditAsync(Guid id,EmployeeEditDto Dto);

         Task<ResponseDto<EmployeeActionResponseDto>> DeleteAsync(Guid id);
        
    }

    
}
