using System.Reflection;
using SystemFinder.Logic;
using SystemFinder.Logic.Abstractions;
using SystemFinder.View;

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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                toolStripStatusLabel2.Text = openFileDialog1.FileName;
                statusStrip1.Visible = true;

                try
                {
                    using Stream file = openFileDialog1.OpenFile();
                    var results = _campaignIo.ReadSave(file);

                    treeViewSystems.SuspendLayout();
                    treeViewSystems.Nodes.Clear();
                    treeViewSystems.ImageList?.Images?.Clear();
                    AddImagesToTreeView();

                    //since we are handling star systems, use that
                    foreach (var starSystem in results.StarSystems)
                    {
                        TreeNode system = new TreeNode(starSystem.Value.Name, 0, 0);
                        treeViewSystems.Nodes.Add(system);
                    }
                    treeViewSystems.ResumeLayout();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void AddImagesToTreeView()
        {
            treeViewSystems.ImageList = new ImageList();
            var starSystem = EmbeddedBitmapLoader.ResourceImage(Assembly.GetExecutingAssembly(), "star-system.png");

            if (starSystem is not null)
            {
                treeViewSystems.ImageList.Images.Add(starSystem);
            }
        }
    }
}
