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
            openFileDialog1.ShowDialog();
            Stream file = openFileDialog1.OpenFile();

            var results = CampaignIO.ReadSave(file);
        }
    }
}
