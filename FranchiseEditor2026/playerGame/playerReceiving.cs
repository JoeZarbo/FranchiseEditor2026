using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026.playerGame
{
    public partial class playerReceiving : Form
    {
        private readonly PlayerGameObj player;
        public playerReceiving(PlayerGameObj player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void playerReceiving_Load(object sender, EventArgs e)
        {
            playerLabel.Text = player.FullName;
            rec.Value = player.Receptions;
            yds.Value = player.RecYds;
            td.Value = player.RecTD;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            player.Receptions = (int)rec.Value;
            player.RecYds = (int)yds.Value;
            player.RecTD = (int)td.Value;
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
