using System.ComponentModel.DataAnnotations.Schema;

namespace RRHH.API.Entities
{
    [Table("feedback_types")]
    public class FeedbackTypeEntity : BaseEntity
    {
        [Column ("description")]

        public string? Description {get; set;}

        public virtual IEnumerable<FeedbackEntity>? Feedbacks {get; set;}

    }
}