using SystemFinder.Logic;

namespace SystemFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                toolStripStatusLabel2.Text = openFileDialog1.FileName;
                statusStrip1.Visible = true;
                Stream file = openFileDialog1.OpenFile();
                var results = CampaignIO.ReadSave(file);
            }
        }
    }
}
