using System.Reflection;
using SystemFinder.Logic;
using SystemFinder.Logic.Abstractions;
using SystemFinder.View;

namespace SystemFinder
{
    public partial class Form1 : Form
    {
        private ICampaignIoLogic _campaignIo;

        public Form1(ICampaignIoLogic campaignIo)
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
                    treeViewSystems.Nodes.Clear();
                    treeViewSystems.ImageList?.Images?.Clear();
                    AddImagesToTreeView();

                    //since we are handling star systems, use that
                    foreach (var starSystem in results.StarSystems)
                    {
                        TreeNode system = new TreeNode(starSystem.Value.Name, 0, 0);
                        treeViewSystems.Nodes.Add(system);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void AddImagesToTreeView()
        {
            treeViewSystems.ImageList = new ImageList();
            treeViewSystems.ImageList.Images.Add(EmbeddedBitmapLoader.ResourceImage(Assembly.GetExecutingAssembly(), "star-system.png"));
        }
    }
}
