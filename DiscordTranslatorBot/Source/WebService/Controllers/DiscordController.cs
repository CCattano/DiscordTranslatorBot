using Microsoft.AspNetCore.Mvc;

namespace Translator.Web.Service.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class DiscordController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Test()
    {
        return Ok("Okay");
    }
}