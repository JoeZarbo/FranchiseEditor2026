namespace FranchiseEditor2026
{
    public partial class MainMenu : Form
    {
        private decimal lastWeek = 1;

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
            Hide();
            using (DraftController dui = new()) dui.ShowDialog();
            Show();
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            Hide();
            using (ScheduleCreator sui = new()) sui.ShowDialog();
            Show();
        }

        private void potw_Click(object sender, EventArgs e)
        {
            Hide();
            using (POTWUI pui = new()) pui.ShowDialog();
            Show();
        }

        private void h2hCont_Click(object sender, EventArgs e)
        {
            Hide();
            using (HeadToHead hui = new()) hui.ShowDialog();
            Show();
        }

        private void teamAdd_Click(object sender, EventArgs e)
        {
            Hide();
            using (teamGame tui = new(lastWeek)) if (tui.ShowDialog() == DialogResult.OK) lastWeek = tui.LastWeek;
            Show();
        }

        private void playerAdd_Click(object sender, EventArgs e)
        {
            Hide();
            using (playerGameMenu pui = new(lastWeek)) if (pui.ShowDialog() == DialogResult.OK) lastWeek = pui.LastWeek;
            Show();
        }
    }
}
