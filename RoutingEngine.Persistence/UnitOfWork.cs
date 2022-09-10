using RoutingEngine.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutingEngine.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly RepositoryContext _repositoryContext;

        public UnitOfWork(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await _repositoryContext.SaveChangesAsync(cancellationToken);
        }
    }
}
