using SystemFinder.Model;

namespace SystemFinder.Logic.Abstractions
{
    public interface ICampaignIoLogic
    {
        List<StarSystem> ReadSave(Stream file);
    }
}