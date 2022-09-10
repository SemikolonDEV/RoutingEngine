using RoutingEngine.Domain.Entities;
using RoutingEngine.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutingEngine.Persistence
{
    public class LogRespository : ILogRepository
    {

        private readonly RepositoryContext _repositoryContext;

        public LogRespository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Create(LogEntry logEntry)
        {
            _repositoryContext.Add(logEntry);
        }
    }
}
