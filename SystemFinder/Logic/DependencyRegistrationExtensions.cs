using Microsoft.Extensions.DependencyInjection;
using SystemFinder.Abstractions.Logic;
using SystemFinder.Abstractions.Logic.CampaignIO;
using SystemFinder.Abstractions.Logic.CampaignIO.Readers;
using SystemFinder.Logic.CampaignIO;
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
