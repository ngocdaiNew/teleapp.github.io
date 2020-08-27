using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TeleApp.Services;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.Security.Claims;
using TeleApp.Client.Services;
using System.Globalization;
using Microsoft.JSInterop;
using System.Linq;
using Telerik.Blazor.Services;
using TeleApp.Shared.Services;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace TeleApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddLoadingBar();
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }.EnableIntercept(sp));
            builder.Services.AddScoped<WeatherForecastService>();
            builder.Services.AddTelerikBlazor();

            // register a custom localizer for the Telerik components, after registering the Telerik services
            //builder.Services.AddSingleton(typeof(ITelerikStringLocalizer), typeof(ShareResxLocalizer));

            //await builder.Build().RunAsync();
            var host = builder.Build();

            await SetCultureAsync(host);
            host.UseLoadingBar();

            await host.RunAsync();
        }
        private static async Task SetCultureAsync(WebAssemblyHost host)
        {
            var jsRuntime = host.Services.GetRequiredService<IJSRuntime>();
            var cultureName = await jsRuntime.InvokeAsync<string>("blazorCulture.get");

            if (cultureName != null)
            {
                var culture = new CultureInfo(cultureName);

                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }
        }
    }
}
