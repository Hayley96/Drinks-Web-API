using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("/")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("{name}")]
        public Coffee Get(string? name) => new Coffee { Name = name ?? "latte", Id = string.IsNullOrEmpty(name) ? -1 : 3 };
        [HttpGet("lover")]
        public string GetCoffeeLover() => "I love, love, love coffeeeeee!";
    }
}