using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using OpenDataRdwNL.Models;
using OpenDataRdwNL.Sdk.ApiProviders;
using OpenDataRdwNL.Sdk.ApiProviders.Contracts;
using OpenDataRdwNL.Sdk.Services;
using OpenDataRdwNL.Sdk.Services.Contracts;
using OpenDataRdwNL.Sdk.Utility;

namespace OpenDataRdwNL.Test.IntergrationTests
{
    public class BasicConfig
    {
        protected readonly IOpenDataRdwNlService SdkService;

        protected BasicConfig()
        {
            var hostBuilder = new HostBuilder()
                .ConfigureWebHost(webHost =>
                {
                    webHost.UseTestServer();
                    webHost.UseEnvironment("Test");
                    webHost.UseStartup<StartupFake>();
                });
                    
            
            var host = hostBuilder.Start();
            var testClient = host.GetTestClient();
            var configOptions = new OpenDataRdwNlOptions()
            {
                AppToken = "<Add_YOUR_APP_TOKEN>",
                OpenDataRdwNlServiceAddress = "https://opendata.rdw.nl",
                OpenDataRdwNlLanguage = OpenDataRdwNlLanguage.En
            };

            ISodaResourceHelper sodaResourceHelper = new SodaResourceHelper();
            ISodaQueryHelper sodaQueryHelper = new SodaQueryHelper();
            ISodaRequestHelper sodaRequestHelper = new SodaRequestHelper(sodaResourceHelper);
            ISodaTokenHelper sodaTokenHelper = new SodaTokenHelper();
            IOpenDataRdwNlApiProvider apiProvider =
                new OpenDataRdwNlApiProvider(configOptions, sodaRequestHelper, sodaQueryHelper, sodaTokenHelper);
            
            SdkService = new OpenDataRdwNlService(configOptions,apiProvider);
        }
    }
}