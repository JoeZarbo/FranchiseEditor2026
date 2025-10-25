using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026
{
    public partial class SpecialPositionSelect : Form
    {
        public SpecialPositionSelect()
        {
            InitializeComponent();
        }

        private void posSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirm.Enabled = posSel.SelectedIndex > -1;
        }

        public string GetPos()
        {
            if (ShowDialog() == DialogResult.OK && posSel.SelectedItem is not null) return posSel.SelectedItem.ToString();
            else return "";
        }
    }
}
