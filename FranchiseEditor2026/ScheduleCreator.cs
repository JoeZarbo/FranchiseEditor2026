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
    public partial class ScheduleCreator : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");

        public ScheduleCreator()
        {
            InitializeComponent();
        }

        private void ScheduleCreator_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT teamID, team FROM team";
                SqlCommand cmd = new(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    awayTeam.Items.Add(new KeyValuePair<int, string>(dr.GetInt32(0), dr.GetString(1)));
                    homeTeam.Items.Add(new KeyValuePair<int, string>(dr.GetInt32(0), dr.GetString(1)));
                }
                awayTeam.DisplayMember = "Value";
                awayTeam.ValueMember = "Key";
                awayTeam.SelectedIndex = 0;
                homeTeam.DisplayMember = "Value";
                homeTeam.ValueMember = "Key";
                homeTeam.SelectedIndex = 0;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void isBye_CheckedChanged(object sender, EventArgs e)
        {
            awayTeam.Enabled = !isBye.Checked;
            addGame.Enabled = dateSel.SelectedIndex > -1 && timeSel.Text.Length > 0 && ((awayTeam.SelectedIndex != homeTeam.SelectedIndex) || isBye.Checked && homeTeam.SelectedIndex > -1);
        }

        private void dateSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            addGame.Enabled = dateSel.SelectedIndex > -1 && timeSel.Text.Length > 0 && ((awayTeam.SelectedIndex != homeTeam.SelectedIndex) || isBye.Checked && homeTeam.SelectedIndex > -1);
        }

        private void timeSel_TextChanged(object sender, EventArgs e)
        {
            addGame.Enabled = dateSel.SelectedIndex > -1 && timeSel.Text.Length > 0 && ((awayTeam.SelectedIndex != homeTeam.SelectedIndex) || isBye.Checked && homeTeam.SelectedIndex > -1);
        }

        private void awayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            addGame.Enabled = dateSel.SelectedIndex > -1 && timeSel.Text.Length > 0 && ((awayTeam.SelectedIndex != homeTeam.SelectedIndex) || isBye.Checked && homeTeam.SelectedIndex > -1);
        }

        private void homeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            addGame.Enabled = dateSel.SelectedIndex > -1 && timeSel.Text.Length > 0 && ((awayTeam.SelectedIndex != homeTeam.SelectedIndex) || isBye.Checked && homeTeam.SelectedIndex > -1);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            yearSel.Value = 2025;
            weekSel.Value = 1;
            isBye.Checked = false;
            dateSel.SelectedIndex = -1;
            dateSel.Text = "Select Date";
            timeSel.Text = "";
            awayTeam.SelectedIndex = 0;
            homeTeam.SelectedIndex = 0;
            addGame.Enabled = false;
        }

        private string GetTeamFromID(int ID)
        {
            string team = "";
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT team FROM team WHERE teamID = @teamID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@teamID", ID);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) team = dr.GetString(0);
            }
            return team;
        }

        private void addGame_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query;
                SqlCommand cmd;
                if (isBye.Checked)
                {
                    query = "INSERT INTO schedule (year, week, homeTeam, isBye) VALUES (@year, @week, @homeTeam, 1)";
                    cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@year", (int)yearSel.Value);
                    cmd.Parameters.AddWithValue("@week", (int)weekSel.Value);
                    cmd.Parameters.AddWithValue("@homeTeam", homeTeam.SelectedIndex);
                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show($"New game created:\n{yearSel.Value} Week {weekSel.Value}\n {GetTeamFromID(homeTeam.SelectedIndex)} on Bye Week");
                    else MessageBox.Show("Error: No Game Created");
                }
                else
                {
                    query = "INSERT INTO schedule (year, week, awayTeam, homeTeam, isBye, day, time) VALUES (@year, @week, @awayTeam, @homeTeam, 0, @day, @time)";
                    cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@year", (int)yearSel.Value);
                    cmd.Parameters.AddWithValue("@week", (int)weekSel.Value);
                    cmd.Parameters.AddWithValue("@awayTeam", awayTeam.SelectedIndex);
                    cmd.Parameters.AddWithValue("@homeTeam", homeTeam.SelectedIndex);
                    cmd.Parameters.AddWithValue("@day", dateSel.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@time", timeSel.Text);
                    if (cmd.ExecuteNonQuery() > 0) MessageBox.Show($"New game created:\n{yearSel.Value} Week {weekSel.Value}\n{dateSel.SelectedItem.ToString()} {timeSel.Text}\n{GetTeamFromID(awayTeam.SelectedIndex)}@{GetTeamFromID(homeTeam.SelectedIndex)}");
                    else MessageBox.Show("Error: No Game Created");
                }
            }
        }
    }
}
