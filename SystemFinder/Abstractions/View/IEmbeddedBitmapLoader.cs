using System.Reflection;

namespace SystemFinder.Abstractions.View
{
    public interface IEmbeddedBitmapLoader
    {
        Image? ResourceImage(Assembly a, string imageName);
    }
}