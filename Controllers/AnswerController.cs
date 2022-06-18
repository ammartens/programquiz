using Microsoft.AspNetCore.Mvc;

namespace programquiz.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnswerController : ControllerBase
{
    private readonly ILogger<AnswerController> _logger;

    public AnswerController(ILogger<AnswerController> logger)
    {
        _logger = logger;
    }

    [HttpPost("userresult/{percentage}")]
    public IActionResult UserResult(int percentage)
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult GetResult(int percentage)
    {
        return Ok(69);
    }
}
