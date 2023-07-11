﻿using BookShare.Appliation.common;
using BookShare.Persistence.Common;
using BookShare.ServiceRepository.Interfaces;
using BookShare.ServiceRepository.Services;
using LoggerService;
using Microsoft.EntityFrameworkCore;

namespace BookShare.WebAPI.Extentions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services) 
        { 
            services.AddCors(option =>
            {
                option.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services) => services.Configure<IISOptions>(options => { });

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(option =>
            option.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        }
    }
}
