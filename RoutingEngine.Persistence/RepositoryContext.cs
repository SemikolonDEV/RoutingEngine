using Microsoft.EntityFrameworkCore;
using RoutingEngine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutingEngine.Persistence
{
    public class RepositoryContext : DbContext
    {

        public DbSet<LogEntry> Log { get; set; }

        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

    }
}
