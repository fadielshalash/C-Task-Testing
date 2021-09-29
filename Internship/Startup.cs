using Internship.Moudels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Internship
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddService(Configuration);
            //services.AddDbContext<AppDbContext>(Config =>
            //Config.UseSqlServer(Configuration.GetConnectionString("DefaultConnecetion")));
            //services.AddScoped<IuserRepo, UserRepo>();
            //services.AddScoped<IPostRep, PostRepo>();
            //services.AddAutoMapper(typeof(User), typeof(UserVeiwModel));
            //services.AddAutoMapper(typeof(Post), typeof(PostVeiwModel));
            //services.AddAutoMapper(typeof(Startup));
            //services.AddControllersWithViews();


            //services.AddControllers();

            //services.AddSwaggerGen(options =>
            //{
            //    options.SwaggerDoc("V1",
            //        new Microsoft.OpenApi.Models.OpenApiInfo
            //        {
            //            Title = "Swagger API",
            //            Description = "API Swagger",
            //            Version = "V1"
            //        }
            //        );
            //    //var filename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            //    //var filepath = Path.Combine(AppContext.BaseDirectory, filename);
            //    //options.IncludeXmlComments(filepath);

            //});
            //services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(options =>

            {
                options.SwaggerEndpoint("/swagger/V1/swagger.json", "Swagger Demo API");
            }

            );
            //app.UseMiddleware();

            app.Run(async context =>
            {
                await context.Response.WriteAsync("ex");
            });
        }
    }
}
