
using RRHH.API.Database;
using RRHH.API.Dtos.Common;
using RRHH.API.Dtos.Employees;
using RRHH.API.Dtos.Feedbacks;
using RRHH.API.Mappers;
using RRHH.API.Services.Employees.Constants;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace RRHH.API.Services.Feedbacks
{
    public class FeedbackService : IFeedbackService
    {
        private readonly RRHHDbContext _Context;

        public FeedbackService(RRHHDbContext dbContext)
        {
            this._Context = dbContext;
        }
          public Task<ResponseDto<PageDto<List<FeedbackDto>>>> GetPageAsync(string searchTerm = "", int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto<FeedbackOneDto>> GetOneByIdAsync(Guid id)
        {
            var entity = await _Context.Feedbacks!.FirstOrDefaultAsync(f => f.Id == id);
            if (entity == null)
            {
                return new ResponseDto<FeedbackOneDto>
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Status = false,
                    Message = ResponseMessageConstant.notFound,
                };
            }

            return new ResponseDto<FeedbackOneDto>
            {
                StatusCode = (int)HttpStatusCode.OK,
                Status = true,
                Data = FeedbackMapper.EntityToOneDto(entity)
            };
        }
        public async Task<ResponseDto<FeedbackActionResponseDto>> CreateAsync(FeedbackCreateDto dto)
        {
            var entity = FeedbackMapper.CreateDtoToEntity(dto);
            
            _Context.Feedbacks!.Add(entity);

            await _Context.SaveChangesAsync();
            
            return new ResponseDto<FeedbackActionResponseDto>
            {
              StatusCode = (int)HttpStatusCode.Created,
              Status = true,
              Message = ResponseMessageConstant.created,
              Data = FeedbackMapper.EntityToActionResponseDto(entity)
                
            };
        }
        public Task<ResponseDto<FeedbackActionResponseDto>> EditAsync(Guid id, FeedBackEditDto Dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<FeedbackActionResponseDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }


        


    }
}