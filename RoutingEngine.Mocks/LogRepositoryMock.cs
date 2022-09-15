using RoutingEngine.Domain.Entities;
using RoutingEngine.Domain.Repositories;

namespace RoutingEngine.Mocks;

public class LogRepositoryMock : ILogRepository
{
    public void Create(LogEntry logEntry)
    {
        
    }

    public Task<IEnumerable<LogEntry>> GetAll(CancellationToken cancellationToken)
    {
        var logEntry = new LogEntry
        {
            Id = Guid.NewGuid(),
            CreationTime = DateTime.Now,
            Destination = "Hamburg",
            Origin = "Berlin",
            Distance = 100,
            Price = 50,
            TravelTime = 14,
            
        };
        return Task.FromResult<IEnumerable<LogEntry>>( new LogEntry[] { logEntry });
    }
}