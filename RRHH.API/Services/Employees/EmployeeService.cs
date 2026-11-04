using RRHH.API.Dtos.Employees;
using RRHH.API.Employees;
using RRHH.API.Entities;
using System;
using System.Collections.Generic;
using RRHH.API.Dtos.Common;     
namespace RRHH.API.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
    public ResponseDtos<PageDto<List<EmployeeDtos>>> GetPage()
        {
            throw new NotImplementedException();
        }
         public ResponseDtos<EmployeeOneDto> GetOneById(int Id)
        {
            throw new NotImplementedException();
        }
        
        public ResponseDtos<EmployeeActionResponseDtos> Create(EmployeeCreateDto Dto)
        {
            throw new NotImplementedException();
        }

        public ResponseDtos<EmployeeActionResponseDtos> Edit(EmployeeEditDto Dto)
        {
            throw new NotImplementedException();
        }
         public ResponseDtos<EmployeeActionResponseDtos> Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

       
    }
}

