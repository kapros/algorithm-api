using Microsoft.AspNetCore.Mvc;
using Fizz = Algos.FizzBuzz;

namespace AlgoApi.Controllers
{
    public class AlgoController : Controller
    {
        [HttpGet("fizzbuzz/stringbuilder")]
        public IActionResult FizzBuzz(int n)
        {
            return Ok(Fizz.ForWithStringBuilder(n));
        }

        [HttpGet("fizzbuzz/ifelse")]
        public IActionResult FizzBuzzIfElse(int n)
        {
            return Ok(Fizz.ForWithIfElseReturns(n));
        }

        [HttpGet("fib/memoidized")]
        public IActionResult MemoidizedFib(int n)
        {
            var fib = new Algos.Fib(n);
            return Ok(fib.MemoidizedFib());
        }

        [HttpGet("fib/recursive")]
        public IActionResult RecursiveFib(int n)
        {
            var fib = new Algos.Fib(n);
            return Ok(fib.RecursiveFib());
        }

        [HttpGet("fib/nonrecursive")]
        public IActionResult NonRecursiveFib(int n)
        {
            var fib = new Algos.Fib(n);
            return Ok(fib.NonRecursiveFib());
        }
    }
}
