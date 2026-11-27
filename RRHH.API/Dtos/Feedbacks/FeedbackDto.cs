using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.API.Dtos.Feedbacks
{
    public class FeedbackDto
    {
        public Guid Id { get; set; }
        
        public string? EmployeeName {get; set;}
        public string? FeedbackTypeDescription {get; set;}

        public string? Title {get; set;}

    }
}