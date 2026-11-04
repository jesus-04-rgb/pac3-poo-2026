using RRHH.API.Dtos.Employees;
using RRHH.API.Dtos.Common;
using RRHH.API.Employees;
using RRHH.API.Entities;

namespace RRHH.API.Services.Employees
{
    public interface IEmployeeService
    {

        ResponseDtos<PageDto<List<EmployeeDtos>>> GetPage();
        ResponseDtos<EmployeeOneDto> GetOneById(int Id);

        ResponseDtos<EmployeeActionResponseDtos> Create(EmployeeCreateDto Dto);

        ResponseDtos<EmployeeActionResponseDtos> Edit( EmployeeEditDto Dto);

        ResponseDtos<EmployeeActionResponseDtos> Delete(Guid Id);

    
        
    }

    
}
