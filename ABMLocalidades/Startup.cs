using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ABMLocalidades.Controllers;
using ABMLocalidades.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ABMLocalidades
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

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            string ABMLocalidades = Configuration.GetConnectionString("ABMLocalidades");
            services.AddScoped<IUsuariosRepository, UsuariosRepository>(s => new UsuariosRepository(ABMLocalidades));
            services.AddScoped<ILocalidadesRepository, LocalidadesRepository>(s => new LocalidadesRepository(ABMLocalidades));
            //services.AddScoped<IAppDbContext, AppDbContext>(s => new AppDbContext(ABMLocalidades));
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
        }
    }
}
