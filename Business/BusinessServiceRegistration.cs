using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IGameService, GameManager>();
            services.AddScoped<IGameDetailService, GameDetailManager>();
            services.AddScoped<IGameImageService, GameImageManager>();
            services.AddScoped<IStreamerService, StreamerManager>();
            services.AddScoped<IStreamingService, StreamingManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserGameService, UserGameManager>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
