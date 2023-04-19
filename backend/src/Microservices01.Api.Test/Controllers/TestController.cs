using Microsoft.AspNetCore.Mvc;
using Microservices01.Common.Services;

namespace microservices01.api;

[Route("[controller]")]
[ApiController]
public class TestController : ControllerBase
{
  private readonly ITestService _userService;

  public TestController(ITestService userService)
  {
    _userService = userService;
  }

  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    await Task.CompletedTask;
    return StatusCode(StatusCodes.Status200OK, "OK");
  }

  [HttpGet("{id}")]
  public async Task<IActionResult> Get (int id)
  {
    var result = await _userService.GetByIdAsync(id);
    return StatusCode(StatusCodes.Status200OK, result);
  }

  [HttpPost]
  public async Task<IActionResult> Post()
  {
    await Task.CompletedTask;
    return StatusCode(StatusCodes.Status201Created);
  }

  [HttpPut]
  public async Task<IActionResult> Put()
  {
    await Task.CompletedTask;
    return StatusCode(StatusCodes.Status500InternalServerError);
  }

  [HttpDelete]
  public async Task<IActionResult> Delete()
  {
    await Task.CompletedTask;
    return StatusCode(StatusCodes.Status401Unauthorized);
  }
}