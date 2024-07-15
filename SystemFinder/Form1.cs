using SystemFinder.Logic;
using SystemFinder.Logic.Abstractions;

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
                Stream file = openFileDialog1.OpenFile();
                var results = _campaignIo.ReadSave(file);
            }
        }
    }
}
