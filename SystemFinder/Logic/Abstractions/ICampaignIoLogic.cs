using SystemFinder.Model.Data;

namespace SystemFinder.Logic.Abstractions
{
    public interface ICampaignIoLogic
    {
        Task<GalaxyData> ReadSave(Stream file, CancellationToken cancellation);
    }
}