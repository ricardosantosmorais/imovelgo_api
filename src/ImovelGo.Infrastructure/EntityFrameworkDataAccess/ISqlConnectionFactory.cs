using System;
using System.Data;

namespace ImovelGo.Infrastructure.EntityFrameworkDataAccess
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetOpenConnection();
    }
}
