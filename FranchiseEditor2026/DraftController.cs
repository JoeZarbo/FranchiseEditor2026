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
    public partial class DraftController : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");

        public DraftController()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadPlayers(decimal year)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT * FROM draftclass WHERE year = @year AND drafted = 0";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@year", year);
                SqlDataAdapter da = new(cmd);
                DataTable dt = new();
                da.Fill(dt);
                playerGrid.DataSource = dt;
                playerGrid.Columns[0].HeaderText = "First Name";
                playerGrid.Columns[1].HeaderText = "Last Name";
                playerGrid.Columns[2].Visible = false;
                playerGrid.Columns[3].Visible = false;
                playerGrid.Columns[4].Visible = false;
                playerGrid.Columns[5].Visible = false;
            }
        }

        private void DraftController_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT teamID, team FROM team";
                SqlCommand cmd = new(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) teamSel.Items.Add(new KeyValuePair<int, string>(dr.GetInt32(0), dr.GetString(1)));
            }
            teamSel.DisplayMember = "Value";
            teamSel.ValueMember = "Key";
        }

        private void playerSearch_TextChanged(object sender, EventArgs e)
        {
            (playerGrid.DataSource as DataTable).DefaultView.RowFilter = $"FName LIKE '%{playerSearch.Text}%' OR LName LIKE '%{playerSearch.Text}%'";
        }

        private void yearSel_ValueChanged(object sender, EventArgs e)
        {
            LoadPlayers(yearSel.Value);
        }

        private void playerGrid_SelectionChanged(object sender, EventArgs e)
        {
            draft.Enabled = playerGrid.SelectedRows.Count == 1 && teamSel.SelectedIndex > -1;
        }

        private void teamSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            draft.Enabled = playerGrid.SelectedRows.Count == 1 && teamSel.SelectedIndex > -1;
        }

        private string generateID(string first, string last)
        {
            string padFirst = first.PadRight(2, 'x').ToLower();
            string padLast = last.PadRight(4, 'x').ToLower();
            string prefix = $"{padLast[0]}/{padLast.Substring(0, 4)}{padFirst.Substring(0, 2)}";
            int suffix = 0;
            string newID;

            using (SqlConnection conn = new(conStr))
            {
                conn.Open();

                do
                {
                    newID = $"{prefix}{suffix:D2}";
                    string query = "SELECT COUNT(*) FROM player WHERE playerID = @playerID";
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@playerID", newID);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0) break;
                    else suffix++;
                } while (suffix < 100);
            }

            if (suffix > 99) throw new Exception("Unable to generate a unique ID");

            return newID;
        }

        private void draft_Click(object sender, EventArgs e)
        {
            string firstname = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
            string lastname = playerGrid.SelectedRows[0].Cells[1].Value.ToString();
            int position = (int)playerGrid.SelectedRows[0].Cells[5].Value;
            int portrait = (int)playerGrid.SelectedRows[0].Cells[2].Value;
            int teamID = (int)teamSel.SelectedValue;
            string playerID = generateID(firstname, lastname);

            using (SqlConnection conn = new(conStr))
            {
                conn.Open();

                string player = "INSERT INTO player VALUES (@firstname, @lastname, @portraitID, @position, @playerID)";
                SqlCommand pmd = new(player, conn);
                pmd.Parameters.AddWithValue("@firstname", firstname);
                pmd.Parameters.AddWithValue("@lastname", lastname);
                pmd.Parameters.AddWithValue("@portraitID", portrait);
                pmd.Parameters.AddWithValue("@position", position);
                pmd.Parameters.AddWithValue("@playerID", playerID);
                pmd.ExecuteNonQuery();

                string roster = "INSERT INTO roster VALUES (@teamID, @playerID, 0, 0, 0, 0, '')";
                SqlCommand rmd = new(roster, conn);
                rmd.Parameters.AddWithValue("@teamID", teamID);
                rmd.Parameters.AddWithValue("@playerID", playerID);
                rmd.ExecuteNonQuery();

                string draft = "UPDATE draftclass SET drafted = 1 WHERE fname = @firstname AND lname = @lastname AND year = @year";
                SqlCommand dmd = new(draft, conn);
                dmd.Parameters.AddWithValue("@firstname", firstname);
                dmd.Parameters.AddWithValue("@lastname", lastname);
                dmd.Parameters.AddWithValue("@year", yearSel.Value);
                dmd.ExecuteNonQuery();
            }
            LoadPlayers(yearSel.Value);
        }

        private void udfa_Click(object sender, EventArgs e)
        {
            if (playerGrid.Rows.Count == 0)
            {
                MessageBox.Show("No players to add");
                return;
            }
            int count = 0;

            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                foreach (DataGridViewRow row in playerGrid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string firstname = playerGrid.SelectedRows[0].Cells[0].Value.ToString();
                        string lastname = playerGrid.SelectedRows[0].Cells[1].Value.ToString();
                        int position = (int)playerGrid.SelectedRows[0].Cells[5].Value;
                        int portrait = (int)playerGrid.SelectedRows[0].Cells[2].Value;
                        int teamID = 32;
                        string playerID = generateID(firstname, lastname);

                        string player = "INSERT INTO player VALUES (@firstname, @lastname, @portraitID, @position, @playerID)";
                        SqlCommand pmd = new(player, conn);
                        pmd.Parameters.AddWithValue("@firstname", firstname);
                        pmd.Parameters.AddWithValue("@lastname", lastname);
                        pmd.Parameters.AddWithValue("@portraitID", portrait);
                        pmd.Parameters.AddWithValue("@position", position);
                        pmd.Parameters.AddWithValue("@playerID", playerID);
                        pmd.ExecuteNonQuery();

                        string roster = "INSERT INTO roster VALUES (@teamID, @playerID, 0, 0, 0, 0, '')";
                        SqlCommand rmd = new(roster, conn);
                        rmd.Parameters.AddWithValue("@teamID", teamID);
                        rmd.Parameters.AddWithValue("@playerID", playerID);
                        rmd.ExecuteNonQuery();

                        string draft = "UPDATE draftclass SET drafted = 1 WHERE fname = @firstname AND lname = @lastname AND year = @year";
                        SqlCommand dmd = new(draft, conn);
                        dmd.Parameters.AddWithValue("@firstname", firstname);
                        dmd.Parameters.AddWithValue("@lastname", lastname);
                        dmd.Parameters.AddWithValue("@year", yearSel.Value);
                        dmd.ExecuteNonQuery();

                        count++;
                    }
                }
                MessageBox.Show($"{count} UDFAs created successfully");
            }
        }
    }
}
