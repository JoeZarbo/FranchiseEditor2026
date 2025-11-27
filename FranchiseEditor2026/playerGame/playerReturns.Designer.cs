namespace FranchiseEditor2026.playerGame
{
    partial class playerReturns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerReturns));
            kr = new NumericUpDown();
            kryds = new NumericUpDown();
            krtd = new NumericUpDown();
            pr = new NumericUpDown();
            pryds = new NumericUpDown();
            prtd = new NumericUpDown();
            confirm = new Button();
            cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)kr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)krtd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pryds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prtd).BeginInit();
            SuspendLayout();
            // 
            // kr
            // 
            kr.Location = new Point(12, 37);
            kr.Name = "kr";
            kr.Size = new Size(120, 36);
            kr.TabIndex = 0;
            // 
            // kryds
            // 
            kryds.Location = new Point(12, 79);
            kryds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            kryds.Name = "kryds";
            kryds.Size = new Size(120, 36);
            kryds.TabIndex = 1;
            // 
            // krtd
            // 
            krtd.Location = new Point(12, 121);
            krtd.Name = "krtd";
            krtd.Size = new Size(120, 36);
            krtd.TabIndex = 2;
            // 
            // pr
            // 
            pr.Location = new Point(12, 163);
            pr.Name = "pr";
            pr.Size = new Size(120, 36);
            pr.TabIndex = 3;
            // 
            // pryds
            // 
            pryds.Location = new Point(12, 205);
            pryds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            pryds.Name = "pryds";
            pryds.Size = new Size(120, 36);
            pryds.TabIndex = 4;
            // 
            // prtd
            // 
            prtd.Location = new Point(12, 247);
            prtd.Name = "prtd";
            prtd.Size = new Size(120, 36);
            prtd.TabIndex = 5;
            // 
            // confirm
            // 
            confirm.Location = new Point(12, 289);
            confirm.Name = "confirm";
            confirm.Size = new Size(409, 36);
            confirm.TabIndex = 6;
            confirm.Text = "confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(12, 331);
            cancel.Name = "cancel";
            cancel.Size = new Size(409, 36);
            cancel.TabIndex = 7;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 39);
            label1.Name = "label1";
            label1.Size = new Size(206, 29);
            label1.TabIndex = 8;
            label1.Text = "kick returns";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 81);
            label2.Name = "label2";
            label2.Size = new Size(283, 29);
            label2.TabIndex = 9;
            label2.Text = "kick return yards";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 123);
            label3.Name = "label3";
            label3.Size = new Size(232, 29);
            label3.TabIndex = 10;
            label3.Text = "kick return td";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 165);
            label4.Name = "label4";
            label4.Size = new Size(215, 29);
            label4.TabIndex = 11;
            label4.Text = "punt returns";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 207);
            label5.Name = "label5";
            label5.Size = new Size(292, 29);
            label5.TabIndex = 12;
            label5.Text = "punt return yards";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 249);
            label6.Name = "label6";
            label6.Size = new Size(241, 29);
            label6.TabIndex = 13;
            label6.Text = "punt return td";
            // 
            // playerLabel
            // 
            playerLabel.Dock = DockStyle.Top;
            playerLabel.Location = new Point(0, 0);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(429, 34);
            playerLabel.TabIndex = 14;
            playerLabel.Text = "label7";
            playerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerReturns
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(429, 375);
            Controls.Add(playerLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(prtd);
            Controls.Add(pryds);
            Controls.Add(pr);
            Controls.Add(krtd);
            Controls.Add(kryds);
            Controls.Add(kr);
            Font = new Font("Katahdin Round", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "playerReturns";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return Stats";
            Load += playerReturns_Load;
            ((System.ComponentModel.ISupportInitialize)kr).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryds).EndInit();
            ((System.ComponentModel.ISupportInitialize)krtd).EndInit();
            ((System.ComponentModel.ISupportInitialize)pr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pryds).EndInit();
            ((System.ComponentModel.ISupportInitialize)prtd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown kr;
        private NumericUpDown kryds;
        private NumericUpDown krtd;
        private NumericUpDown pr;
        private NumericUpDown pryds;
        private NumericUpDown prtd;
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