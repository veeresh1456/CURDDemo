using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CURDDemo.Infrastructure.Persistence
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var identityDbContext = scope.ServiceProvider.GetRequiredService<DemoDbContext>();

                identityDbContext.Database.Migrate();
            }

            return host;
        }
    }
}
