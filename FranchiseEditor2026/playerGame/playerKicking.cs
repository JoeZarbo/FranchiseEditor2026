using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026.playerGame
{
    public partial class playerKicking : Form
    {
        private readonly PlayerGameObj player;

        public playerKicking(PlayerGameObj player)
        {
            InitializeComponent();
            this.player = player;
        }

        private void playerKicking_Load(object sender, EventArgs e)
        {
            playerLabel.Text = player.FullName;
            fgm.Value = player.FGM;
            fga.Value = player.FGA;
            xpm.Value = player.XPM;
            xpa.Value = player.XPA;
            fglong.Value = player.FGLong;
            blocks.Value = player.FGBlock;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            player.FGM = (int)fgm.Value;
            player.FGA = (int)fga.Value;
            player.XPM = (int)xpm.Value;
            player.XPA = (int)xpa.Value;
            player.FGLong = (int)fglong.Value;
            player.FGBlock = (int)blocks.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NumberUpdate(object sender, MouseEventArgs e)
        {
            var nud = (NumericUpDown)sender;
            if (e.Delta > 0) Math.Min(nud.Maximum, nud.Value + 1);
            else if (e.Delta < 0) Math.Min(nud.Minimum, nud.Value - 1);
        }
    }
}
