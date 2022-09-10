using RoutingEngine.Contracts;
using RoutingEngine.Domain.Entities;
using RoutingEngine.Domain.Repositories;
using RoutingEngine.Services.Abstractions;
using RoutingEngineBackend.DTOS;

namespace RoutingEngine.Services
{
    public class LogService : ILogService
    {

        private readonly ILogRepository _logRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LogService(ILogRepository logRepository, IUnitOfWork unitOfWork)
        {
            _logRepository = logRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<LogDTO> CreateLog(LogForCreationDTO logDTO, CancellationToken cancellationToken = default)
        {
            var logEntry = new LogEntry
            {
                CreationTime = DateTime.Now,
                Destination = logDTO.Destination,
                Origin = logDTO.Origin,
                Distance = logDTO.Distance,
                Price = logDTO.Price,
                TravelTime = logDTO.TravelTime,
            };
            _logRepository.Create(logEntry);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return new LogDTO
            {
                Id = logEntry.Id,
                CreationTime = logEntry.CreationTime,
                Destination = logEntry.Destination,
                Origin = logEntry.Origin,
                Distance = logEntry.Distance,
                Price = logEntry.Price,
                TravelTime = logEntry.TravelTime,
            };
        }
    }
}