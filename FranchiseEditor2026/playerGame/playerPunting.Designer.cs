namespace FranchiseEditor2026.playerGame
{
    partial class playerPunting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerPunting));
            punts = new NumericUpDown();
            puntYds = new NumericUpDown();
            netYds = new NumericUpDown();
            tb = new NumericUpDown();
            in20 = new NumericUpDown();
            puntBlocks = new NumericUpDown();
            superSim = new CheckBox();
            confirm = new Button();
            cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)punts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)puntYds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)netYds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)in20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)puntBlocks).BeginInit();
            SuspendLayout();
            // 
            // punts
            // 
            punts.Location = new Point(12, 42);
            punts.Name = "punts";
            punts.Size = new Size(120, 36);
            punts.TabIndex = 0;
            // 
            // puntYds
            // 
            puntYds.Location = new Point(12, 84);
            puntYds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            puntYds.Name = "puntYds";
            puntYds.Size = new Size(120, 36);
            puntYds.TabIndex = 1;
            // 
            // netYds
            // 
            netYds.Location = new Point(12, 126);
            netYds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            netYds.Name = "netYds";
            netYds.Size = new Size(120, 36);
            netYds.TabIndex = 2;
            // 
            // tb
            // 
            tb.Location = new Point(12, 168);
            tb.Name = "tb";
            tb.Size = new Size(120, 36);
            tb.TabIndex = 3;
            // 
            // in20
            // 
            in20.Location = new Point(12, 210);
            in20.Name = "in20";
            in20.Size = new Size(120, 36);
            in20.TabIndex = 4;
            // 
            // puntBlocks
            // 
            puntBlocks.Location = new Point(12, 252);
            puntBlocks.Name = "puntBlocks";
            puntBlocks.Size = new Size(120, 36);
            puntBlocks.TabIndex = 5;
            // 
            // superSim
            // 
            superSim.AutoSize = true;
            superSim.Location = new Point(12, 294);
            superSim.Name = "superSim";
            superSim.Size = new Size(177, 33);
            superSim.TabIndex = 6;
            superSim.Text = "super sim";
            superSim.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            confirm.Location = new Point(12, 333);
            confirm.Name = "confirm";
            confirm.Size = new Size(367, 36);
            confirm.TabIndex = 7;
            confirm.Text = "confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(12, 375);
            cancel.Name = "cancel";
            cancel.Size = new Size(367, 36);
            cancel.TabIndex = 8;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 44);
            label1.Name = "label1";
            label1.Size = new Size(102, 29);
            label1.TabIndex = 9;
            label1.Text = "punts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 86);
            label2.Name = "label2";
            label2.Size = new Size(178, 29);
            label2.TabIndex = 10;
            label2.Text = "punt yards";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 128);
            label3.Name = "label3";
            label3.Size = new Size(158, 29);
            label3.TabIndex = 11;
            label3.Text = "net yards";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 170);
            label4.Name = "label4";
            label4.Size = new Size(195, 29);
            label4.TabIndex = 12;
            label4.Text = "touchbacks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 212);
            label5.Name = "label5";
            label5.Size = new Size(241, 29);
            label5.TabIndex = 13;
            label5.Text = "punts inside 20";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 254);
            label6.Name = "label6";
            label6.Size = new Size(236, 29);
            label6.TabIndex = 14;
            label6.Text = "blocked punts";
            // 
            // playerLabel
            // 
            playerLabel.Dock = DockStyle.Top;
            playerLabel.Location = new Point(0, 0);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(389, 39);
            playerLabel.TabIndex = 15;
            playerLabel.Text = "label7";
            playerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerPunting
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(389, 418);
            Controls.Add(playerLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(superSim);
            Controls.Add(puntBlocks);
            Controls.Add(in20);
            Controls.Add(tb);
            Controls.Add(netYds);
            Controls.Add(puntYds);
            Controls.Add(punts);
            Font = new Font("Katahdin Round", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "playerPunting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punting Stats";
            Load += playerPunting_Load;
            ((System.ComponentModel.ISupportInitialize)punts).EndInit();
            ((System.ComponentModel.ISupportInitialize)puntYds).EndInit();
            ((System.ComponentModel.ISupportInitialize)netYds).EndInit();
            ((System.ComponentModel.ISupportInitialize)tb).EndInit();
            ((System.ComponentModel.ISupportInitialize)in20).EndInit();
            ((System.ComponentModel.ISupportInitialize)puntBlocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown punts;
        private NumericUpDown puntYds;
        private NumericUpDown netYds;
        private NumericUpDown tb;
        private NumericUpDown in20;
        private NumericUpDown puntBlocks;
        private CheckBox superSim;
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