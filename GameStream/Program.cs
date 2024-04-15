using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;

namespace GameStream
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IGameService, GameManager>();
            builder.Services.AddScoped<IGameDal, EfGameDal>();

            builder.Services.AddScoped<IGameDetailService, GameDetailManager>();
            builder.Services.AddScoped<IGameDetailDal, EfGameDetailDal>();

            builder.Services.AddScoped<IGameImageService, GameImageManager>();
            builder.Services.AddScoped<IGameImageDal, EfGameImageDal>();

            builder.Services.AddScoped<IStreamerService, StreamerManager>();
            builder.Services.AddScoped<IStreamerDal, EfStreamerDal>();

            builder.Services.AddScoped<IStreamingService, StreamingManager>();
            builder.Services.AddScoped<IStreamingDal, EfStreamingDal>();

            builder.Services.AddScoped<IUserService, UserManager>();
            builder.Services.AddScoped<IUserDal, EfUserDal>();

            builder.Services.AddScoped<IUserGameService, UserGameManager>();
            builder.Services.AddScoped<IUserGameDal, EfUserGameDal>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
