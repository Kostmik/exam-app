using Microsoft.AspNetCore.Mvc;

namespace ExamApp.Controllers;

[ApiController]
[Route("health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "OK",
            service = "ExamApp"
        });
    }
}
