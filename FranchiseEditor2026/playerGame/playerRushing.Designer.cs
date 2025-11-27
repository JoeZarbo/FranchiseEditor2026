namespace FranchiseEditor2026.playerGame
{
    partial class playerRushing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerRushing));
            att = new NumericUpDown();
            yds = new NumericUpDown();
            td = new NumericUpDown();
            fumble = new NumericUpDown();
            button1 = new Button();
            cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)att).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)td).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fumble).BeginInit();
            SuspendLayout();
            // 
            // att
            // 
            att.Location = new Point(12, 40);
            att.Name = "att";
            att.Size = new Size(120, 36);
            att.TabIndex = 0;
            // 
            // yds
            // 
            yds.Location = new Point(12, 82);
            yds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            yds.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            yds.Name = "yds";
            yds.Size = new Size(120, 36);
            yds.TabIndex = 1;
            // 
            // td
            // 
            td.Location = new Point(12, 124);
            td.Name = "td";
            td.Size = new Size(120, 36);
            td.TabIndex = 2;
            // 
            // fumble
            // 
            fumble.Location = new Point(12, 166);
            fumble.Name = "fumble";
            fumble.Size = new Size(120, 36);
            fumble.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 208);
            button1.Name = "button1";
            button1.Size = new Size(359, 36);
            button1.TabIndex = 4;
            button1.Text = "confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(12, 250);
            cancel.Name = "cancel";
            cancel.Size = new Size(359, 36);
            cancel.TabIndex = 5;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 42);
            label1.Name = "label1";
            label1.Size = new Size(233, 29);
            label1.TabIndex = 6;
            label1.Text = "rush attempts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 84);
            label2.Name = "label2";
            label2.Size = new Size(179, 29);
            label2.TabIndex = 7;
            label2.Text = "rush yards";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 126);
            label3.Name = "label3";
            label3.Size = new Size(215, 29);
            label3.TabIndex = 8;
            label3.Text = "touchdowns ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 168);
            label4.Name = "label4";
            label4.Size = new Size(139, 29);
            label4.TabIndex = 9;
            label4.Text = "fumbles";
            // 
            // playerLabel
            // 
            playerLabel.Dock = DockStyle.Top;
            playerLabel.Location = new Point(0, 0);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(382, 37);
            playerLabel.TabIndex = 10;
            playerLabel.Text = "playerName";
            playerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerRushing
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(382, 294);
            Controls.Add(playerLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(button1);
            Controls.Add(fumble);
            Controls.Add(td);
            Controls.Add(yds);
            Controls.Add(att);
            Font = new Font("Katahdin Round", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "playerRushing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rushing Stats";
            Load += playerRushing_Load;
            ((System.ComponentModel.ISupportInitialize)att).EndInit();
            ((System.ComponentModel.ISupportInitialize)yds).EndInit();
            ((System.ComponentModel.ISupportInitialize)td).EndInit();
            ((System.ComponentModel.ISupportInitialize)fumble).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown att;
        private NumericUpDown yds;
        private NumericUpDown td;
        private NumericUpDown fumble;
        private Button button1;
        private Button cancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label playerLabel;
    }
}