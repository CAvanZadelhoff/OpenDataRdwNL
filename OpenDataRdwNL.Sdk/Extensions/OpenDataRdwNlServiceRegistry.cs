using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using OpenDataRdwNL.Models;
using OpenDataRdwNL.Sdk.ApiProviders;
using OpenDataRdwNL.Sdk.ApiProviders.Contracts;
using OpenDataRdwNL.Sdk.Services;
using OpenDataRdwNL.Sdk.Services.Contracts;
using OpenDataRdwNL.Sdk.Utility;

namespace OpenDataRdwNL.Sdk.Extensions
{
    public static class OpenDataRdwNlServiceRegistry
    {
        public static void AddOpenDataRdwNlServices(this IServiceCollection services, Action<OpenDataRdwNlOptions> action)
        {
            services.AddTransient(x =>
            {
                var a = x.GetRequiredService<IOptionsMonitor<OpenDataRdwNlOptions>>();
                return a.CurrentValue;
            });
            
            services.Configure<OpenDataRdwNlOptions>(action);

            services.AddScoped<ISodaResourceHelper, SodaResourceHelper>();
            services.AddScoped<ISodaQueryHelper, SodaQueryHelper>();
            services.AddScoped<ISodaRequestHelper, SodaRequestHelper>();
            services.AddScoped<ISodaTokenHelper, SodaTokenHelper>();
            services.AddHttpClient();
            services.AddScoped<IOpenDataRdwNlApiProvider, OpenDataRdwNlApiProvider>();
            services.AddScoped<IOpenDataRdwNlService, OpenDataRdwNlService>();
            services.AddScoped<IOpenDataRdwEnService, OpenDataRdwEnService>();
        }
    }
}