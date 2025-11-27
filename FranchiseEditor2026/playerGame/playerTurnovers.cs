using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026.playerGame
{
    public partial class playerTurnovers : Form
    {
        private readonly PlayerGameObj player;
        public playerTurnovers(PlayerGameObj player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void playerTurnovers_Load(object sender, EventArgs e)
        {
            playerLabel.Text = player.FullName;
            defint.Value = player.DefINT;
            intyds.Value = player.IntYds;
            inttd.Value = player.IntTD;
            pd.Value = player.PD;
            ff.Value = player.FF;
            fr.Value = player.FR;
            fyds.Value = player.FYds;
            ftd.Value = player.FTD;
            block.Value = player.DefBlock;
            safeties.Value = player.Safety;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            player.DefINT = (int)defint.Value;
            player.IntYds = (int)intyds.Value;
            player.IntTD = (int)inttd.Value;
            player.PD = (int)pd.Value;
            player.FF = (int)ff.Value;
            player.FR = (int)fr.Value;
            player.FYds = (int)fyds.Value;
            player.FTD = (int)ftd.Value;
            player.DefBlock = (int)block.Value;
            player.Safety = (int)safeties.Value;
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
