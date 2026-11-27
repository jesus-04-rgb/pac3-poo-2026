using RRHH.API.Dtos.Employees;
using RRHH.API.Dtos.Feedbacks;
using RRHH.API.Dtos.FeedbackTypes;
using RRHH.API.Employees;
using RRHH.API.Entities;

namespace RRHH.API.Mappers
{
    public class FeedbackMapper
    {
       public static FeedbackOneDto EntityToOneDto(FeedbackEntity entity)
       {
           return new FeedbackOneDto
           {
               Id = entity.Id,
               Comment = entity.Comment,
               Title = entity.Title,    
               GivenById = entity.GivenById,
               Employee = new EmployeeSelectDto
               {
                   Id = entity.Employee!.Id,
                   FullName = entity.Employee.FirstName + " " + entity.Employee.LastName
               },
               FeedbackType = new FeedbackTypesSelectDto
    
               {
                   Id = entity.FeedbackType!.Id,
                   Description = entity.FeedbackType.Description
               } 
           };
       }
    public static FeedbackEntity CreateDtoToEntity(FeedbackCreateDto dto)
    {
        return new FeedbackEntity
        {
            Id = Guid.NewGuid(),
            Comment = dto.Comment,
            Title = dto.Title,
            GivenById = dto.GivenById,
            EmployeeId = dto.EmployeeId,
            FeedbackTypeId = dto.FeedbackTypeId
        };
      }

      public static FeedbackActionResponseDto EntityToActionResponseDto(FeedbackEntity entity)
      {
            return new FeedbackActionResponseDto 
            {
                Id = entity.Id
            };
      }

      public static FeedbackEntity EditDtoToEntity(FeedBackEditDto dto, FeedbackEntity entity)
      {
          entity.Comment = dto.Comment;
          entity.Title = dto.Title;
          entity.GivenById = dto.GivenById;
          entity.EmployeeId = dto.EmployeeId;
          entity.FeedbackTypeId = dto.FeedbackTypeId;
          return entity;
      }
      
      public static List<FeedbackDto> ListFeedbackEntityToListDto(List<FeedbackEntity> entities) 
      {
          return entities.Select(entity => new FeedbackDto
          {
             Id = entity.Id,
             Title = entity.Title,
            EmployeeName = entity.Employee!.FirstName + " " + entity.Employee.LastName,
             FeedbackTypeDescription = entity.FeedbackType!.Description,
          }).ToList();
      }
    }
}