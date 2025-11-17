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
    public partial class HeadToHead : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");

        public HeadToHead()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadWeek()
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "select year, teamgame.teamID, awayteam, a.team, hometeam, b.team, scoreo, scored from teamGame inner join schedule on teamGame.gameID = schedule.gameID inner join team a on awayteam = a.teamid inner join team b on hometeam = b.teamid where year = @year and week = @week and isBye = 0";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@year", yearSel.Value);
                cmd.Parameters.AddWithValue("@week", weekSel.Value);
                SqlDataAdapter da = new(cmd);
                DataTable dt = new();
                da.Fill(dt);
                teamGrid.DataSource = dt;
                teamGrid.Columns[1].Visible = false;
                teamGrid.Columns[2].Visible = false;
                teamGrid.Columns[4].Visible = false;
                teamGrid.Columns[3].HeaderText = "Away Team";
                teamGrid.Columns[5].HeaderText = "Home Team";
            }
        }

        private void weekSel_ValueChanged(object sender, EventArgs e)
        {
            LoadWeek();
        }

        private void HeadToHead_Load(object sender, EventArgs e)
        {
            LoadWeek();
        }

        private void yearSel_ValueChanged(object sender, EventArgs e)
        {
            LoadWeek();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in teamGrid.Rows)
            {
                if (row.Cells[0].Value is null) return;   
                int year = (int)row.Cells[0].Value;
                int team = (int)row.Cells[1].Value;
                int opp;
                if ((int)row.Cells[1].Value == (int)row.Cells[2].Value) opp = (int)row.Cells[4].Value;
                else opp = (int)row.Cells[2].Value;
                int scoreO = (int)row.Cells[6].Value;
                int scoreD = (int)row.Cells[7].Value;

                using (SqlConnection conn = new(conStr))
                {
                    conn.Open();
                    string query = "INSERT INTO headtohead VALUES (@year, @team, @opp, @scoreO, @scoreD)";
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue(@"year", year);
                    cmd.Parameters.AddWithValue("@team", team);
                    cmd.Parameters.AddWithValue("@opp", opp);
                    cmd.Parameters.AddWithValue("@scoreO", scoreO);
                    cmd.Parameters.AddWithValue("@scoreD", scoreD);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
