using RRHH.API.Dtos.Employees;
using RRHH.API.Employees;
using RRHH.API.Entities;

namespace RRHH.API.Mappers
{
    public class EmployeeMapper
    {
       public static EmployeeOneDto EntityToOneDto(EmployeeEntity entity)
       {
           return new EmployeeOneDto
           {
               Id = entity.Id,
               FirstName = entity.FirstName,
               LastName = entity.LastName,
               DNI = entity.DNI,
               Gender = entity.Gender,
           };
       }
    public static EmployeeEntity CreateDtoToEntity(EmployeeCreateDto dto)
    {
        return new EmployeeEntity
        {
            Id = Guid.NewGuid(),
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            DNI = dto.DNI,
            Gender = dto.Gender,
        };
      }

      public static EmployeeActionResponseDto EntityToActionResponseDto(EmployeeEntity entity)
      {
            return new EmployeeActionResponseDto { Id = entity.Id };
      }

      public static EmployeeEntity EditDtoToEntity(EmployeeEditDto dto, EmployeeEntity entity)
      {
          entity.FirstName = dto.FirstName;
          entity.LastName = dto.LastName;
          entity.DNI = dto.DNI;
          entity.Gender = dto.Gender;
          return entity;
      }

       
    }
}