using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

[ApiController]
[Route("/")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;
    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Returns a hello world message.
    /// </summary>
    /// <returns>A string message "Hello, World!"</returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<string> GetHello()
    {
        _logger.LogInformation($"GET / was called");
        return Ok("Hello, World!");
    }

    /// <summary>
    /// Returns a personalized greeting.
    /// </summary>
    /// <param name="name">The name to greet</param>
    [HttpGet("hello/{name}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<string> GetHelloWithName(string name)
    {
        _logger.LogInformation($"GET /hello/{name} was called with name: {name}");

        if (string.IsNullOrWhiteSpace(name))
        {
            _logger.LogWarning("Name was empty or whitespace");
            return BadRequest("Name cannot be empty.");
        }

        return Ok($"Hello, {name}!");
    }
}