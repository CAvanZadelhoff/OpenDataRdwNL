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

            services.AddSingleton<ISodaResourceHelper, SodaResourceHelper>();
            services.AddSingleton<ISodaQueryHelper, SodaQueryHelper>();
            services.AddSingleton<ISodaRequestHelper, SodaRequestHelper>();
            services.AddSingleton<ISodaTokenHelper, SodaTokenHelper>();
            
            services.AddHttpClient<IOpenDataRdwNlApiProvider, OpenDataRdwNlApiProvider>();
            services.AddSingleton<IOpenDataRdwNlService, OpenDataRdwNlService>();
        }
    }
}