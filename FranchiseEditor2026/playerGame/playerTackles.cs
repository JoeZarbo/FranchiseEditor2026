using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026.playerGame
{
    public partial class playerTackles : Form
    {
        private readonly PlayerGameObj player;
        public playerTackles(PlayerGameObj player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void playerTackles_Load(object sender, EventArgs e)
        {
            playerLabel.Text = player.FullName;
            soloTak.Value = player.SoloTak;
            astTak.Value = player.AstTak;
            tfl.Value = player.TFL;
            sacks.Value = player.DefSK;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            player.SoloTak = (int)soloTak.Value;
            player.AstTak = (int)astTak.Value;
            player.TFL = (int)tfl.Value;
            player.DefSK = sacks.Value;
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
