using HbBlazorConnector.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MatBlazor;
using HB.RestAPI.Core;
using HB.RestAPI.Core.Interfaces;
using HB.RestAPI.Core.Models;
using HB.RestAPI.Core.Services;
using HB.RestAPI.Core.Settings;

namespace HbBlazorConnector
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMatBlazor();
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSingleton<WeatherForecastService>();
            services.AddScoped<HttpClient>();
            services.AddSingleton<ISerializer, JsonSerializer>();
            services.AddSingleton<HBApiClient>();
            services.AddSingleton<HbApiEndPoints>();
            services.AddSingleton<IHbFactory, HbObjectFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
