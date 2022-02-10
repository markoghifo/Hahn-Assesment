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
        public static IApplicationBuilder AddSwagger(this IApplicationBuilder app, IServiceProvider service)
        {
            app.UseSwagger(options =>
            {
                options.SerializeAsV2 = true;
            });
            //app.UseSwaggerUI();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                options.RoutePrefix = string.Empty;
            });
            return app;
        }

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
