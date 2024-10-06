using Microsoft.AspNetCore.Mvc;
using CalculatorApi.Interfaces;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService<int> _intCalculatorService;
        private readonly ICalculatorService<double> _doubleCalculatorService;

        public CalculatorController(ICalculatorService<int> intCalculatorService, ICalculatorService<double> doubleCalculatorService)
        {
            _intCalculatorService = intCalculatorService;
            _doubleCalculatorService = doubleCalculatorService;
        }

        [HttpGet("Add")]
        public ActionResult<double> Add(double a, double b)
        {
            var result = _doubleCalculatorService.Add(a, b);
            Console.WriteLine($"Add Result: {result}, Type: {result.GetType()}");
            return result;
        }

        [HttpGet("Subtract")]
        public ActionResult<double> Subtract(double a, double b)
        {
            var result = _doubleCalculatorService.Subtract(a, b);
            Console.WriteLine($"Subtract Result: {result}, Type: {result.GetType()}");
            return result;
        }

        [HttpGet("Multiply")]
        public ActionResult<double> Multiply(double a, double b)
        {
            var result = _doubleCalculatorService.Multiply(a, b);
            Console.WriteLine($"Multiply Result: {result}, Type: {result.GetType()}");
            return result;
        }

        [HttpGet("Divide")]
        public ActionResult<double> Divide(double a, double b)
        {
            try
            {
                var result = _doubleCalculatorService.Divide(a, b);
                Console.WriteLine($"Divide Result: {result}, Type: {result.GetType()}");
                return result;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return BadRequest(ex.Message);
            }
        }
    }
}