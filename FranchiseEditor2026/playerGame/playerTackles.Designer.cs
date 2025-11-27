namespace FranchiseEditor2026.playerGame
{
    partial class playerTackles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerTackles));
            soloTak = new NumericUpDown();
            astTak = new NumericUpDown();
            tfl = new NumericUpDown();
            sacks = new NumericUpDown();
            confirm = new Button();
            cancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)soloTak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)astTak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tfl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sacks).BeginInit();
            SuspendLayout();
            // 
            // soloTak
            // 
            soloTak.Location = new Point(12, 34);
            soloTak.Name = "soloTak";
            soloTak.Size = new Size(120, 36);
            soloTak.TabIndex = 0;
            // 
            // astTak
            // 
            astTak.Location = new Point(12, 76);
            astTak.Name = "astTak";
            astTak.Size = new Size(120, 36);
            astTak.TabIndex = 1;
            // 
            // tfl
            // 
            tfl.Location = new Point(12, 118);
            tfl.Name = "tfl";
            tfl.Size = new Size(120, 36);
            tfl.TabIndex = 2;
            // 
            // sacks
            // 
            sacks.DecimalPlaces = 1;
            sacks.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            sacks.Location = new Point(12, 160);
            sacks.Name = "sacks";
            sacks.Size = new Size(120, 36);
            sacks.TabIndex = 3;
            // 
            // confirm
            // 
            confirm.Location = new Point(12, 202);
            confirm.Name = "confirm";
            confirm.Size = new Size(395, 36);
            confirm.TabIndex = 4;
            confirm.Text = "confirm";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(12, 244);
            cancel.Name = "cancel";
            cancel.Size = new Size(395, 36);
            cancel.TabIndex = 5;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 36);
            label1.Name = "label1";
            label1.Size = new Size(214, 29);
            label1.TabIndex = 6;
            label1.Text = "solo tackles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 78);
            label2.Name = "label2";
            label2.Size = new Size(269, 29);
            label2.TabIndex = 7;
            label2.Text = "assisted tackles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 120);
            label3.Name = "label3";
            label3.Size = new Size(271, 29);
            label3.TabIndex = 8;
            label3.Text = "tackles for loss";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 162);
            label4.Name = "label4";
            label4.Size = new Size(100, 29);
            label4.TabIndex = 9;
            label4.Text = "sacks";
            // 
            // playerLabel
            // 
            playerLabel.Dock = DockStyle.Top;
            playerLabel.Location = new Point(0, 0);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(416, 31);
            playerLabel.TabIndex = 10;
            playerLabel.Text = "label5";
            playerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerTackles
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(416, 287);
            Controls.Add(playerLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(sacks);
            Controls.Add(tfl);
            Controls.Add(astTak);
            Controls.Add(soloTak);
            Font = new Font("Katahdin Round", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "playerTackles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tackles";
            Load += playerTackles_Load;
            ((System.ComponentModel.ISupportInitialize)soloTak).EndInit();
            ((System.ComponentModel.ISupportInitialize)astTak).EndInit();
            ((System.ComponentModel.ISupportInitialize)tfl).EndInit();
            ((System.ComponentModel.ISupportInitialize)sacks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown soloTak;
        private NumericUpDown astTak;
        private NumericUpDown tfl;
        private NumericUpDown sacks;
        private Button confirm;
        private Button cancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label playerLabel;
    }
}