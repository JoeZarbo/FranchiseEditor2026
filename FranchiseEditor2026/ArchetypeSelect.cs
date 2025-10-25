using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026
{
    public partial class ArchetypeSelect : Form
    {
        public ArchetypeSelect()
        {
            InitializeComponent();
        }

        private void archType_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirm.Enabled = archType.SelectedIndex > -1;
        }

        public string GetArchetype()
        {
            if (ShowDialog() == DialogResult.OK && archType.SelectedItem is not null) return archType.SelectedItem.ToString();
            else return "Man to Man";
        }
    }
}
