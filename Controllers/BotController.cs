using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using Microsoft.Bot.Schema;

[Route("api/messages")]
[ApiController]
public class BotController : ControllerBase
{
    private readonly IBot _bot;
    private readonly IBotFrameworkHttpAdapter _adapter;

    public BotController(IBot bot, IBotFrameworkHttpAdapter adapter)
    {
        _bot = bot;
        _adapter = adapter;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Activity activity)
    {
        if (activity == null)
        {
            return BadRequest();
        }

        await _adapter.ProcessAsync(Request, Response, _bot);
        return Ok();
    }
}
