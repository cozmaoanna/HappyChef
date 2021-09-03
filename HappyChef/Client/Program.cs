using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Sotsera.Blazor.Toaster.Core.Models;


namespace HappyChef.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient("HappyChef.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("HappyChef.ServerAPI"));

            builder.Services.AddApiAuthorization();
            builder.Services.AddDevExpressBlazor();

            builder.Services.AddToaster(config =>
            {
                //example customizations
                config.PositionClass = Defaults.Classes.Position.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = false;
            });


            await builder.Build().RunAsync();




        }
    }
}
