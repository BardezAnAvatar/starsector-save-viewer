using Microsoft.Extensions.DependencyInjection;
using SystemFinder.Abstractions.Logic;
using SystemFinder.Abstractions.Logic.CampaignIO;
using SystemFinder.Abstractions.Logic.CampaignIO.Readers;
using SystemFinder.Abstractions.View;
using SystemFinder.Logic;
using SystemFinder.Logic.CampaignIO;
using SystemFinder.Logic.CampaignIO.Readers.Model;
using SystemFinder.View;

namespace SystemFinder.DependencyRegistration
{
    internal static class DependencyRegistrationExtensions
    {
        public static void AddXmlReaders(this IServiceCollection services)
        {
            services.AddSingleton<ICampaignIoLogic, CampaignIoLogic>();

            services.AddSingleton<ICampaignEngineReader, CampaignEngineReader>();

            services.AddSingleton<IGateReader, GateReader>();
            services.AddSingleton<IPlanetReader, PlanetReader>();
            services.AddSingleton<IStarReader, StarReader>();
            services.AddSingleton<IStarSystemReader, StarSystemReader>();
        }

        public static void AddViewSupport(this IServiceCollection services)
        {
            services.AddSingleton<IEmbeddedBitmapLoader, EmbeddedBitmapLoader>();
            services.AddSingleton<ITreeViewIconLoader, TreeViewIconLoader>();
            services.AddSingleton<ITreeViewPopulator, TreeViewPopulator>();
        }
    }
}
