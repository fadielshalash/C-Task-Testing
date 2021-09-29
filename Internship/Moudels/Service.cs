//using AutoMapper.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internship.Moudels
{
    public static class Service
    {
        
        public static  void AddService(this IServiceCollection serv, IConfiguration configuration)
        {
            serv.AddDbContext<AppDbContext>(Config =>
            Config.UseSqlServer(configuration.GetConnectionString("DefaultConnecetion")));

            serv.AddScoped<IuserRepo, UserRepo>();

            serv.AddScoped<IPostRep, PostRepo>();

            serv.AddAutoMapper(typeof(User), typeof(UserVeiwModel));

            serv.AddAutoMapper(typeof(Post), typeof(PostVeiwModel));
            
            serv.AddAutoMapper(typeof(Startup));
            
            serv.AddControllersWithViews();

            serv.AddControllers();

            serv.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("V1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = "Swagger API",
                        Description = "API Swagger",
                        Version = "V1"
                    }
                    );
            });
            serv.AddControllers();
        }
    }
}
