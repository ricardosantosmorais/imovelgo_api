using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ImovelGo.Infrastructure.EntityFrameworkDataAccess
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<ImovelGoContext>
    {
        public ImovelGoContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ImovelGoContext> builder = new DbContextOptionsBuilder<ImovelGoContext>();
            return new ImovelGoContext(builder.Options);
        }
    }
}
