using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
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
        var sub = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (sub == null)
        {
            // Caso a claim não seja encontrada
            return BadRequest("Claim 'sub' não encontrada no token.");
        }
        
        return Ok(new 
        { 
            message = $"Você acessou uma rota protegida!, Subject (sub): {sub}" 
        });
    }
}

