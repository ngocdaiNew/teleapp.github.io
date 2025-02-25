﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using TeleApp.Server.Data.Services;
using TeleApp.Server.Data;
using System;
using System.Net.Http;
using System.Net.Mime;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using TeleApp.Server.Extensions;
using Telerik.Blazor.Services;
using TeleApp.Shared.Services;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Mvc;

namespace TeleApp.Server
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
            services.AddCors();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddScoped<ILogfileService, LogfileService>();  
            var sqlConnectionConfiguration = new SqlConnectionConfiguration(Configuration.GetConnectionString("SqlDbContext"));  
            services.AddSingleton(sqlConnectionConfiguration);
            //services.AddHttpClient<ILogfileService, LogfileService>();
            services.AddScoped<HttpClient>();
            //services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddSingleton(typeof(ITelerikStringLocalizer), typeof(ShareResxLocalizer));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors(
                options => options.WithOrigins("https://teleappxxxyyy.com").AllowAnyMethod()
            );

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            //app.UseMiddleware<CsrfTokenCookieMiddleware>();  

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
