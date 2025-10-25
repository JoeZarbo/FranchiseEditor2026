namespace FranchiseEditor2026
{
    partial class POTWUI
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
            yearSel = new NumericUpDown();
            weekSel = new NumericUpDown();
            typeSel = new ComboBox();
            generate = new Button();
            outPlayers = new ListBox();
            close = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)yearSel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weekSel).BeginInit();
            SuspendLayout();
            // 
            // yearSel
            // 
            yearSel.Location = new Point(12, 12);
            yearSel.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            yearSel.Minimum = new decimal(new int[] { 2024, 0, 0, 0 });
            yearSel.Name = "yearSel";
            yearSel.Size = new Size(120, 33);
            yearSel.TabIndex = 0;
            yearSel.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // weekSel
            // 
            weekSel.Location = new Point(221, 12);
            weekSel.Maximum = new decimal(new int[] { 18, 0, 0, 0 });
            weekSel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            weekSel.Name = "weekSel";
            weekSel.Size = new Size(113, 33);
            weekSel.TabIndex = 1;
            weekSel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // typeSel
            // 
            typeSel.FormattingEnabled = true;
            typeSel.Items.AddRange(new object[] { "offense", "defense", "rookies" });
            typeSel.Location = new Point(427, 12);
            typeSel.Name = "typeSel";
            typeSel.Size = new Size(219, 33);
            typeSel.TabIndex = 2;
            typeSel.Text = "type";
            typeSel.SelectedIndexChanged += typeSel_SelectedIndexChanged;
            // 
            // generate
            // 
            generate.Enabled = false;
            generate.Location = new Point(12, 51);
            generate.Name = "generate";
            generate.Size = new Size(634, 33);
            generate.TabIndex = 3;
            generate.Text = "generate players";
            generate.UseVisualStyleBackColor = true;
            generate.Click += generate_Click;
            // 
            // outPlayers
            // 
            outPlayers.FormattingEnabled = true;
            outPlayers.Location = new Point(12, 90);
            outPlayers.Name = "outPlayers";
            outPlayers.Size = new Size(634, 654);
            outPlayers.TabIndex = 4;
            // 
            // close
            // 
            close.Location = new Point(12, 750);
            close.Name = "close";
            close.Size = new Size(634, 33);
            close.TabIndex = 5;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 14);
            label1.Name = "label1";
            label1.Size = new Size(77, 26);
            label1.TabIndex = 6;
            label1.Text = "year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 14);
            label2.Name = "label2";
            label2.Size = new Size(81, 26);
            label2.TabIndex = 7;
            label2.Text = "week";
            // 
            // POTWUI
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(660, 793);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(outPlayers);
            Controls.Add(generate);
            Controls.Add(typeSel);
            Controls.Add(weekSel);
            Controls.Add(yearSel);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "POTWUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player of the Week Generator";
            ((System.ComponentModel.ISupportInitialize)yearSel).EndInit();
            ((System.ComponentModel.ISupportInitialize)weekSel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown yearSel;
        private NumericUpDown weekSel;
        private ComboBox typeSel;
        private Button generate;
        private ListBox outPlayers;
        private Button close;
        private Label label1;
        private Label label2;
    }
}