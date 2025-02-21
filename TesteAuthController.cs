using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class TesteAuthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "Você acessou uma rota protegida!" });
    }
}

