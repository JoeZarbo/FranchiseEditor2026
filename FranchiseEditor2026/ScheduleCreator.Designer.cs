namespace FranchiseEditor2026
{
    partial class ScheduleCreator
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
            isBye = new CheckBox();
            dateSel = new ComboBox();
            timeSel = new TextBox();
            awayTeam = new ComboBox();
            homeTeam = new ComboBox();
            addGame = new Button();
            clear = new Button();
            close = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)yearSel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weekSel).BeginInit();
            SuspendLayout();
            // 
            // yearSel
            // 
            yearSel.Location = new Point(12, 12);
            yearSel.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            yearSel.Minimum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearSel.Name = "yearSel";
            yearSel.Size = new Size(91, 33);
            yearSel.TabIndex = 0;
            yearSel.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // weekSel
            // 
            weekSel.Location = new Point(192, 12);
            weekSel.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            weekSel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            weekSel.Name = "weekSel";
            weekSel.Size = new Size(91, 33);
            weekSel.TabIndex = 1;
            weekSel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // isBye
            // 
            isBye.AutoSize = true;
            isBye.Location = new Point(376, 12);
            isBye.Name = "isBye";
            isBye.Size = new Size(153, 30);
            isBye.TabIndex = 2;
            isBye.Text = "bye week";
            isBye.UseVisualStyleBackColor = true;
            isBye.CheckedChanged += isBye_CheckedChanged;
            // 
            // dateSel
            // 
            dateSel.FormattingEnabled = true;
            dateSel.Items.AddRange(new object[] { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" });
            dateSel.Location = new Point(12, 51);
            dateSel.Name = "dateSel";
            dateSel.Size = new Size(435, 33);
            dateSel.TabIndex = 3;
            dateSel.Text = "select date";
            dateSel.SelectedIndexChanged += dateSel_SelectedIndexChanged;
            // 
            // timeSel
            // 
            timeSel.Location = new Point(12, 90);
            timeSel.Name = "timeSel";
            timeSel.Size = new Size(435, 33);
            timeSel.TabIndex = 4;
            timeSel.TextChanged += timeSel_TextChanged;
            // 
            // awayTeam
            // 
            awayTeam.FormattingEnabled = true;
            awayTeam.Location = new Point(12, 155);
            awayTeam.Name = "awayTeam";
            awayTeam.Size = new Size(259, 33);
            awayTeam.TabIndex = 5;
            awayTeam.SelectedIndexChanged += awayTeam_SelectedIndexChanged;
            // 
            // homeTeam
            // 
            homeTeam.FormattingEnabled = true;
            homeTeam.Location = new Point(277, 155);
            homeTeam.Name = "homeTeam";
            homeTeam.Size = new Size(252, 33);
            homeTeam.TabIndex = 6;
            homeTeam.SelectedIndexChanged += homeTeam_SelectedIndexChanged;
            // 
            // addGame
            // 
            addGame.Enabled = false;
            addGame.Location = new Point(12, 194);
            addGame.Name = "addGame";
            addGame.Size = new Size(259, 33);
            addGame.TabIndex = 7;
            addGame.Text = "add game";
            addGame.UseVisualStyleBackColor = true;
            addGame.Click += addGame_Click;
            // 
            // clear
            // 
            clear.Location = new Point(277, 194);
            clear.Name = "clear";
            clear.Size = new Size(252, 33);
            clear.TabIndex = 8;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // close
            // 
            close.Location = new Point(12, 233);
            close.Name = "close";
            close.Size = new Size(517, 33);
            close.TabIndex = 9;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 58);
            label1.Name = "label1";
            label1.Size = new Size(72, 26);
            label1.TabIndex = 10;
            label1.Text = "date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 16);
            label2.Name = "label2";
            label2.Size = new Size(77, 26);
            label2.TabIndex = 11;
            label2.Text = "year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 16);
            label3.Name = "label3";
            label3.Size = new Size(81, 26);
            label3.TabIndex = 12;
            label3.Text = "week";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 93);
            label4.Name = "label4";
            label4.Size = new Size(72, 26);
            label4.TabIndex = 13;
            label4.Text = "time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 126);
            label5.Name = "label5";
            label5.Size = new Size(151, 26);
            label5.TabIndex = 14;
            label5.Text = "away team";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(319, 126);
            label6.Name = "label6";
            label6.Size = new Size(156, 26);
            label6.TabIndex = 15;
            label6.Text = "home team";
            // 
            // ScheduleCreator
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(540, 281);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(clear);
            Controls.Add(addGame);
            Controls.Add(homeTeam);
            Controls.Add(awayTeam);
            Controls.Add(timeSel);
            Controls.Add(dateSel);
            Controls.Add(isBye);
            Controls.Add(weekSel);
            Controls.Add(yearSel);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScheduleCreator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Schedule Creator";
            Load += ScheduleCreator_Load;
            ((System.ComponentModel.ISupportInitialize)yearSel).EndInit();
            ((System.ComponentModel.ISupportInitialize)weekSel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown yearSel;
        private NumericUpDown weekSel;
        private CheckBox isBye;
        private ComboBox dateSel;
        private TextBox timeSel;
        private ComboBox awayTeam;
        private ComboBox homeTeam;
        private Button addGame;
        private Button clear;
        private Button close;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}