using SystemFinder.Model.Data;

namespace SystemFinder.Abstractions.Logic
{
    public interface ICampaignIoLogic
    {
        Task<GalaxyData> ReadSave(Stream file, CancellationToken cancellation);
    }
}