using Microsoft.Extensions.DependencyInjection;
using SystemFinder.Logic.Abstractions;
using SystemFinder.Logic.CampaignIO;
using SystemFinder.Logic.CampaignIO.Abstractions;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions.Model;
using SystemFinder.Logic.CampaignIO.Readers.Model;

namespace SystemFinder.Logic
{
    internal static class DependencyRegistrationExtensions
    {
        public static void AddXmlReaders(this IServiceCollection services)
        {
            services.AddSingleton<ICampaignIoLogic, CampaignIoLogic>();

            services.AddSingleton<ICampaignEngineReader, CampaignEngineReader>();

            services.AddSingleton<IStarSystemReader, StarSystemReader>();
        }
    }
}
