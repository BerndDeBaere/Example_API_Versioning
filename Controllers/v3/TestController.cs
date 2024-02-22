using Microsoft.AspNetCore.Mvc;

namespace TestApiVersioning.Controllers.v3;

[ApiController]
[ApiVersion("3.0")]
[Route("v{version:apiVersion}/[controller]")]
public class TestController: Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Version 3");
    }
}