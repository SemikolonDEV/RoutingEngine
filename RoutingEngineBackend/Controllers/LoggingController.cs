using Microsoft.AspNetCore.Mvc;
using RoutingEngine.Contracts;
using RoutingEngine.Services.Abstractions;
using RoutingEngineBackend.DTOS;

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
    public async Task<ActionResult<LogDTO>> CreateLog([FromBody] LogForCreationDTO logForCreationDTO, CancellationToken cancellationToken = default)
    {
        var logDto =  await _logService.CreateLog(logForCreationDTO, cancellationToken);

        return Created("", logDto);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<LogDTO>>> GetAllLogs(CancellationToken cancellationToken = default)
    {
        var logDtos = await _logService.GetLogs(cancellationToken);

        return Ok(logDtos);
    }


}
