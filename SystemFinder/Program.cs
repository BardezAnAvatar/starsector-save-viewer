using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SystemFinder.DependencyRegistration;
using SystemFinder.Logic;

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

            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddLazyResolution();   //used to avoid circular references during construction
                    services.AddXmlReaders();
                    services.AddTransient<Form1>();
                });
        }
    }
}