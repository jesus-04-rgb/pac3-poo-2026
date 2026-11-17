using RRHH.API.Dtos.Employees;
using RRHH.API.Employees;
using RRHH.API.Entities;
using System;
using System.Collections.Generic;
using RRHH.API.Dtos.Common;
using RRHH.API.Database;
using System.Net;
using RRHH.API.Services.Employees.Constants;
using Microsoft.EntityFrameworkCore;
using RRHH.API.Mappers;
using SQLitePCL;
namespace RRHH.API.Services.Employees

{
    public class EmployeeService : IEmployeeService
    {
        private readonly RRHHDbContext _context;

        private readonly int PAGE_SIZE;

        private readonly int PAGE_SIZE_LIMIT;
        public EmployeeService(RRHHDbContext context, IConfiguration configuration)
        {
            _context = context;
            PAGE_SIZE = configuration.GetValue<int>("PageSize");
            PAGE_SIZE_LIMIT = configuration.GetValue<int>("PageSizeLimit");

        }
    public ResponseDto<PageDto<List<EmployeeDtos>>> GetPage(string searchTerm = "", int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }
        public ResponseDto<EmployeeOneDto> GetOneById(Guid id)
        {
            var entity = _context.Employees.FirstOrDefault(e => e.Id == id);

            if(entity is null)
            {
                return new ResponseDto<EmployeeOneDto>
                {
                  StatusCode = HttpStatusCodeConstant.NotFound,
                  Status = false,
                  Message = ResponseMessageConstant.notFound,
                };
            }
            return new ResponseDto<EmployeeOneDto>
            {
                StatusCode = HttpStatusCodeConstant.OK,
                  Status = true,
                  Message = ResponseMessageConstant.found,
                  Data = new EmployeeOneDto
                  {
                      Id = entity.Id,
                      FirstName = entity.FirstName,
                      LastName = entity.LastName,
                      DNI = entity.DNI,
                      Gender = entity.Gender,
                  }  
            };
        }

        public async Task<ResponseDto<EmployeeOneDto>> GetOneByIdAsync(Guid id)
        
        {
            var entity = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);

            if (entity is null)
            {
                return new ResponseDto<EmployeeOneDto>
                {
                    StatusCode = HttpStatusCodeConstant.NotFound,
                    Status = false,
                    Message = "Registro no encontrado",
                };
            }

            return new ResponseDto<EmployeeOneDto>
            {
                StatusCode = HttpStatusCodeConstant.OK,
                Status = true,
                Message = ResponseMessageConstant.found,
                Data = EmployeeMapper.EntityToOneDto(entity)
            };
        }

        
        public async Task<ResponseDto<EmployeeActionResponseDto>> CreateAsync(EmployeeCreateDto dto)
        {
            var entity = EmployeeMapper.CreateDtoToEntity(dto);
           
            _context.Employees.Add(entity);
            await _context.SaveChangesAsync();

            return new ResponseDto<EmployeeActionResponseDto>
            {
                StatusCode = HttpStatusCodeConstant.Created,  
                Status = true,
                Message = ResponseMessageConstant.created,
                Data = EmployeeMapper.EntityToActionResponseDto(entity)

               
            };
        }

        public async Task<ResponseDto<EmployeeActionResponseDto>> EditAsync(Guid id, EmployeeEditDto Dto)
        {
            var entity = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            
            if (entity is null)
            {
                return new ResponseDto<EmployeeActionResponseDto>
                {
                    StatusCode = HttpStatusCodeConstant.NotFound,
                    Status = false,
                    Message = ResponseMessageConstant.notFound
                };
            }
            var entityToUpdate = EmployeeMapper.EditDtoToEntity(Dto, entity);

            _context.Employees.Update(entityToUpdate);

            await _context.SaveChangesAsync();

           return new ResponseDto<EmployeeActionResponseDto>
           {
                    StatusCode = HttpStatusCodeConstant.OK,
                    Status = true,
                    Message = ResponseMessageConstant.Updated,
                    Data = EmployeeMapper.EntityToActionResponseDto(entityToUpdate)
               
           };
        }
         public async Task<ResponseDto<EmployeeActionResponseDto>> DeleteAsync(Guid id)
        {
            var entity = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
            if (entity is null)
            {
                return new ResponseDto<EmployeeActionResponseDto>
                {
                    StatusCode = HttpStatusCodeConstant.NotFound,
                    Status = false,
                    Message = ResponseMessageConstant.notFound
                };
            }
            _context.Employees.Remove(entity);
            
            await _context.SaveChangesAsync();

            return new ResponseDto<EmployeeActionResponseDto>
            {
                StatusCode = HttpStatusCodeConstant.OK,
                Status = true,
                Message = ResponseMessageConstant.Deleted,
                Data = new EmployeeActionResponseDto { Id = id }
            };  
        }

    }
}

