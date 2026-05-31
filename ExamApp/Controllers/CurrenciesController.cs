using ExamApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers;

[ApiController]
[Route("api/currencies")]
public class CurrenciesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var currencies = new List<Currency>
        {
            new()
            {
                Id = 1,
                Code = "USD",
                Name = "US Dollar"
            },
            new()
            {
                Id = 2,
                Code = "EUR",
                Name = "Euro"
            },
            new()
            {
                Id = 3,
                Code = "RUB",
                Name = "Russian Ruble"
            }
        };

        return Ok(currencies);
    }
}