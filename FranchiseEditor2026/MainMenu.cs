namespace FranchiseEditor2026
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rosterEditor_Click(object sender, EventArgs e)
        {
            Hide();
            using (RosterEditor rui = new()) rui.ShowDialog();
            Show();
        }

        private void playerEditor_Click(object sender, EventArgs e)
        {
            Hide();
            using (PlayerEditor pui = new()) pui.ShowDialog();
            Show();
        }

        private void draftEditor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be implemented later");
        }
    }
}
