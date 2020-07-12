using Business.Services;
using Common.Interfaces;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Persistence.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Configurations
{
    /// <summary>
    /// Extensions for IServiceCollection interface to be used in Asp.Net Core service configuration.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers application services to the container. 
        /// </summary>
        public static void AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.Configure<RouteOptions>(options =>
            {
                options.LowercaseUrls = true;
                options.LowercaseQueryStrings = true;
                options.AppendTrailingSlash = true;
            });

            //services.AddIdentity<ApplicationUser, IdentityRole>(options => { options.Password.RequiredLength = 10; }).AddEntityFrameworkStores<AppDbContext>();
            //services.AddDbContextPool<AppDbContext>(options => { options.UseSqlServer(config.GetConnectionString("default")); });
            //services.AddScoped(typeof(ICrudRepository<,>), typeof(SqlRespository<,>));
            //services.AddScoped<IToDoService, ToDoService>();
            //services.AddScoped<IKanbanBoardService, KanbanBoardService>();
            //services.AddScoped<INoteService, NoteService>();
            //services.AddScoped<IToDoService, ToDoService>();
            //services.AddScoped<IDesktopMenuService, DesktopMenuService>();
            //services.AddScoped<IAuthService, AuthService>();
        }
    }
}
