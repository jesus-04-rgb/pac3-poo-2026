using System.ComponentModel.DataAnnotations.Schema;


namespace RRHH.API.Entities
{
    [Table ("feedbacks")]
    public class FeedbackEntity : BaseEntity
    {
        [Column ("employee_id")]
        public Guid EmployeeId {get; set; }

        [ForeignKey (nameof(EmployeeId))]
        public virtual EmployeeEntity? Employee {get; set;}
         
         [Column("feedback_type_id")]
        public Guid FeedbackTypeId {get; set;}

        [ForeignKey (nameof(FeedbackTypeId))]
        public virtual FeedbackTypeEntity? FeedbackType {get; set;}

        [Column("Title")]
        public string? Title {get; set;}
         
         [Column("Comment")]
        public string? Comment  {get; set;}

         [Column("Given_By_Id")]
        public Guid GivenById {get; set;}
        public string Feedback { get; internal set; }
    }
}