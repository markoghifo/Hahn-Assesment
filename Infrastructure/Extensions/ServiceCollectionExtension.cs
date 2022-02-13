using Business.Data.Abstract;
using Business.Models.Responses.Errors;
using DataAccess.Context;
using DataAccess.Data;
using DataAccess.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDatabaseService(this IServiceCollection service, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            //service.AddIdentity<IdentityUser, IdentityRole>(
            //        options =>
            //        {
            //            options.SignIn.RequireConfirmedAccount = false;

            //            //Other options go here
            //        }
            //        )
            //    .AddEntityFrameworkStores<AuthenticationDbContext>();

            service.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            service.AddScoped<IUnitOfWork, UnitOfWork>();

            // service.AddScoped(typeof(IUnitOfWork), u =>
            // {
            //     var context = u.GetService<DataContext>();
            //     return new UnitOfWork(context);
            // });


            return service;
        }

        public static IServiceCollection AddServices(this IServiceCollection service, IConfiguration configuration, string envName = null)
        {
            //service.AddIdentityServices(Configuration);


            service.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = actionContext =>
                {
                    var errors = actionContext.ModelState
                                    .Where(e => e.Value.Errors.Count > 0)
                                    .SelectMany(x => x.Value.Errors)
                                    .Select(x => x.ErrorMessage).ToArray();

                    var errorResponse = new ApiValidationErrorResponse
                    {
                        Errors = errors
                    };

                    return new BadRequestObjectResult(errorResponse);
                };
            });

            //service.AddSwaggerDocumentation();
            service.AddSwaggerGen();

            service.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });

            return service;
        }

        // public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        // {
        //     services.AddScoped<IUnitOfWork, UnitOfWork>();
        //     //services.AddTransient<IMobileMoneyRequestRepository, MobileMoneyRequestRepository>();
        //     //services.AddTransient<IMpesaTranDetailsRepository, MpesaTranDetailsRepository>();
        //     return services;
        // }
    }
}
