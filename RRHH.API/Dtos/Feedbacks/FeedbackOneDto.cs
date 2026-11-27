using RRHH.API.Dtos.FeedbackTypes;
using RRHH.API.Employees;

namespace RRHH.API.Dtos.Feedbacks
{
    public class FeedbackOneDto
    {
        public Guid Id {get; set;}

         public EmployeeSelectDto? Employee   {get; set;}
        public FeedbackTypesSelectDto? FeedbackType {get; set;}

        public string? Title {get; set;}

        public string? Comment {get; set;}

        public Guid GivenById {get; set;}
    }
}

       

    

