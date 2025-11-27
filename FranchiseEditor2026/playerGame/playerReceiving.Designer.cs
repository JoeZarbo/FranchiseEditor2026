namespace FranchiseEditor2026.playerGame
{
    partial class playerReceiving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerReceiving));
            rec = new NumericUpDown();
            yds = new NumericUpDown();
            td = new NumericUpDown();
            confirm = new Button();
            cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)rec).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)td).BeginInit();
            SuspendLayout();
            // 
            // rec
            // 
            rec.Location = new Point(12, 32);
            rec.Name = "rec";
            rec.Size = new Size(120, 36);
            rec.TabIndex = 0;
            // 
            // yds
            // 
            yds.Location = new Point(12, 74);
            yds.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            yds.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            yds.Name = "yds";
            yds.Size = new Size(120, 36);
            yds.TabIndex = 1;
            // 
            // td
            // 
            td.Location = new Point(12, 116);
            td.Name = "td";
            td.Size = new Size(120, 36);
            td.TabIndex = 2;
            // 
            // confirm
            // 
            confirm.Location = new Point(12, 158);
            confirm.Name = "confirm";
            confirm.Size = new Size(392, 36);
            confirm.TabIndex = 3;
            confirm.Text = "confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(12, 200);
            cancel.Name = "cancel";
            cancel.Size = new Size(392, 36);
            cancel.TabIndex = 4;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 34);
            label1.Name = "label1";
            label1.Size = new Size(182, 29);
            label1.TabIndex = 5;
            label1.Text = "receptions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 76);
            label2.Name = "label2";
            label2.Size = new Size(159, 29);
            label2.TabIndex = 6;
            label2.Text = "rec yards";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 118);
            label3.Name = "label3";
            label3.Size = new Size(266, 29);
            label3.TabIndex = 7;
            label3.Text = "rec touchdowns";
            // 
            // playerLabel
            // 
            playerLabel.Dock = DockStyle.Top;
            playerLabel.Location = new Point(0, 0);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(410, 31);
            playerLabel.TabIndex = 8;
            playerLabel.Text = "label4";
            playerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerReceiving
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(410, 242);
            Controls.Add(playerLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(td);
            Controls.Add(yds);
            Controls.Add(rec);
            Font = new Font("Katahdin Round", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "playerReceiving";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receiving Stats";
            Load += playerReceiving_Load;
            ((System.ComponentModel.ISupportInitialize)rec).EndInit();
            ((System.ComponentModel.ISupportInitialize)yds).EndInit();
            ((System.ComponentModel.ISupportInitialize)td).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown rec;
        private NumericUpDown yds;
        private NumericUpDown td;
        private Button confirm;
        private Button cancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label playerLabel;
    }
}