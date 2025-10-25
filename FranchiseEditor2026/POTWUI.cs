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
    public partial class POTWUI : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");
        public POTWUI()
        {
            InitializeComponent();
        }

        struct Player
        {
            public string name;
            public string team;
            public double score;
        }

        private void Offense()
        {
            outPlayers.Items.Clear();
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT * FROM playerGame INNER JOIN player ON playerGame.playerID = player.playerID INNER JOIN team ON playerGame.team = team.teamID WHERE week = @week AND year = @year AND result LIKE 'W%' AND position < 7";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@week", (int)weekSel.Value);
                cmd.Parameters.AddWithValue("@year", (int)yearSel.Value);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Player> players = [];

                while (dr.Read())
                {
                    Player p = new();
                    p.name = dr.GetString(53) + " " + dr.GetString(54);
                    p.team = dr.GetString(61);
                    p.score = 0;
                    double temp = 0;

                    //passing / yards / td / to
                    if (dr.GetInt32(8) > 0) //cmp rate 
                    {
                        temp = dr.GetInt32(7) / (double)dr.GetInt32(8) * 100;
                        temp = -Math.Pow(0.94, temp - 100) + 20;
                        p.score += temp;
                    }
                    p.score += (dr.GetInt32(9) + dr.GetInt32(14) + dr.GetInt32(18)) / 10; //total yards
                    p.score += Math.Pow(dr.GetInt32(10) + dr.GetInt32(15) + dr.GetInt32(19), 3); //total td
                    p.score -= Math.Pow(dr.GetInt32(11) + dr.GetInt32(28), 3);

                    //rushing
                    if (dr.GetInt32(13) > 5)//yards per rush penalty/boost
                    {
                        temp = dr.GetInt32(14) / (double)dr.GetInt32(13);
                        temp = Math.Pow(1.5, temp) - 5;
                        p.score += temp;
                    }

                    //100, 200 yard bonuses (excluding passing) 400/500 yard pass bonus
                    if (dr.GetInt32(14) + dr.GetInt32(18) > 99) p.score += 20;
                    if (dr.GetInt32(14) + dr.GetInt32(18) > 199) p.score += 75;
                    if (dr.GetInt32(9) > 399) p.score += 35;
                    if (dr.GetInt32(9) > 499) p.score += 80;

                    players.Add(p);
                }

                var sorted = players.OrderByDescending(s => s.score);
                foreach (var p in sorted) outPlayers.Items.Add(p.name + " " + p.team + " " + p.score);
            }
        }

        private void Defense()
        {
            outPlayers.Items.Clear();
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT * FROM playerGame INNER JOIN player ON playerGame.playerID = player.playerID INNER JOIN team ON playerGame.team = team.teamID WHERE week = @week AND year = @year AND result LIKE 'W%' AND position BETWEEN 10 AND 18";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@week", (int)weekSel.Value);
                cmd.Parameters.AddWithValue("@year", (int)yearSel.Value);
                SqlDataReader dr = cmd.ExecuteReader();
                List<Player> players = [];

                while (dr.Read())
                {
                    Player p = new();
                    p.name = dr.GetString(53) + " " + dr.GetString(54);
                    p.team = dr.GetString(61);
                    p.score = 0;

                    p.score += dr.GetInt32(21) * 0.25; //tackles
                    p.score += dr.GetInt32(23); //TFL
                    p.score += Math.Pow(1.5, (double)dr.GetDecimal(22) * 3) - 1; //sacks
                    p.score += Math.Pow(1.5, (dr.GetInt32(24) + dr.GetInt32(29)) * 6) - 1; //interceptions fumbles
                    p.score += 500 * (dr.GetInt32(26) + dr.GetInt32(32)); //touchdowns
                    p.score += 30 * dr.GetInt32(33); //blocks
                    p.score += 30 * dr.GetInt32(51); //safety

                    players.Add(p);
                }

                var sorted = players.OrderByDescending(s => s.score);
                foreach (var p in sorted) outPlayers.Items.Add(p.name + " " + p.team + " " + p.score);
            }
        }

        private Player GetData(string id)
        {
            Player p = new();
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT * FROM playerGame INNER JOIN player ON playerGame.playerID = player.playerID INNER JOIN team ON playerGame.team = team.teamID WHERE week = @week AND year = @year AND playerID = @playerID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@week", (int)weekSel.Value);
                cmd.Parameters.AddWithValue("@year", (int)yearSel.Value);
                cmd.Parameters.AddWithValue("@playerID", id);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    p.name = dr.GetString(53) + " " + dr.GetString(54);
                    p.team = dr.GetString(61);
                    p.score = 0;
                    double temp = 0;

                    //passing / yards / td / to
                    if (dr.GetInt32(8) > 0) //cmp rate 
                    {
                        temp = dr.GetInt32(7) / (double)dr.GetInt32(8) * 100;
                        temp = -Math.Pow(0.94, temp - 100) + 20;
                        p.score += temp;
                    }
                    p.score += (dr.GetInt32(9) + dr.GetInt32(14) + dr.GetInt32(18)) / 10; //total yards
                    p.score += Math.Pow(dr.GetInt32(10) + dr.GetInt32(15) + dr.GetInt32(19), 3); //total td
                    p.score -= Math.Pow(dr.GetInt32(11) + dr.GetInt32(28), 3);

                    //rushing
                    if (dr.GetInt32(13) > 5)//yards per rush penalty/boost
                    {
                        temp = dr.GetInt32(14) / (double)dr.GetInt32(13);
                        temp = Math.Pow(1.5, temp) - 5;
                        p.score += temp;
                    }

                    //100, 200 yard bonuses (excluding passing) 400/500 yard pass bonus
                    if (dr.GetInt32(14) + dr.GetInt32(18) > 99) p.score += 20;
                    if (dr.GetInt32(14) + dr.GetInt32(18) > 199) p.score += 75;
                    if (dr.GetInt32(9) > 399) p.score += 35;
                    if (dr.GetInt32(9) > 499) p.score += 80;

                    p.score += dr.GetInt32(21) * 0.25; //tackles
                    p.score += dr.GetInt32(23); //TFL
                    p.score += Math.Pow(1.5, (double)dr.GetDecimal(22) * 3) - 1; //sacks
                    p.score += Math.Pow(1.5, (dr.GetInt32(24) + dr.GetInt32(29)) * 6) - 1; //interceptions fumbles
                    p.score += 500 * (dr.GetInt32(26) + dr.GetInt32(32)); //touchdowns
                    p.score += 30 * dr.GetInt32(33); //blocks
                    p.score += 30 * dr.GetInt32(51); //safety
                }
            }
            return p;
        }

        private void Rookie()
        {
            outPlayers.Items.Clear();
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT * FROM roster WHERE exp = 0";
                SqlCommand cmd = new(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<string> ids = [];
                List<Player> players = [];
                while (dr.Read()) ids.Add(dr.GetString(1));
                dr.Close();
                foreach (string id in ids) players.Add(GetData(id));

                var sorted = players.OrderByDescending(s => s.score);
                foreach (var p in sorted) outPlayers.Items.Add(p.name + " " + p.team + " " + p.score);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void typeSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            generate.Enabled = typeSel.SelectedIndex > -1;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            switch (typeSel.SelectedIndex)
            {
                case 0:
                    Offense();
                    break;
                case 1:
                    Defense();
                    break;
                case 2:
                    Rookie();
                    break;
                default:
                    return;
            }
        }
    }
}
