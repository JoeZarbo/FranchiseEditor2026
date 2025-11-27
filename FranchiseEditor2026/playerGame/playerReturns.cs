using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026.playerGame
{
    public partial class playerReturns : Form
    {
        private readonly PlayerGameObj player;
        public playerReturns(PlayerGameObj player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void playerReturns_Load(object sender, EventArgs e)
        {
            playerLabel.Text = player.FullName;
            kr.Value = player.KR;
            kryds.Value = player.KRYds;
            krtd.Value = player.KRTD;
            pr.Value = player.PR;
            pryds.Value = player.PRYds;
            prtd.Value = player.PRTD;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            player.KR = (int)kr.Value;
            player.KRYds = (int)kryds.Value;
            player.KRTD = (int)krtd.Value;
            player.PR = (int)pr.Value;
            player.PRYds = (int)pryds.Value;
            player.PRTD = (int)prtd.Value;
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
