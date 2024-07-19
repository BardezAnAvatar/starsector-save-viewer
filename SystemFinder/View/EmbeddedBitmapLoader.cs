using System.Reflection;
using SystemFinder.Abstractions.View;

namespace SystemFinder.View
{
    public class EmbeddedBitmapLoader : IEmbeddedBitmapLoader
    {
        /// <summary>
        ///     Load a new icon bitmap from embedded resources.
        ///     For the BitmapImage, make sure you reference 
        ///     WindowsBase and PresentationCore, and import 
        ///     the System.Windows.Media.Imaging namespace. 
        /// </summary>
        /// <remarks>https://thebuildingcoder.typepad.com/blog/2012/06/retrieve-embedded-resource-image.html</remarks>
        public Image? ResourceImage(Assembly a, string imageName)
        {
            Image? img = default;
            var steam = a.GetManifestResourceStream("SystemFinder.assets." + imageName);

            if (steam is not null)
            {
                img = Bitmap.FromStream(steam);
            }

            return img;
        }
    }
}
