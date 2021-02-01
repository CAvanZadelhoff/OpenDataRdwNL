using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using OpenDataRdwNL.Models;
using OpenDataRdwNL.Sdk.Extensions;

namespace OpenDataRdwNL.Test.IntergrationTests
{
    
    
    public class StartupFake
    {
        public StartupFake(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOpenDataRdwNlServices(opt =>
            {
                opt.AppToken = "<Add_YOUR_APP_TOKEN>";
                opt.OpenDataRdwNlServiceAddress = "https://opendata.rdw.nl";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseHttpsRedirection();
        }
    }
}