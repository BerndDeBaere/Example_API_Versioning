using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace TestApiVersioning.Controllers.v1;

[ApiController]
[ApiVersion(1, Deprecated = true)]
[Route("v{version:apiVersion}/[controller]")]
public class TestController: Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Version 1");
    }
}