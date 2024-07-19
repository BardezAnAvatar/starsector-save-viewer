using SystemFinder.Model.Data;

namespace SystemFinder.Abstractions.View
{
    public interface ITreeViewPopulator
    {
        List<TreeNode> BuildNodes(GalaxyData data);
    }
}