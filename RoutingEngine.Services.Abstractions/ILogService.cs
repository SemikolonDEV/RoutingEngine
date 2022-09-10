using RoutingEngine.Contracts;
using RoutingEngineBackend.DTOS;

namespace RoutingEngine.Services.Abstractions
{
    public interface ILogService
    {

        public Task<LogDTO> CreateLog(LogForCreationDTO logDTO, CancellationToken cancellationToken = default);

    }
}