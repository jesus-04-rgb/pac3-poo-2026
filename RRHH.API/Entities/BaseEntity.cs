using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RRHH.API.Entities
{
    public class BaseEntity
    {
      [Key]
      [Column("id")]
      public Guid Id { get; set; }

      [Column("create_date")]
      public DateTime CreateDate { get; set; }

      [Column("create_by_id")]
      public string? CreateById { get; set; }

      [Column("update_date")]
      public DateTime? UpdateDate { get; set; }

      [Column("update_by_id")]
      public string? UpdateById { get; set; }

    


    }
}