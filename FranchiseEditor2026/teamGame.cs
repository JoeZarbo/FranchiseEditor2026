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
    public partial class teamGame : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");
        public decimal LastWeek => weekSel.Value;

        public teamGame(decimal lastWeek)
        {
            InitializeComponent();
            weekSel.Value = lastWeek;
        }

        private void yearSel_ValueChanged(object sender, EventArgs e)
        {
            weekSel_ValueChanged(sender, e);
        }

        private void weekSel_ValueChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT MIN(gameID), MAX(gameID) FROM schedule WHERE week = @week AND year = @year";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@week", weekSel.Value);
                cmd.Parameters.AddWithValue("@year", yearSel.Value);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    gameSel.Minimum = (int)dr.GetValue(0);
                    gameSel.Maximum = (int)dr.GetValue(1);
                    gameSel.Value = gameSel.Minimum;
                }
            }
        }

        private void gameSel_ValueChanged(object sender, EventArgs e)
        {
            teamSel.Items.Clear();
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT awayTeam, awayName, homeTeam, homeName FROM weeklyschedule WHERE gameID = @gameID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@gameID", gameSel.Value);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    teamSel.Items.Add(new KeyValuePair<int, string>((int)dr.GetValue(0), dr.GetValue(1).ToString()));
                    teamSel.Items.Add(new KeyValuePair<int, string>((int)dr.GetValue(2), dr.GetValue(3).ToString()));
                }
            }
            teamSel.DisplayMember = "Value";
            teamSel.ValueMember = "Key";
            teamSel.Text = "SELECT TEAM";
        }

        private void teamGame_Load(object sender, EventArgs e)
        {
            gameSel_ValueChanged(sender, e);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Current YT Vid\stats\teamGame.csv";
            string outText = "\n" + gameSel.Value + "," + ((KeyValuePair<int, string>)teamSel.SelectedItem).Key + "," + scoreO.Value + "," + scoreD.Value + "," + passO.Value + "," + rushO.Value + "," + passD.Value + "," + rushD.Value + "," + firsts.Value + "," + trdConv.Value + "," + trdAtt.Value + "," + to.Value + "," + rztdo.Value + "," + rzatto.Value + "," + rztdd.Value + "," + rzattd.Value + "," + timeOfPossession.Text + "," + pen.Value + "," + penYds.Value;
            MessageBox.Show(outText);
            File.AppendAllText(fileName, outText);
            decimal temp = scoreO.Value;
            scoreO.Value = scoreD.Value;
            scoreD.Value = temp;
            temp = passO.Value;
            passO.Value = passD.Value;
            passD.Value = temp;
            temp = rushO.Value;
            rushO.Value = rushD.Value;
            rushD.Value = temp;
            firsts.Value = 0;
            trdAtt.Value = 0;
            trdConv.Value = 0;
            to.Value = 0;
            temp = rztdo.Value;
            rztdo.Value = rztdd.Value;
            rztdd.Value = temp;
            temp = rzatto.Value;
            rzatto.Value = rzattd.Value;
            rzattd.Value = temp;
            timeOfPossession.Clear();
            pen.Value = 0;
            penYds.Value = 0;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Current YT Vid\stats\teamGame.csv";
            string header = "gameID,teamID,scoreO,scoreD,passO,rushO,passD,rushD,firstDwn,trdConv,trdAtt,turnover,rzTDO,rzAttO,rzTDD,rzAttD,timeOP,pen,penYds";
            File.WriteAllText(fileName, header);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            scoreO.Value = scoreD.Value;
            scoreD.Value = 0;
            passO.Value = 0;
            passD.Value = 0;
            rushO.Value = 0;
            rushD.Value = 0;
            firsts.Value = 0;
            trdAtt.Value = 0;
            trdConv.Value = 0;
            to.Value = 0;
            rztdo.Value = 0;
            rztdd.Value = 0;
            rzatto.Value = 0;
            rzattd.Value = 0;
            timeOfPossession.Clear();
            pen.Value = 0;
            penYds.Value = 0;
        }
    }
}
