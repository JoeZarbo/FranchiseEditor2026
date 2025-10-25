using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FranchiseEditor2026
{
    public partial class NumberSelect : Form
    {
        public NumberSelect()
        {
            InitializeComponent();
        }

        public int GetNumber()
        {
            if (ShowDialog() == DialogResult.OK && numberSel.Value > -1) return (int)numberSel.Value;
            else return 0;
        }

        public int GetNumber(int min, int max)
        {
            numberSel.Minimum = min;
            numberSel.Maximum = max;
            if (ShowDialog() == DialogResult.OK && numberSel.Value > -1) return (int)numberSel.Value;
            else return 0;
        }
    }
}
