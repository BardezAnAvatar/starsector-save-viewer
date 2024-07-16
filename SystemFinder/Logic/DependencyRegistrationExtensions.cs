using Microsoft.Extensions.DependencyInjection;
using SystemFinder.Logic.Abstractions;
using SystemFinder.Logic.CampaignIO.Readers;
using SystemFinder.Logic.CampaignIO.Readers.Abstractions;
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
            services.AddSingleton<ICentReader, CentReader>();
            services.AddSingleton<IcL_Reader, cL_Reader>();
            services.AddSingleton<ICommDirectoryReader, CommDirectoryReader>();
            services.AddSingleton<IConReader, ConReader>();
            services.AddSingleton<IdL_Reader, dL_Reader>();
            services.AddSingleton<Ie_Reader, e_Reader>();
            services.AddSingleton<IEconomyReader, EconomyReader>();
            services.AddSingleton<IEntryReader, EntryReader>();
            services.AddSingleton<If_Reader, f_Reader>();
            services.AddSingleton<IFleetReader, FleetReader>();
            services.AddSingleton<IGenesisStationIntelReader, GenesisStationIntelReader>();
            services.AddSingleton<IHyperspaceReader, HyperspaceReader>();
            services.AddSingleton<IImmigrationModifiersReader, ImmigrationModifiersReader>();
            services.AddSingleton<IIndustriesReader, IndustriesReader>();
            services.AddSingleton<ILocationTokenReader, LocationTokenReader>();
            services.AddSingleton<Im_Reader, m_Reader>();
            services.AddSingleton<IMarketReader, MarketReader>();
            services.AddSingleton<IMetadataReader, MetadataReader>();
            services.AddSingleton<IOfficerManagerEventReader, OfficerManagerEventReader>();
            services.AddSingleton<IOrbitReader, OrbitReader>();
            services.AddSingleton<IPersonReader, PersonReader>();
            services.AddSingleton<IPlanetReader, PlanetReader>();
            services.AddSingleton<IPrimaryEntityReader, PrimaryEntityReader>();
            services.AddSingleton<IRouteDataReader, RouteDataReader>();
            services.AddSingleton<IRtSegReader, RtSegReader>();
            services.AddSingleton<Is_Reader, s_Reader>();
            services.AddSingleton<ISavedObjectReader, SavedObjectReader>();
            services.AddSingleton<IScriptReader, ScriptReader>();
            services.AddSingleton<ISstmReader, SstmReader>();
            services.AddSingleton<IStarSystemsReader, StarSystemsReader>();
            services.AddSingleton<It_Reader, t_Reader>();
            services.AddSingleton<IWarSimScriptReader, WarSimScriptReader>();

            services.AddSingleton<IStarSystemReader, StarSystemReader>();
        }
    }
}
