using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026.playerGame
{
    public partial class playerPunting : Form
    {
        private readonly PlayerGameObj player;

        public playerPunting(PlayerGameObj player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void playerPunting_Load(object sender, EventArgs e)
        {
            playerLabel.Text = player.FullName;
            punts.Value = player.Pnt;
            puntYds.Value = player.PntYds;
            netYds.Value = player.PntYds - player.RetYds;
            tb.Value = player.TB;
            in20.Value = player.In20;
            puntBlocks.Value = player.PuntBlock;
            superSim.Checked = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            player.Pnt = (int)punts.Value;
            player.PntYds = (int)puntYds.Value;
            if (superSim.Checked) player.RetYds = (int)(puntYds.Value - (netYds.Value + tb.Value * 20));
            else player.RetYds = (int)(puntYds.Value - netYds.Value);
            player.TB = (int)tb.Value;
            player.In20 = (int)in20.Value;
            player.PuntBlock = (int)puntBlocks.Value;
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
