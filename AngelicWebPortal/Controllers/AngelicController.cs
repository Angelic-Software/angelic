using Angelic.Client;
using Angelic.Models.Tickets;
using Microsoft.AspNetCore.Mvc;

namespace AngelicWebPortal.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AngelicController(IAngelicClient angelicClient) : ControllerBase
{
    [HttpGet("[action]")]
    public async Task<IActionResult> GetFromHalo([FromHeader] string endpoint)
    {
        Ticket result = await angelicClient.GetAsync<Ticket>(endpoint);
        
        return Ok(result);
    }
}