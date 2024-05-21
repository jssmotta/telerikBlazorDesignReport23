namespace TelerikReportingRestService1;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}

internal static class ConfigurationHelper
{
    public static IConfiguration ResolveConfiguration(IWebHostEnvironment environment)
    {
        var reportingConfigFileName = System.IO.Path.Combine(environment.ContentRootPath, "appsettings.json");
        return new ConfigurationBuilder()
            .AddJsonFile(reportingConfigFileName, true)
            .Build();
    }
}
