using SystemFinder.Model.Data;

namespace SystemFinder.Logic.Abstractions
{
    public interface ICampaignIoLogic
    {
        GalaxyData ReadSave(Stream file);
    }
}