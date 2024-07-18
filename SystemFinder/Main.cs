using System.Reflection;
using SystemFinder.Abstractions.Logic;
using SystemFinder.Exceptions;
using SystemFinder.Logic;
using SystemFinder.Model.Data;
using SystemFinder.View;
using MethodInvoker = System.Windows.Forms.MethodInvoker;

namespace SystemFinder
{
    public partial class Main : Form
    {
        private ICampaignIoLogic _campaignIo;

        public Main(ICampaignIoLogic campaignIo)
        {
            InitializeComponent();
            _campaignIo = campaignIo;
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                toolStripStatusLabel2.Text = openFileDialog1.FileName;

                try
                {
                    using Stream file = openFileDialog1.OpenFile();

                    var cancelSource = new CancellationTokenSource();
                    var token = cancelSource.Token;
                    var results = await _campaignIo.ReadSave(file, token).ConfigureAwait(false);

                    // after we've done all the processing, load the control with the appropriate data.
                    // Do this to avoid exception:
                    //      `Cross-thread operation not valid: Control 'treeViewSystems' accessed from a thread other than the thread it was created on.`
                    this.Invoke(new MethodInvoker(delegate
                    {
                        UpdateTreeView(results);
                    }));
                }
                //catch (Exception ex)
                //{
                //}
                finally
                {
                }
            }
        }

        private void SetUpTreeViewImages()
        {
            treeViewSystems.BeginUpdate();
            treeViewSystems.SuspendLayout();
            treeViewSystems.ImageList?.Images?.Clear();
            AddImagesToTreeView();
            treeViewSystems.EndUpdate();
            treeViewSystems.ResumeLayout();
        }

        private void UpdateTreeView(GalaxyData results)
        {
            statusStrip1.Visible = true;
            treeViewSystems.SuspendLayout();
            treeViewSystems.BeginUpdate();
            treeViewSystems.Nodes.Clear();

            //since we are handling star systems, use that
            foreach (var starSystem in results.StarSystems)
            {
                TreeNode system = new TreeNode(starSystem.Value.Name, 0, 0);
                treeViewSystems.Nodes.Add(system);
            }
            treeViewSystems.EndUpdate();
            treeViewSystems.ResumeLayout();
        }

        private void AddImagesToTreeView()
        {
            var imageList = new ImageList();

            //NOTE: Order matters, here. Follow View/EmbeddedBitmapLoader.cs for order
            AddIconToImageList(imageList, "star-system.png");
            AddIconToImageList(imageList, "star.png");
            AddIconToImageList(imageList, "planet.png");
            AddIconToImageList(imageList, "gate-unscanned.png");
            AddIconToImageList(imageList, "gate-scanned.png");
            AddIconToImageList(imageList, "station.png");

            treeViewSystems.ImageList = imageList;
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

        private void Main_Load(object sender, EventArgs e)
        {
            SetUpTreeViewImages();
        }
    }
}
