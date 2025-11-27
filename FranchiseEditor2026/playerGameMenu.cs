using FranchiseEditor2026.playerGame;
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
    public partial class playerGameMenu : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");
        BindingList<PlayerGameObj> players, visiblePlayers;

        public playerGameMenu()
        {
            InitializeComponent();
            players = [];
            visiblePlayers = [];
            InitializePlayerGrid();
        }

        private void InitializePlayerGrid()
        {
            playerGrid.AutoGenerateColumns = false;
            playerGrid.ReadOnly = true;
            playerGrid.AllowUserToAddRows = false;
            playerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            playerGrid.MultiSelect = false;
            playerGrid.Columns.Clear();

            //player's name
            var colName = new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(PlayerGameObj.FullName),
                HeaderText = "Player",
                Name = "colPlayerName"
            };
            playerGrid.Columns.Add(colName);

            //add passing stats
            var colPass = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Pass Stats",
                UseColumnTextForButtonValue = true,
                Name = "colPassStats"
            };
            playerGrid.Columns.Add(colPass);

            //add rushing stats
            var colRush = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Rush Stats",
                UseColumnTextForButtonValue = true,
                Name = "colRushStats"
            };
            playerGrid.Columns.Add(colRush);

            //add receiving stats
            var colRec = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Rec Stats",
                UseColumnTextForButtonValue = true,
                Name = "colRecStats"
            };
            playerGrid.Columns.Add(colRec);

            //add tackle stats
            var colTak = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Tackles",
                UseColumnTextForButtonValue = true,
                Name = "colTakStats"
            };
            playerGrid.Columns.Add(colTak);

            //add turnover stats
            var colTO = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Turnovers",
                UseColumnTextForButtonValue = true,
                Name = "colTOStats"
            };
            playerGrid.Columns.Add(colTO);

            //add return stats
            var colRet = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Returns",
                UseColumnTextForButtonValue = true,
                Name = "colRetStats"
            };
            playerGrid.Columns.Add(colRet);

            //add punting stats
            var colPnt = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Punts",
                UseColumnTextForButtonValue = true,
                Name = "colPntStats"
            };
            playerGrid.Columns.Add(colPnt);

            //add kicking stats
            var colKck = new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Kicking",
                UseColumnTextForButtonValue = true,
                Name = "colKckStats"
            };
            playerGrid.Columns.Add(colKck);

            playerGrid.DataSource = visiblePlayers;
            playerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            playerGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //handle button clicks
            playerGrid.CellContentClick += playerGrid_CellContentClick;
        }

        private void playerGrid_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var colName = playerGrid.Columns[e.ColumnIndex].Name;

            if (colName == "colPassStats")
            {
                var row = playerGrid.Rows[e.RowIndex];
                if (row.DataBoundItem is PlayerGameObj player)
                {
                    using var passForm = new playerPassing(player);
                    passForm.ShowDialog(this);
                }
            }
            else if (colName == "colRushStats")
            {
                var row = playerGrid.Rows[e.RowIndex];
                if (row.DataBoundItem is PlayerGameObj player)
                {
                    using var rushForm = new playerRushing(player);
                    rushForm.ShowDialog(this);
                }
            }
            else if (colName == "colRecStats")
            {
                var row = playerGrid.Rows[e.RowIndex];
                if (row.DataBoundItem is PlayerGameObj player)
                {
                    using var recForm = new playerReceiving(player);
                    recForm.ShowDialog(this);
                }
            }
            else if (colName == "colTakStats")
            {
                var row = playerGrid.Rows[e.RowIndex];
                if (row.DataBoundItem is PlayerGameObj player)
                {
                    using var takForm = new playerTackles(player);
                    takForm.ShowDialog(this);
                }
            }
            else if (colName == "colTOStats")
            {
                var row = playerGrid.Rows[e.RowIndex];
                if (row.DataBoundItem is PlayerGameObj player)
                {
                    using var toForm = new playerTurnovers(player);
                    toForm.ShowDialog(this);
                }
            }
            else if (colName == "colRetStats")
            {
                var row = playerGrid.Rows[e.RowIndex];
                if (row.DataBoundItem is PlayerGameObj player)
                {
                    using var retForm = new playerReturns(player);
                    retForm.ShowDialog(this);
                }
            }
            else if (colName == "colPntStats")
            {
                var row = playerGrid.Rows[e.RowIndex];
                if (row.DataBoundItem is PlayerGameObj player)
                {
                    using var pntForm = new playerPunting(player);
                    pntForm.ShowDialog(this);
                }
            }
            else if (colName == "colKckStats")
            {
                var row = playerGrid.Rows[e.RowIndex];
                if (row.DataBoundItem is PlayerGameObj player)
                {
                    using var kckForm = new playerKicking(player);
                    kckForm.ShowDialog(this);
                }
            }
        }

        private void playerGameMenu_Load(object sender, EventArgs e)
        {
            weekSel_ValueChanged(sender, e);
        }

        private void weekSel_ValueChanged(object sender, EventArgs e)
        {
            using SqlConnection conn = new(conStr);
            conn.Open();
            string query = "SELECT gameID, awayName, homeName FROM weeklyschedule WHERE year = @year AND week = @week";
            SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@year", yearSel.Value);
            cmd.Parameters.AddWithValue("@week", weekSel.Value);
            SqlDataReader dr = cmd.ExecuteReader();

            gameSel.Items.Clear();
            while (dr.Read()) gameSel.Items.Add(new KeyValuePair<int, string>((int)dr.GetValue(0), $"{dr.GetValue(1)} at {dr.GetValue(2)}"));

            weekLabel.Text = weekSel.Value switch
            {
                19 => "Wild Card",
                20 => "Divisional",
                21 => "Championship",
                22 => "Super Bowl",
                _ => $"Week {weekSel.Value}"
            };
            gameSel.DisplayMember = "Value";
            gameSel.ValueMember = "Key";
            gameSel.Text = "Select Game";
            gameSel.Enabled = true;

            teamSel.Text = "Select Team";
            teamSel.Enabled = false;
        }

        private void gameSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamSel.Items.Clear();
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT awayTeam, awayName, homeTeam, homeName FROM weeklyschedule WHERE gameID = @gameID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@gameID", ((KeyValuePair<int, string>)gameSel.SelectedItem).Key);
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
            teamSel.Enabled = true;
        }

        private void teamSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            players.Clear();
            visiblePlayers.Clear();
            using (SqlConnection conn = new(conStr))
            {
                conn.Open();
                string query = "SELECT player.playerID, fname, lname FROM roster INNER JOIN player ON roster.playerid = player.playerID WHERE teamID = @teamID";
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@teamID", ((KeyValuePair<int, string>)teamSel.SelectedItem).Key);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var p = new PlayerGameObj(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                    players.Add(p);
                    visiblePlayers.Add(p);
                }
                playerGrid.Enabled = visiblePlayers.Count > 0;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            string fileName = checkplayoffs.Checked ? @"D:\Current YT Vid\stats\playerPlayoffs.csv" : @"D:\Current YT Vid\stats\playerGame.csv";
            string header = "playerID,year,week,team,opp,location,result,cmp,passatt,passyds,passtd,passint,passsk,rushatt,rushyds,rushtd,receptions,recyds,rectd,defsk,solotak,asttak,tfl,defint,intyds,inttd,pd,fmb,ff,fr,fyds,ftd,defblock,kr,kryds,krtd,pr,pryds,prtd,pnt,pntyds,retyds,tb,in20,puntblock,xpm,xpa,fgm,fga,fgblock,sfty,tgt,fglong";
            File.WriteAllText(fileName, header);
        }

        private void export_Click(object sender, EventArgs e)
        {
            string fileName = checkplayoffs.Checked ? @"D:\Current YT Vid\stats\playerPlayoffs.csv" : @"D:\Current YT Vid\stats\playerGame.csv";
            foreach (PlayerGameObj player in players)
            {
                int team = ((KeyValuePair<int, string>)teamSel.SelectedItem).Key;
                int opp = teamSel.SelectedIndex == 0 ? ((KeyValuePair<int, string>)teamSel.Items[1]).Key : ((KeyValuePair<int, string>)teamSel.Items[0]).Key;
                int location = teamSel.SelectedIndex == 0 ? 1 : 0;
                string result;
                if (awayTeam.Value > homeTeam.Value) result = teamSel.SelectedIndex == 0 ? $"W ({awayTeam.Value}-{homeTeam.Value})" : $"L ({awayTeam.Value}-{homeTeam.Value})";
                else if (awayTeam.Value < homeTeam.Value) result = teamSel.SelectedIndex == 0 ? $"L ({awayTeam.Value}-{homeTeam.Value})" : $"W ({awayTeam.Value}-{homeTeam.Value})";
                else result = $"T ({awayTeam.Value}-{homeTeam.Value})";
                string row = $"\n{player.PlayerID},{yearSel.Value},{weekSel.Value},{team},{opp},{location},{result},{player.Cmp},{player.PassAtt},{player.PassYds},{player.PassTD},{player.PassINT},{player.PassSK},{player.RushAtt},{player.RushYds},{player.RushTD},{player.Receptions},{player.RecYds},{player.RecTD},{player.DefSK},{player.SoloTak},{player.AstTak},{player.TFL},{player.DefINT},{player.IntYds},{player.IntTD},{player.PD},{player.Fmb},{player.FF},{player.FR},{player.FYds},{player.FTD},{player.DefBlock},{player.KR},{player.KRYds},{player.KRTD},{player.PR},{player.PRYds},{player.PRTD},{player.Pnt},{player.PntYds},{player.RetYds},{player.TB},{player.In20},{player.PuntBlock},{player.XPM},{player.XPA},{player.FGM},{player.FGA},{player.FGBlock},{player.Safety},0,{player.FGLong}";
                File.AppendAllText(fileName, row);
            }
        }

        private void ApplyPlayerFilter(string search)
        {
            search = search?.Trim() ?? string.Empty;
            visiblePlayers.Clear();

            if (string.IsNullOrEmpty(search))
            {
                foreach (var p in players) visiblePlayers.Add(p);
                return;
            }

            string termLower = search.ToLowerInvariant();

            var filtered = players.Where(p =>

                (!string.IsNullOrEmpty(p.FName) && p.FName.ToLowerInvariant().Contains(termLower)) ||
                (!string.IsNullOrEmpty(p.LName) && p.LName.ToLowerInvariant().Contains(termLower)) ||
                (!string.IsNullOrEmpty(p.PlayerID) && p.PlayerID.ToLowerInvariant().Contains(termLower)) ||
                (!string.IsNullOrEmpty(p.FullName) && p.FullName.ToLowerInvariant().Contains(termLower))
            );

            foreach (var p in filtered) visiblePlayers.Add(p);
        }

        private void playerSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyPlayerFilter(playerSearch.Text);
        }
    }
}
