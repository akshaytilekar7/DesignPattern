using Microsoft.Extensions.DependencyInjection;
using NinjectDemo.Domain.Interfaces;
using NinjectDemo.Services;
using System;


namespace NinjectDemo.Dependencies
{
    public enum ServiceEnum
    {
        Window,
        Linux,
    }

    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {

            services.AddTransient<UserServiceLinux>();
            services.AddTransient<UserServiceWindows>();

            services.AddTransient<Func<ServiceEnum, IUserService>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case ServiceEnum.Window:
                        return serviceProvider.GetService<UserServiceWindows>();
                    case ServiceEnum.Linux:
                        return serviceProvider.GetService<UserServiceLinux>();
                    default:
                        return null;
                }
            });
        }


    }
}

