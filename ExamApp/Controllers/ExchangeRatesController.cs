using ExamApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers;

[ApiController]
[Route("api/rates")]
public class ExchangeRatesController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var rates = new List<ExchangeRate>
        {
            new()
            {
                Id = 1,
                FromCurrency = "USD",
                ToCurrency = "RUB",
                Rate = 75.20m
            },
            new()
            {
                Id = 2,
                FromCurrency = "EUR",
                ToCurrency = "RUB",
                Rate = 82.40m
            }
        };

        return Ok(rates);
    }
}
