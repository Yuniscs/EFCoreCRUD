using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MovieLibraryApi.Domain;
using MovieLibraryApi.Interfaces;
using MovieLibraryApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MovieLibraryApi
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
            string connection = @"Data Source=WIN-PSBFAS1N9S1\SQLEXPRESS;Initial Catalog=MovieeeDb;Integrated Security=True";
            services.AddDbContext<MovieDB>(options => options.UseSqlServer(connection));
            //@"Data Source=WIN-PSBFAS1N9S1\SQLEXPRESS;Initial Catalog=EnrollmentDb;Integrated Security=True"
            //string connection = @"Server = WIN - PSBFAS1N9S1\SQLEXPRESS; Database = EnrollmentDb; Trusted_Connection = True";
            //services.AddDbContext<MovieDB>(options => options.UseSqlServer(connection));
            //@"Server=WIN-PSBFAS1N9S1\SQLEXPRESS;Database=PostCommentDb;Trusted_Connection=True"

            services.AddAutoMapper(typeof(Mapping));
            //services.AddControllers().AddJsonOptions(
               // x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            
            services.AddScoped<IActors, ActorService>();
            services.AddScoped<IMovie, MovieService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MovieLibraryApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MovieLibraryApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
