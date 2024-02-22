using Microsoft.AspNetCore.Mvc;

namespace TestApiVersioning.Controllers.v2;

[ApiController]
[ApiVersion("2.0")]
[Route("v{version:apiVersion}/[controller]")]
public class TestController: Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Version 2");
    }
}