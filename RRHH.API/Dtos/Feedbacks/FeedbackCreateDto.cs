using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RRHH.API.Dtos.Feedbacks
{
    public class FeedbackCreateDto
    {
         [Display(Name = "Empleado")]
        [Required(ErrorMessage = "{0} es requerido")]

           public Guid Id {get; set;}
           [Display(Name = "Tipo de retroalimentación")]
        [Required(ErrorMessage = "{0} es requerido")]



            public Guid EmployeeId {get; set; }

            public Guid FeedbackTypeId {get; set;}
             
             [Display(Name = "Titulo")]
        [Required(ErrorMessage = "{0} es requerido")]
        [StringLength(70, ErrorMessage= "{0} debe tener un máximo de  {1} caracteres", MinimumLength = 3 )]

            public string? Title {get; set;}
              
             [Display(Name = "Comentario")]
        [Required(ErrorMessage = "{0} es requerido")]
        [StringLength(70, ErrorMessage = "{0} debe tener un máximo de  {1} caracteres", MinimumLength = 3 )]
             public string? Comment  {get; set;}
              
              
              [Display(Name = "Reporta")]
        [Required(ErrorMessage = "{0} es requerido")]
        [StringLength(70, ErrorMessage = "{0} debe tener un máximo de  {1} caracteres", MinimumLength = 3 )]
              public Guid GivenById {get; set;}
    }
}