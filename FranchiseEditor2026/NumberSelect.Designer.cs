namespace FranchiseEditor2026
{
    partial class NumberSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numberSel = new NumericUpDown();
            button1 = new Button();
            cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numberSel).BeginInit();
            SuspendLayout();
            // 
            // numberSel
            // 
            numberSel.Location = new Point(12, 12);
            numberSel.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numberSel.Name = "numberSel";
            numberSel.Size = new Size(194, 33);
            numberSel.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(12, 51);
            button1.Name = "button1";
            button1.Size = new Size(194, 33);
            button1.TabIndex = 1;
            button1.Text = "confirm";
            button1.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.DialogResult = DialogResult.Cancel;
            cancel.Location = new Point(12, 90);
            cancel.Name = "cancel";
            cancel.Size = new Size(194, 33);
            cancel.TabIndex = 2;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // NumberSelect
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(217, 132);
            Controls.Add(cancel);
            Controls.Add(button1);
            Controls.Add(numberSel);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NumberSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Number Select";
            ((System.ComponentModel.ISupportInitialize)numberSel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numberSel;
        private Button button1;
        private Button cancel;
    }
}