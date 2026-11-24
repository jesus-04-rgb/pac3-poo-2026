using System.ComponentModel.DataAnnotations;

namespace RRHH.API.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class DNIAttribute : ValidationAttribute
    {
        private const int DNILength = 13;

        public DNIAttribute() : base("El {0} (Documento Nacional de Identidad) debe contener exactamente 13 dígitos numéricos") 
        {  
        } 
         
       public override bool IsValid(object? value) 
        {
            if(value is null )
                return true;

            if(value is not string DNI)
                return false;

            if(DNI.Length == 0 )
                return true;

            if(DNI.Length != DNILength)
                return false;

            foreach (var c in DNI)
            {
            if( c < '0' || c > '9')  
                    return false;
            }

            return true;
        }
    }
}