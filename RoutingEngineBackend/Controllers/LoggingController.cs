using Microsoft.AspNetCore.Mvc;
using RoutingEngine.Contracts;
using RoutingEngine.Services.Abstractions;

namespace RoutingEngineBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoggingController : ControllerBase
{

    public readonly ILogService _logService;

    public LoggingController(ILogService logService)
    {
        _logService = logService;
    }


    [HttpPost]
    public async Task<IActionResult> CreateLog([FromBody] LogForCreationDTO logForCreationDTO, CancellationToken cancellationToken = default)
    {
        var logDto =  await _logService.CreateLog(logForCreationDTO, cancellationToken);

        return Created("", logDto);
    }


}
