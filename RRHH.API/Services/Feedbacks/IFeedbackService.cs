using RRHH.API.Dtos.Employees;
using RRHH.API.Dtos.Common;
using RRHH.API.Dtos.Feedbacks;

namespace RRHH.API.Services.Feedbacks
{
    public interface IFeedbackService
    {
        Task<ResponseDto<PageDto<List<FeedbackDto>>>> GetPageAsync(string searchTerm = "", int page = 1, int pageSize = 10);
        
        Task<ResponseDto<FeedbackOneDto>> GetOneByIdAsync(Guid id);

        Task<ResponseDto<FeedbackActionResponseDto>> CreateAsync(FeedbackCreateDto dto);

         Task<ResponseDto<FeedbackActionResponseDto>> EditAsync(Guid id,FeedBackEditDto Dto);

         Task<ResponseDto<FeedbackActionResponseDto>> DeleteAsync(Guid id);
    }
}