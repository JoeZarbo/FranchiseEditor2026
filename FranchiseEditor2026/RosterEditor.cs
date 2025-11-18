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
    public partial class RosterEditor : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");

        public RosterEditor()
        {
            InitializeComponent();
        }

        private void RosterEditor_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT teamID, team FROM team";
                SqlCommand cmd = new(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) teamSel.Items.Add(new KeyValuePair<int, string>(dr.GetInt32(0), dr.GetString(1)));
            }
            teamSel.Items.Add(new KeyValuePair<int, string>(33, "All"));
            teamSel.DisplayMember = "Value";
            teamSel.ValueMember = "Key";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadPlayers(int teamID)
        {
            string query = teamID == 33 ? "SELECT player.playerID, fname, lName, player.position, roster.position, isStarter FROM roster INNER JOIN player ON player.playerID = roster.playerID" : "SELECT player.playerID, fname, lName, player.position, roster.position, isStarter FROM roster INNER JOIN player ON player.playerID = roster.playerID WHERE teamID = @teamID";

            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                SqlCommand cmd = new(query, conn);
                if (teamID < 33) cmd.Parameters.AddWithValue("@teamID", teamID);
                SqlDataAdapter da = new(cmd);

                DataTable dt = new();
                da.Fill(dt);
                playerGrid.DataSource = dt;
                playerGrid.Columns[0].Visible = false;
                playerGrid.Columns[1].HeaderText = "First Name";
                playerGrid.Columns[2].HeaderText = "Last Name";
                playerGrid.Columns[4].HeaderText = "Position";
                playerGrid.Columns[5].HeaderText = "Starter";
            }
            playerSearch.Clear();
            playerSearch.Focus();
        }

        private void teamSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamSel.SelectedItem is null) return;
            LoadPlayers(((KeyValuePair<int, string>)teamSel.SelectedItem).Key);

            playerSearch.Enabled = true;
            cutPlayer.Enabled = true;
            signPlayer.Enabled = ((KeyValuePair<int, string>)teamSel.SelectedItem).Key >= 32;
            tradePlayer.Enabled = ((KeyValuePair<int, string>)teamSel.SelectedItem).Key < 32;
            toggleStarter.Enabled = true;
            posSel.Enabled = true;
        }

        private void playerSearch_TextChanged(object sender, EventArgs e)
        {
            if (playerGrid.DataSource is null) return;
            (playerGrid.DataSource as DataTable).DefaultView.RowFilter = $"FName LIKE '%{playerSearch.Text}%' OR LName LIKE '%{playerSearch.Text}%'";
        }

        private void cutPlayer_Click(object sender, EventArgs e)
        {
            if (playerGrid.SelectedRows.Count == 1)
            {
                string query = "UPDATE Roster SET teamID = 32 WHERE playerID = @playerID";
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                using (SqlConnection conn = new(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@playerID", playerID);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show($"{fullName} cut successfully");
                        query = $"INSERT INTO transactions VALUES (@playerID, 'release', @oldTeam, 32)";
                        cmd = new(query, conn);
                        cmd.Parameters.AddWithValue("@playerID", playerID);
                        cmd.Parameters.AddWithValue("@oldTeam", ((KeyValuePair<int, string>)teamSel.SelectedItem).Key);
                        cmd.ExecuteNonQuery();

                        if (teamSel.SelectedItem is not null) LoadPlayers(((KeyValuePair<int, string>)teamSel.SelectedItem).Key);
                    }
                    else MessageBox.Show($"Error: {fullName} not found.");
                }
            }
            else MessageBox.Show($"Error: You may only select one player to cut. You selected {playerGrid.SelectedRows.Count} rows.");
        }

        private void signPlayer_Click(object sender, EventArgs e)
        {
            if (playerGrid.SelectedRows.Count == 1)
            {
                string query = "UPDATE Roster SET teamID = @teamID WHERE playerID = @playerID";
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                int teamID = new TeamSelect().GetTeam();
                using (SqlConnection conn = new(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@playerID", playerID);
                    cmd.Parameters.AddWithValue("@teamID", teamID);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show($"{fullName} signed successfully");
                        query = $"INSERT INTO transactions VALUES (@playerID, 'sign', 32, @newTeam);";
                        cmd = new(query, conn);
                        cmd.Parameters.AddWithValue("@playerID", playerID);
                        cmd.Parameters.AddWithValue("@newTeam", teamID);
                        cmd.ExecuteNonQuery();
                        LoadPlayers(32);
                    }
                    else MessageBox.Show($"Error: {fullName} not found.");
                }
            }
            else MessageBox.Show($"Error: You may only select one player to cut. You selected {playerGrid.SelectedRows.Count} rows.");
        }

        private void tradePlayer_Click(object sender, EventArgs e)
        {
            if (playerGrid.SelectedRows.Count == 1)
            {
                string query = "UPDATE Roster SET teamID = @teamID WHERE playerID = @playerID";
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                int teamID = new TeamSelect().GetTeam();
                using (SqlConnection conn = new(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@playerID", playerID);
                    cmd.Parameters.AddWithValue("@teamID", teamID);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show($"{fullName} traded successfully");
                        query = $"INSERT INTO transactions VALUES (@playerID, 'trade', @oldTeam, @newTeam)";
                        cmd = new(query, conn);
                        cmd.Parameters.AddWithValue("@playerID", playerID);
                        cmd.Parameters.AddWithValue("@oldTeam", ((KeyValuePair<int, string>)teamSel.SelectedItem).Key);
                        cmd.Parameters.AddWithValue("@newTeam", teamID);
                        cmd.ExecuteNonQuery();
                        LoadPlayers(((KeyValuePair<int, string>)teamSel.SelectedItem).Key);
                    }
                    else MessageBox.Show($"Error: {fullName} not found");
                }
            }
            else MessageBox.Show($"Error: You may only select one player to cut. You selected {playerGrid.SelectedRows.Count} rows");
        }

        private void toggleStarter_Click(object sender, EventArgs e)
        {
            if (playerGrid.SelectedRows.Count == 1)
            {
                int start = (int)playerGrid.SelectedRows[0].Cells[5].Value;
                start = start == 1 ? 0 : 1;
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                string query = "UPDATE Roster SET isStarter = @isStarter WHERE playerID = @playerID";
                using (SqlConnection conn = new(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@isStarter", start);
                    cmd.Parameters.AddWithValue("@playerID", playerID);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show($"{fullName} is {(start == 1 ? "now" : "no longer")} a starter");
                        if (start == 0) LoadPlayers(((KeyValuePair<int, string>)teamSel.SelectedItem).Key);
                    }
                    else MessageBox.Show($"Error: {fullName} not found");
                }
                if (start == 1)
                {
                    query = "UPDATE Roster SET position = @position WHERE playerID = @playerID";
                    string position = new SpecialPositionSelect().GetPos();
                    using (SqlConnection conn = new(conStr)) 
                    {
                        conn.Open();
                        SqlCommand cmd = new(query, conn);
                        cmd.Parameters.AddWithValue("@position", position);
                        cmd.Parameters.AddWithValue("@playerID", playerID);
                        if (cmd.ExecuteNonQuery() > 0) 
                        {
                            MessageBox.Show($"{fullName}'s new position is now \"{position}\"");
                            LoadPlayers(((KeyValuePair<int, string>)teamSel.SelectedItem).Key);
                        }
                        else MessageBox.Show($"Error: {fullName} not found");
                    }
                }
            }
            else MessageBox.Show($"Error: You may only select one player to change starting status. You selected {playerGrid.SelectedRows.Count} rows");
        }

        private void posSel_Click(object sender, EventArgs e)
        {
            if (playerGrid.SelectedRows.Count == 1)
            {
                string query = "UPDATE Roster SET position = @position WHERE playerID = @playerID";
                string playerID = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                string fullName = playerGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + playerGrid.SelectedRows[0].Cells[2].Value.ToString();
                string position = new SpecialPositionSelect().GetPos();
                using (SqlConnection conn = new(conStr))
                {
                    conn.Open();
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@playerID", playerID);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show($"{fullName}'s new position is now \"{position}\"");
                        LoadPlayers(((KeyValuePair<int, string>)teamSel.SelectedItem).Key);
                    }
                    else MessageBox.Show($"Error: {fullName} not found");
                }
            }
            else MessageBox.Show($"Error: You may only select one player to cut. You selected {playerGrid.SelectedRows.Count} rows");
        }
    }
}
