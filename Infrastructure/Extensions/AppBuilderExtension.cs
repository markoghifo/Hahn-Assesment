using DataAccess.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Extensions
{
    public static class AppBuilderExtension
    {
        public static IApplicationBuilder SetupMigrations(this IApplicationBuilder app, IServiceProvider service)
        {
            var logger = service.GetService<ILogger<DataContext>>();
            try
            {
                var context = service.GetService<DataContext>();
                context?.Database.Migrate();
            }
            catch (Exception ex)
            {
                logger?.LogError(ex, ex.Message);
            }
            return app;
        }
    }
}
