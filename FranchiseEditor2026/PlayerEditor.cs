using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026
{
    public partial class PlayerEditor : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");
        public PlayerEditor()
        {
            InitializeComponent();
        }

        private void LoadPlayers()
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "select player.playerid, player.fName, player.lName, roster.exp as 'Experience', ovr.age as 'Age', ovr.overall as 'Overall', ovr.archetype as 'Archetype', roster.number as 'Number', roster.probowl as 'Pro Bowl' from roster inner join ovr on roster.playerID = ovr.playerid inner join player on player.playerid = roster.playerid";
                SqlCommand cmd = new(query, conn);
                SqlDataAdapter da = new(cmd);
                DataTable dt = new();
                da.Fill(dt);
                playerGrid.DataSource = dt;
                playerGrid.Columns[0].Visible = false;
                playerGrid.Columns[1].HeaderText = "First Name";
                playerGrid.Columns[2].HeaderText = "Last Name";
            }
        }

        private void PlayerEditor_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void playerGrid_SelectionChanged(object sender, EventArgs e)
        {
            ovrAdd.Enabled = playerGrid.SelectedRows.Count == 1;
            ovrEdit.Enabled = playerGrid.SelectedRows.Count == 1;
            archetypeSel.Enabled = playerGrid.SelectedRows.Count == 1;
            numberSel.Enabled = playerGrid.SelectedRows.Count == 1;
            proBowl.Enabled = playerGrid.SelectedRows.Count == 1;
            expAdd.Enabled = playerGrid.SelectedRows.Count == 0;
            expSub.Enabled = playerGrid.SelectedRows.Count == 0;
            ageAdd.Enabled = playerGrid.SelectedRows.Count == 0;
            ageSub.Enabled = playerGrid.SelectedRows.Count == 0;
        }

        private void playerSearch_TextChanged(object sender, EventArgs e)
        {
            (playerGrid.DataSource as DataTable).DefaultView.RowFilter = $"FName LIKE '%{playerSearch.Text}%' OR LName LIKE '%{playerSearch.Text}%'";
        }

        private void expAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "UPDATE Roster SET exp = exp + 1";
                SqlCommand cmd = new(query, conn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) MessageBox.Show($"{rows} players had their experience increased by 1");
                else MessageBox.Show($"Error: 0 players updated");
            }

            LoadPlayers();
        }

        private void expSub_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "UPDATE Roster SET exp = exp - 1";
                SqlCommand cmd = new(query, conn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) MessageBox.Show($"{rows} players had their experience decreased by 1");
                else MessageBox.Show($"Error: 0 players updated");
            }

            LoadPlayers();
        }

        private void ageAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "UPDATE ovr SET age = age + 1";
                SqlCommand cmd = new(query, conn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) MessageBox.Show($"{rows} players had their age increased by 1");
                else MessageBox.Show($"Error: 0 players updated");
            }

            LoadPlayers();
        }

        private void ageSub_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "UPDATE ovr SET age = age - 1";
                SqlCommand cmd = new(query, conn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) MessageBox.Show($"{rows} players had their age decreased by 1");
                else MessageBox.Show($"Error: 0 players updated");
            }

            LoadPlayers();
        }

        private void ovrAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                string query = "UPDATE ovr SET overall = overall + 1 WHERE playerID = @playerID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@playerID", playerID);
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show($"{fullName} had their overall increased by 1");
                else MessageBox.Show($"Error: {fullName} not found");
            }

            LoadPlayers();
        }

        private void ovrEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                int ovr = new NumberSelect().GetNumber();
                string query = "UPDATE ovr SET overall = @ovr WHERE playerID = @playerID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@playerID", playerID);
                cmd.Parameters.AddWithValue("@ovr", ovr);
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show($"{fullName} had their overall updated to {ovr}");
                else MessageBox.Show($"Error: {fullName} not found");
            }

            LoadPlayers();
        }

        private void archetypeSel_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                string archetype = new ArchetypeSelect().GetArchetype();
                string query = "UPDATE ovr SET archetype = @archetype WHERE playerID = @playerID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@playerID", playerID);
                cmd.Parameters.AddWithValue("@archetype", archetype);
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show($"{fullName} had their archetype updated to {archetype}");
                else MessageBox.Show($"Error: {fullName} not found");
            }

            LoadPlayers();
        }

        private void numberSel_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                int num = new NumberSelect().GetNumber();
                string query = "UPDATE Roster SET number = @num WHERE playerID = @playerID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@num", num);
                cmd.Parameters.AddWithValue("@playerID", playerID);
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show($"{fullName} had their number updated to {num}");
                else MessageBox.Show($"Error: {fullName} not found");
            }

            LoadPlayers();
        }

        private void proBowl_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                int pb = (int)playerGrid.SelectedRows[0].Cells[8].Value;
                pb = pb == 1 ? 0 : 1;
                string query = "UPDATE Roster SET probowl = @pb WHERE playerID = @playerID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@pb", pb);
                cmd.Parameters.AddWithValue("@playerID", playerID);
                if (cmd.ExecuteNonQuery() > 0) MessageBox.Show($"{fullName} is {(pb == 1 ? "now" : "no longer")} a pro bowler");
                else MessageBox.Show($"Error: {fullName} not found");
            }

            LoadPlayers();
        }
    }
}
