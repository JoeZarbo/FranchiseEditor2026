using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026.playerGame
{
    public partial class playerRushing : Form
    {
        private readonly PlayerGameObj player;

        public playerRushing(PlayerGameObj player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void playerRushing_Load(object sender, EventArgs e)
        {
            playerLabel.Text = player.FullName;
            att.Value = player.RushAtt;
            yds.Value = player.RushYds;
            td.Value = player.RushTD;
            fumble.Value = player.Fmb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.RushAtt = (int)att.Value;
            player.RushYds = (int)yds.Value;
            player.RushTD = (int)td.Value;
            player.Fmb = (int)fumble.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
