using FluentAssertions;
using RoutingEngine.Mocks;
using RoutingEngine.Services;
using RoutingEngineBackend.DTOS;

namespace RoutingEngine.Tests;

public class LogServiceTest
{

    [Fact]
    public async void LogService_GetLogs_Valid()
    {
        // Arrange
        var logRepository = new LogRepositoryMock();
        var unitOfWork = new UnitOfWorkMock();
        var logService = new LogService(logRepository, unitOfWork);
        // Act
        var logs = await logService.GetLogs();
        // Assert
        logs.Count().Should().Be(1);
    }

}