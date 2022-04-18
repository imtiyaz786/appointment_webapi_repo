using AppointmentMicroservice.Data;
using AppointmentMicroservice.Mapper;
using AppointmentMicroservice.Repository;
using AppointmentMicroservice.Repository.IRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationMicroservice.Repository;
using VaccinationMicroservice.Repository.IRepository;

namespace AppointmentMicroservice
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
            services.AddControllers();

            services.AddAutoMapper(typeof(Mappers));
           
            services.AddScoped<IAppointmentRepository, AppointmentRepository>();


            services.AddScoped<IVaccinationRepository, VaccinationRepository>();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DbConnection")));


            services.AddSwaggerGen(c => {
                c.SwaggerDoc("AppointmentMicroservice",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "Appointment Microservice",
                        Version = "1",
                        Description = "Appointments and Vaccinations"
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/AppointmentMicroservice/swagger.json", "AppointmentMicroservice");
                options.RoutePrefix = "";
            });

            app.UseRouting();

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });

            app.UseAuthorization();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
