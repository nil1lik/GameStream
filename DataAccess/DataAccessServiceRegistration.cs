using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;
using DataAccess.Concretes.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        {
            services.AddDbContext<GameStreamDbContext>();
            services.AddScoped<IGameDal, EfGameDal>();
            services.AddScoped<IGameDetailDal, EfGameDetailDal>();
            services.AddScoped<IGameImageDal, EfGameImageDal>();
            services.AddScoped<IStreamerDal, EfStreamerDal>();
            services.AddScoped<IStreamingDal, EfStreamingDal>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IUserGameDal, EfUserGameDal>();

            return services;
        }
    }
}
