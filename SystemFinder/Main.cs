using SystemFinder.Abstractions.Logic;
using SystemFinder.Abstractions.View;
using SystemFinder.Model.Data;
using MethodInvoker = System.Windows.Forms.MethodInvoker;

namespace SystemFinder
{
    public partial class Main : Form
    {
        private ICampaignIoLogic _campaignIo;
        private ITreeViewIconLoader _treeViewIconLoader;
        private ITreeViewPopulator _treeViewPopulator;

        public Main(ICampaignIoLogic campaignIo, ITreeViewIconLoader treeViewIconLoader, ITreeViewPopulator treeViewPopulator)
        {
            InitializeComponent();
            _campaignIo = campaignIo;
            _treeViewIconLoader = treeViewIconLoader;
            _treeViewPopulator = treeViewPopulator;
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
                        statusStrip1.Visible = true;
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
            treeViewSystems.SuspendLayout();
            treeViewSystems.BeginUpdate();
            
            treeViewSystems.ImageList?.Images?.Clear();
            var imageList = _treeViewIconLoader.LoadTreeViewIcons();
            treeViewSystems.ImageList = imageList;

            treeViewSystems.EndUpdate();
            treeViewSystems.ResumeLayout();
        }

        private void UpdateTreeView(GalaxyData results)
        {
            treeViewSystems.SuspendLayout();
            treeViewSystems.BeginUpdate();

            treeViewSystems.Nodes.Clear();

            var nodes = _treeViewPopulator.BuildNodes(results);
            treeViewSystems.Nodes.AddRange([.. nodes]);
            treeViewSystems.ExpandAll();

            treeViewSystems.EndUpdate();
            treeViewSystems.ResumeLayout();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SetUpTreeViewImages();
        }
    }
}
