using System;
using System.Collections.Generic;
using System.Text;

namespace FranchiseEditor2026.playerGame
{
    public class NumericUpDownSingleScroll : NumericUpDown
    {
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (e.Delta > 0) this.Value = Math.Min(this.Maximum, this.Value + this.Increment);
            else if (e.Delta < 0) this.Value = Math.Min(this.Minimum, this.Value - this.Increment);
        }
    }
}
