using System.ComponentModel.DataAnnotations;
using RRHH.API.Validations;
namespace RRHH.API.Dtos.Employees
{
    public class EmployeeCreateDto
    {    
         [Display(Name = "Nombres")]
         [Required(ErrorMessage = "Los {0} son obligatorios")]
         [MaxLength(30, ErrorMessage = "Los {0} no pueden tener mas de {1} caracteres")]
       public string? FirstName { get; set; }
       
        [Display(Name = "Apellidos")]
         [Required(ErrorMessage = "Los {0} son obligatorios")]
         [MaxLength(30, ErrorMessage = "Los {0} no pueden tener mas de {1} caracteres")] 
       public string? LastName { get; set; }
            [DNIAttribute]  
           [Display(Name = "DNI")]
          [Required(ErrorMessage = "El {0} es obligatorio")]
         [MaxLength(13, ErrorMessage = "El {0} no puede tener mas de {1} caracteres")]
        public string? DNI { get; set;}
          
          [Display(Name = "Género")]
          [Required(ErrorMessage = "El {0} es obligatorio")]
         [MaxLength(1, ErrorMessage = "El {0} no puede tener mas de {1} caracteres")]
        public string? Gender { get; set; }

        

    }
}