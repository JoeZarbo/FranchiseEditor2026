namespace FranchiseEditor2026.playerGame
{
    partial class playerPassing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerPassing));
            cmp = new NumericUpDown();
            att = new NumericUpDown();
            yds = new NumericUpDown();
            td = new NumericUpDown();
            passInt = new NumericUpDown();
            sacks = new NumericUpDown();
            confirm = new Button();
            cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)cmp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)att).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)td).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passInt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sacks).BeginInit();
            SuspendLayout();
            // 
            // cmp
            // 
            cmp.Location = new Point(12, 41);
            cmp.Name = "cmp";
            cmp.Size = new Size(120, 36);
            cmp.TabIndex = 0;
            // 
            // att
            // 
            att.Location = new Point(12, 83);
            att.Name = "att";
            att.Size = new Size(120, 36);
            att.TabIndex = 1;
            // 
            // yds
            // 
            yds.Location = new Point(12, 125);
            yds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            yds.Name = "yds";
            yds.Size = new Size(120, 36);
            yds.TabIndex = 2;
            // 
            // td
            // 
            td.Location = new Point(12, 167);
            td.Name = "td";
            td.Size = new Size(120, 36);
            td.TabIndex = 3;
            // 
            // passInt
            // 
            passInt.Location = new Point(12, 209);
            passInt.Name = "passInt";
            passInt.Size = new Size(120, 36);
            passInt.TabIndex = 4;
            // 
            // sacks
            // 
            sacks.Location = new Point(12, 251);
            sacks.Name = "sacks";
            sacks.Size = new Size(120, 36);
            sacks.TabIndex = 5;
            // 
            // confirm
            // 
            confirm.Location = new Point(8, 293);
            confirm.Name = "confirm";
            confirm.Size = new Size(354, 36);
            confirm.TabIndex = 6;
            confirm.Text = "confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(12, 335);
            cancel.Name = "cancel";
            cancel.Size = new Size(354, 36);
            cancel.TabIndex = 7;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 43);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 8;
            label1.Text = "completions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 85);
            label2.Name = "label2";
            label2.Size = new Size(228, 29);
            label2.TabIndex = 9;
            label2.Text = "pass attempts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 127);
            label3.Name = "label3";
            label3.Size = new Size(174, 29);
            label3.TabIndex = 9;
            label3.Text = "pass yards";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 169);
            label4.Name = "label4";
            label4.Size = new Size(207, 29);
            label4.TabIndex = 9;
            label4.Text = "touchdowns";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 211);
            label5.Name = "label5";
            label5.Size = new Size(226, 29);
            label5.TabIndex = 9;
            label5.Text = "interceptions";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 253);
            label6.Name = "label6";
            label6.Size = new Size(100, 29);
            label6.TabIndex = 9;
            label6.Text = "sacks";
            // 
            // playerLabel
            // 
            playerLabel.Dock = DockStyle.Top;
            playerLabel.Location = new Point(0, 0);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(374, 29);
            playerLabel.TabIndex = 10;
            playerLabel.Text = "player name";
            playerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerPassing
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(374, 378);
            Controls.Add(playerLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(sacks);
            Controls.Add(passInt);
            Controls.Add(td);
            Controls.Add(yds);
            Controls.Add(att);
            Controls.Add(cmp);
            Font = new Font("Katahdin Round", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "playerPassing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passing Stats";
            Load += playerPassing_Load;
            ((System.ComponentModel.ISupportInitialize)cmp).EndInit();
            ((System.ComponentModel.ISupportInitialize)att).EndInit();
            ((System.ComponentModel.ISupportInitialize)yds).EndInit();
            ((System.ComponentModel.ISupportInitialize)td).EndInit();
            ((System.ComponentModel.ISupportInitialize)passInt).EndInit();
            ((System.ComponentModel.ISupportInitialize)sacks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown cmp;
        private NumericUpDown att;
        private NumericUpDown yds;
        private NumericUpDown td;
        private NumericUpDown passInt;
        private NumericUpDown sacks;
        private Button confirm;
        private Button cancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label playerLabel;
    }
}