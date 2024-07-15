using Microsoft.Extensions.DependencyInjection;
using SystemFinder.Logic.CampaignIO.Readers;
using SystemFinder.Logic.CampaignIO.Readers.Model;

namespace SystemFinder.Logic
{
    internal static class DependencyRegistrationExtensions
    {
        public static void AddXmlReaders(this IServiceCollection services)
        {
            services.AddSingleton<CampaignIoLogic>();

            services.AddSingleton<CampaignEngineReader>();
            services.AddSingleton<CentReader>();
            services.AddSingleton<cL_Reader>();
            services.AddSingleton<CommDirectoryReader>();
            services.AddSingleton<ConReader>();
            services.AddSingleton<dL_Reader>();
            services.AddSingleton<e_Reader>();
            services.AddSingleton<EconomyReader>();
            services.AddSingleton<EntryReader>();
            services.AddSingleton<f_Reader>();
            services.AddSingleton<FleetReader>();
            services.AddSingleton<GenesisStationIntelReader>();
            services.AddSingleton<HyperspaceReader>();
            services.AddSingleton<ImmigrationModifiersReader>();
            services.AddSingleton<IndustriesReader>();
            services.AddSingleton<LocationTokenReader>();
            services.AddSingleton<m_Reader>();
            services.AddSingleton<MarketReader>();
            services.AddSingleton<MetadataReader>();
            services.AddSingleton<OfficerManagerEventReader>();
            services.AddSingleton<OrbitReader>();
            services.AddSingleton<PersonReader>();
            services.AddSingleton<PlanetReader>();
            services.AddSingleton<PrimaryEntityReader>();
            services.AddSingleton<RouteDataReader>();
            services.AddSingleton<RtSegReader>();
            services.AddSingleton<s_Reader>();
            services.AddSingleton<SavedObjectReader>();
            services.AddSingleton<ScriptReader>();
            services.AddSingleton<SstmReader>();
            services.AddSingleton<StarSystemsReader>();
            services.AddSingleton<t_Reader>();
            services.AddSingleton<WarSimScriptReader>();

            services.AddSingleton<StarSystemReader>();
        }
    }
}
