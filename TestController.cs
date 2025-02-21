using Microsoft.AspNetCore.Mvc;

namespace AuthServer;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new 
        { 
            message = "Você acessou uma rota teste!" 
        });
    }
}

