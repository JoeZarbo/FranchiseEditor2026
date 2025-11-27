using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026.playerGame
{
    public partial class playerPassing : Form
    {
        private readonly PlayerGameObj player;

        public playerPassing(PlayerGameObj player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void playerPassing_Load(object sender, EventArgs e)
        {
            playerLabel.Text = player.FullName;

            cmp.Value = player.Cmp;
            att.Value = player.PassAtt;
            yds.Value = player.PassYds;
            td.Value = player.PassTD;
            passInt.Value = player.PassINT;
            sacks.Value = player.PassSK;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            player.Cmp = (int)cmp.Value;
            player.PassAtt = (int)att.Value;
            player.PassYds = (int)yds.Value;
            player.PassTD = (int)td.Value;
            player.PassINT = (int)passInt.Value;
            player.PassSK = (int)sacks.Value;
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
