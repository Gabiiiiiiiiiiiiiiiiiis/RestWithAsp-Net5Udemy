using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Projeto_Calculadora_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult sum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConverttoDecimal(firstNumber) + ConverttoDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult sub(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConverttoDecimal(firstNumber) - ConverttoDecimal(secondNumber);
                return Ok(sub.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("multi/{firstNumber}/{secondNumber}")]
        public IActionResult multi(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var multi = ConverttoDecimal(firstNumber) * ConverttoDecimal(secondNumber);
                return Ok(multi.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("divi/{firstNumber}/{secondNumber}")]
        public IActionResult divi(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var divi = ConverttoDecimal(firstNumber) / ConverttoDecimal(secondNumber);
                return Ok(divi.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult media(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var media = (ConverttoDecimal(firstNumber) + ConverttoDecimal(secondNumber)) / 2;
                return Ok(media.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("raiz/{firstNumber}")]
        public IActionResult raiz(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var raiz = Math.Sqrt((double)ConverttoDecimal(firstNumber));
                return Ok(raiz.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private decimal ConverttoDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
           bool isNumber = double.TryParse(strNumber,
               System.Globalization.NumberStyles.Any,
               System.Globalization.NumberFormatInfo.InvariantInfo,
               out number);
            return isNumber;
        }
    }

    public interface IActionresult
    {
    }
}
