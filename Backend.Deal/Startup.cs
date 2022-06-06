using System;
using System.IO;
using System.Reflection;
using DealStoreweb.Backend.Deal;
using DealStoreweb.Backend.Models;
//using DealStoreweb.Backend.Provider;
using DealStoreweb.Backend.System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Diagnostics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;
using OpenTelemetry.Exporter;
using OpenTelemetry.Metrics;


namespace DealStoreweb.Backend
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            
            var serviceName = "DealStoreWeb.Backend.Deal";
            var serviceVersion = "1.0.0";
            services.AddOpenTelemetryTracing(b =>
            {
                b
                .AddOtlpExporter(opt =>
                {
                    opt.Endpoint = new Uri("http://otel-collector:4317");
                    //opt.Endpoint = new Uri("http://localhost:4317");
                    opt.Protocol = OtlpExportProtocol.Grpc;

                })
                //Jaeger Exporter 
                //.AddJaegerExporter(o =>
                //{
                //    o.AgentHost = "localhost";
                //    o.AgentPort = 16686; // use port number here
                //})
                //ZipKin Exporter 
                //.AddZipkinExporter(o =>
                //{
                //    o.Endpoint = new Uri("http://localhost:9411");
                //})
                //Prometheus Exporter 
                //.AddPrometheusExporter(options =>
                //{
                //    options.StartHttpListener = true;
                //    // Use your endpoint and port here
                //    options.HttpListenerPrefixes = new string[] { $"http://localhost:{9090}/" };
                //    options.ScrapeResponseCacheDurationMilliseconds = 0;
                //})
                .AddConsoleExporter()
                .AddSource(serviceName)
                .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService(serviceName: serviceName, serviceVersion: serviceVersion))
                .AddHttpClientInstrumentation()
                .AddAspNetCoreInstrumentation()
                .AddSqlClientInstrumentation();
            });
            services.AddOpenTelemetryMetrics(b =>
            {
                b.AddMeter("DealStore.DealsMetrics");
                b.AddOtlpExporter(opt =>
                {
                    opt.Endpoint = new Uri("http://otel-collector:4317");
                    opt.Protocol = OtlpExportProtocol.Grpc;

                });
                b.SetResourceBuilder(ResourceBuilder.CreateDefault().AddService(serviceName: serviceName, serviceVersion: serviceVersion));
                b.AddHttpClientInstrumentation();
                b.AddAspNetCoreInstrumentation();


            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DealHost.at Microservice Project Deal API", Version = "v1.0.1" });

                c.EnableAnnotations();

            });

            services.Configure<DealStoreweb.Backend.DealStoreConfig>(_configuration.GetSection("DealStoreConfig"));
            services.AddDbContext<dealstoreDBContext>(option =>
            {

                var connectionString = _configuration.GetSection("DealStoreConfig").GetSection("DealstoreDB").Value;
                option.UseSqlServer(connectionString);

            });
            services.AddScoped<IDealProvider, DealProvider>();
            //services.AddScoped<IProviderAPI, ProviderAPI>();
            services.AddScoped<ISysAPI, SysAPI>();
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("swagger/v1/swagger.json", "DealStore.at Deal API ");
                c.RoutePrefix = string.Empty;
            });
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .AllowCredentials());
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
