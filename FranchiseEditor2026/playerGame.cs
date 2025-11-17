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
    public partial class playerGame : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");

        public playerGame()
        {
            InitializeComponent();
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

        private void yearSel_ValueChanged(object sender, EventArgs e)
        {
            weekSel_ValueChanged(sender, e);
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
            teamSel.Text = "Select Team";
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void playerGame_Load(object sender, EventArgs e)
        {
            gameSel_ValueChanged(sender, e);
        }

        private void add_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\Current YT Vid\stats\playerGame.csv";
            int team = ((KeyValuePair<int, string>)teamSel.SelectedItem).Key;
            int opp = teamSel.SelectedIndex == 0 ? ((KeyValuePair<int, string>)teamSel.Items[1]).Key : ((KeyValuePair<int, string>)teamSel.Items[0]).Key;
            int location = teamSel.SelectedIndex == 0 ? 1 : 0;
            string player = playerSel.SelectedValue.ToString();
            string outText = ",," + player + "," + yearSel.Value + "," + weekSel.Value + "," + team + "," + opp + "," + location + "," + result.Text + "," + cmp.Value + "," + passatt.Value + "," + passyds.Value + "," + passTD.Value + "," + passint.Value + "," + passsk.Value + "," + rushatt.Value + "," + rushyds.Value + "," + rushtd.Value + "," + receptions.Value + "," + recyds.Value + "," + rectd.Value + "," + defsk.Text + "," + solotak.Value + "," + asttak.Value + "," + tfl.Value + "," + defint.Value + "," + intyds.Value + "," + inttd.Value + "," + pd.Value + "," + fumbles.Value + "," + ff.Value + "," + fr.Value + "," + fyds.Value + "," + ftd.Value + "," + defblock.Value + "," + kr.Value + "," + kryds.Value + "," + krtd.Value + "," + pr.Value + "," + pryds.Value + "," + prtd.Value + "," + pnt.Value + "," + pntyds.Value + "," + retyds.Value + "," + tb.Value + "," + in20.Value + "," + puntblock.Value + "," + xpm.Value + "," + xpa.Value + "," + fgm.Value + "," + fga.Value + "," + fgblock.Value + "," + safety.Value + ",0," + fglong.Value;
            File.AppendAllText(fileName, outText);
            teamSel_SelectedIndexChanged(sender, e);
            //cmp.Value = 0;
            //passatt.Value = 0;
            //passyds.Value = 0;
            //passTD.Value = 0;
            //passint.Value = 0;
            //passsk.Value = 0;
            //rushatt.Value = 0;
            //rushyds.Value = 0;
            //rushtd.Value = 0;
            //receptions.Value = 0;
            //recyds.Value = 0;
            //rectd.Value = 0;
            //defsk.Clear();
            //solotak.Value = 0;
            //asttak.Value = 0;
            //tfl.Value = 0;
            //defint.Value = 0;
            //intyds.Value = 0;
            //inttd.Value = 0;
            //pd.Value = 0;
            //fumbles.Value = 0;
            //ff.Value = 0;
            //fr.Value = 0;
            //fyds.Value = 0;
            //ftd.Value = 0;
            //defblock.Value = 0;
            //kr.Value = 0;
            //kryds.Value = 0;
            //krtd.Value = 0;
            //pr.Value = 0;
            //pryds.Value = 0;
            //prtd.Value = 0;
            //pnt.Value = 0;
            //pntyds.Value = 0;
            //retyds.Value = 0;
            //tb.Value = 0;
            //in20.Value = 0;
            //puntblock.Value = 0;
            //xpm.Value = 0;
            //xpa.Value = 0;
            //fgm.Value = 0;
            //fga.Value = 0;
            //fgblock.Value = 0;
            //safety.Value = 0;
            //fglong.Value = 0;
        }

        private void teamSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerSel.Items.Clear();
            playerSel.Text = "Select Player";
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                int team = ((KeyValuePair<int, string>)teamSel.SelectedItem).Key;
                string query = "SELECT player.playerid, fname, lname FROM roster INNER JOIN player ON roster.playerID = player.playerID WHERE teamID = @teamID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@teamID", team);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) playerSel.Items.Add(new KeyValuePair<string, string>(dr.GetString(0), dr.GetString(1) + " " + dr.GetString(2)));
            }
            playerSel.DisplayMember = "Value";
            playerSel.ValueMember = "Key";
        }
    }
}
