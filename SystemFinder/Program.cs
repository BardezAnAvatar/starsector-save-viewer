using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using SystemFinder.DependencyRegistration;

namespace SystemFinder
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            var serviceProvider = host.Services;

            Application.Run(serviceProvider.GetRequiredService<Main>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            var builder = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddLazyResolution();   //used to avoid circular references during construction
                    services.AddXmlReaders();
                    services.AddViewSupport();
                    services.AddTransient<Main>();
                });

            builder.UseSerilog((context, configuration) =>
            {
                const string serilogFileSinkPath = "Serilog:WriteTo:FileSink:Args:path";
                if (context.Configuration.GetSection(serilogFileSinkPath).Exists())
                {
                    var filePath = context.Configuration[serilogFileSinkPath];
                    if (filePath is not null)
                    {
                        context.Configuration[serilogFileSinkPath] = filePath.Replace("{timestamp}", DateTime.Now.ToString("yyyyMMdd_HHmmss"));
                    }
                }

                configuration.ReadFrom.Configuration(context.Configuration);
            });

            return builder;
        }
    }
}