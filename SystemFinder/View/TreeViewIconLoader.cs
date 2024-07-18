using System.Reflection;
using SystemFinder.Abstractions.View;
using SystemFinder.Exceptions;

namespace SystemFinder.View
{
    public class TreeViewIconLoader : ITreeViewIconLoader
    {
        public ImageList LoadTreeViewIcons()
        {
            var imageList = new ImageList();

            //NOTE: Order matters, here. Follow View/EmbeddedBitmapLoader.cs for order
            AddIconToImageList(imageList, "star-system.png");
            AddIconToImageList(imageList, "sun.png");
            AddIconToImageList(imageList, "planet.png");
            AddIconToImageList(imageList, "gate-unscanned.png");
            AddIconToImageList(imageList, "gate-scanned.png");
            AddIconToImageList(imageList, "station.png");

            return imageList;
        }

        private void AddIconToImageList(ImageList imageList, string assetName)
        {
            var starSystem = EmbeddedBitmapLoader.ResourceImage(Assembly.GetExecutingAssembly(), assetName);

            if (starSystem is null)
            {
                throw new TreeViewIconException($"Could not locate {assetName}");
            }

            imageList.Images.Add(starSystem);
        }
    }
}
