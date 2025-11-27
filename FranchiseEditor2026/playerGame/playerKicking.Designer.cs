namespace FranchiseEditor2026.playerGame
{
    partial class playerKicking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerKicking));
            fgm = new NumericUpDown();
            fga = new NumericUpDown();
            xpm = new NumericUpDown();
            xpa = new NumericUpDown();
            fglong = new NumericUpDown();
            blocks = new NumericUpDown();
            confirm = new Button();
            cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)fgm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xpa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fglong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blocks).BeginInit();
            SuspendLayout();
            // 
            // fgm
            // 
            fgm.Location = new Point(12, 38);
            fgm.Name = "fgm";
            fgm.Size = new Size(120, 36);
            fgm.TabIndex = 0;
            // 
            // fga
            // 
            fga.Location = new Point(12, 80);
            fga.Name = "fga";
            fga.Size = new Size(120, 36);
            fga.TabIndex = 1;
            // 
            // xpm
            // 
            xpm.Location = new Point(12, 122);
            xpm.Name = "xpm";
            xpm.Size = new Size(120, 36);
            xpm.TabIndex = 2;
            // 
            // xpa
            // 
            xpa.Location = new Point(12, 164);
            xpa.Name = "xpa";
            xpa.Size = new Size(120, 36);
            xpa.TabIndex = 3;
            // 
            // fglong
            // 
            fglong.Location = new Point(12, 206);
            fglong.Name = "fglong";
            fglong.Size = new Size(120, 36);
            fglong.TabIndex = 4;
            // 
            // blocks
            // 
            blocks.Location = new Point(12, 248);
            blocks.Name = "blocks";
            blocks.Size = new Size(120, 36);
            blocks.TabIndex = 5;
            // 
            // confirm
            // 
            confirm.Location = new Point(12, 290);
            confirm.Name = "confirm";
            confirm.Size = new Size(351, 36);
            confirm.TabIndex = 6;
            confirm.Text = "confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(12, 332);
            cancel.Name = "cancel";
            cancel.Size = new Size(351, 36);
            cancel.TabIndex = 7;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 40);
            label1.Name = "label1";
            label1.Size = new Size(151, 29);
            label1.TabIndex = 8;
            label1.Text = "fg makes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 82);
            label2.Name = "label2";
            label2.Size = new Size(198, 29);
            label2.TabIndex = 9;
            label2.Text = "fg attempts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 124);
            label3.Name = "label3";
            label3.Size = new Size(150, 29);
            label3.TabIndex = 10;
            label3.Text = "xp makes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 166);
            label4.Name = "label4";
            label4.Size = new Size(197, 29);
            label4.TabIndex = 11;
            label4.Text = "xp attempts";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 208);
            label5.Name = "label5";
            label5.Size = new Size(181, 29);
            label5.TabIndex = 12;
            label5.Text = "longest fg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 250);
            label6.Name = "label6";
            label6.Size = new Size(225, 29);
            label6.TabIndex = 13;
            label6.Text = "blocked kicks";
            // 
            // playerLabel
            // 
            playerLabel.Dock = DockStyle.Top;
            playerLabel.Location = new Point(0, 0);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(375, 35);
            playerLabel.TabIndex = 14;
            playerLabel.Text = "label7";
            playerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerKicking
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(375, 381);
            Controls.Add(playerLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(blocks);
            Controls.Add(fglong);
            Controls.Add(xpa);
            Controls.Add(xpm);
            Controls.Add(fga);
            Controls.Add(fgm);
            Font = new Font("Katahdin Round", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "playerKicking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kicking Stats";
            Load += playerKicking_Load;
            ((System.ComponentModel.ISupportInitialize)fgm).EndInit();
            ((System.ComponentModel.ISupportInitialize)fga).EndInit();
            ((System.ComponentModel.ISupportInitialize)xpm).EndInit();
            ((System.ComponentModel.ISupportInitialize)xpa).EndInit();
            ((System.ComponentModel.ISupportInitialize)fglong).EndInit();
            ((System.ComponentModel.ISupportInitialize)blocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown fgm;
        private NumericUpDown fga;
        private NumericUpDown xpm;
        private NumericUpDown xpa;
        private NumericUpDown fglong;
        private NumericUpDown blocks;
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