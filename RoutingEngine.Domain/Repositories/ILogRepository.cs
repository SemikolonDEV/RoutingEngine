using RoutingEngine.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutingEngine.Domain.Repositories;

public interface ILogRepository
{

    public void Create(LogEntry logEntry);

}
