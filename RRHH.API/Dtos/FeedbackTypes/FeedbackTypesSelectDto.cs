using Microsoft.AspNetCore.Components.Web;

namespace RRHH.API.Dtos.FeedbackTypes
{
    public class FeedbackTypesSelectDto
    {
        public Guid  Id { get; set; }

        public string? Description {get; set;}

        public FeedbackTypesSelectDto? FeedbackType { get; set; }

        public string? Title {get; set;}

        public string? Comment {get; set;}

        public Guid GivenById {get; set;}  
    }
}