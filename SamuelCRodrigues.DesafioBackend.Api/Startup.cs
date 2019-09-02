using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Refit;
using SamuelCRodrigues.DesafioBackend.Application;
using SamuelCRodrigues.DesafioBackend.Application.Service;
using SamuelCRodrigues.DesafioBackend.Application.ViewModel;
using SamuelCRodrigues.DesafioBackend.Interface.Application;
using SamuelCRodrigues.DesafioBackend.Interface.Domain;
using SamuelCRodrigues.DesafioBackend.Interface.Service;

namespace SamuelCRodrigues.DesafioBackend.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddHttpClient<IExameService, ExameService>(c => {
                c.BaseAddress = new Uri("http://www.mocky.io");
            });

            services.AddTransient<IExameApplication, ExameApplication>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
