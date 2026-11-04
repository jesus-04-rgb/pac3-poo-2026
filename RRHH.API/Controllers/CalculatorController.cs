using Microsoft.AspNetCore.Mvc;

namespace RRHH.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {

        [HttpPost("operations")]
        public IActionResult Operations ([FromBody] CalculatorModel calculator)
        {
           int result = calculator.Operator switch
           {
                "+" => calculator.N1 + calculator.N2,
                "-" => calculator.N1 - calculator.N2,
                "*" => calculator.N1 * calculator.N2,
                "÷" => calculator.N1 / calculator.N2,
                _=> 0

                 };
             return Ok(new
             {
                N1 = calculator.N1,
                N2 = calculator.N2,
                Operator = calculator.Operator,
                Total = result
            });
           
        }
    }
     public class CalculatorModel
    {
        public int N1 { get; set; }
        public int N2 { get; set; }

        public string? Operator { get; set; }

       
    }
}

/* DTO = Data Transfer Object => Significa objeto de transferencia de datos */

