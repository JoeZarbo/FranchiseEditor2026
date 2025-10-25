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
    public partial class TeamSelect : Form
    {
        string conStr = Environment.GetEnvironmentVariable("FRANCHISE_CONSTR");

        public TeamSelect()
        {
            InitializeComponent();
        }

        private void TeamSelect_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }

        private void LoadTeams()
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

        public int GetTeam()
        {
            LoadTeams();
            if (ShowDialog() == DialogResult.OK && teamSel.SelectedItem is not null) return ((KeyValuePair<int, string>)teamSel.SelectedItem).Key;
            else return 32;
        }

        private void teamSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirm.Enabled = teamSel.SelectedIndex > -1;
        }
    }
}
