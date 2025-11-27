namespace FranchiseEditor2026
{
    partial class playerGameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerGameMenu));
            yearSel = new NumericUpDown();
            weekSel = new NumericUpDown();
            gameSel = new ComboBox();
            teamSel = new ComboBox();
            playerGrid = new DataGridView();
            export = new Button();
            reset = new Button();
            close = new Button();
            label1 = new Label();
            weekLabel = new Label();
            awayTeam = new NumericUpDown();
            homeTeam = new NumericUpDown();
            label2 = new Label();
            checkplayoffs = new CheckBox();
            playerSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)yearSel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weekSel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)awayTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeTeam).BeginInit();
            SuspendLayout();
            // 
            // yearSel
            // 
            yearSel.Location = new Point(12, 12);
            yearSel.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            yearSel.Minimum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearSel.Name = "yearSel";
            yearSel.Size = new Size(120, 33);
            yearSel.TabIndex = 0;
            yearSel.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // weekSel
            // 
            weekSel.Location = new Point(264, 12);
            weekSel.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            weekSel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            weekSel.Name = "weekSel";
            weekSel.Size = new Size(120, 33);
            weekSel.TabIndex = 1;
            weekSel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            weekSel.ValueChanged += weekSel_ValueChanged;
            // 
            // gameSel
            // 
            gameSel.FormattingEnabled = true;
            gameSel.Location = new Point(875, 12);
            gameSel.Name = "gameSel";
            gameSel.Size = new Size(396, 33);
            gameSel.TabIndex = 2;
            gameSel.Text = "select game";
            gameSel.SelectedIndexChanged += gameSel_SelectedIndexChanged;
            // 
            // teamSel
            // 
            teamSel.Enabled = false;
            teamSel.FormattingEnabled = true;
            teamSel.Location = new Point(1277, 12);
            teamSel.Name = "teamSel";
            teamSel.Size = new Size(410, 33);
            teamSel.TabIndex = 3;
            teamSel.Text = "select team";
            teamSel.SelectedIndexChanged += teamSel_SelectedIndexChanged;
            // 
            // playerGrid
            // 
            playerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerGrid.Location = new Point(12, 89);
            playerGrid.Name = "playerGrid";
            playerGrid.Size = new Size(1675, 585);
            playerGrid.TabIndex = 4;
            // 
            // export
            // 
            export.Location = new Point(12, 680);
            export.Name = "export";
            export.Size = new Size(609, 34);
            export.TabIndex = 5;
            export.Text = "export players";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
            // 
            // reset
            // 
            reset.Location = new Point(627, 680);
            reset.Name = "reset";
            reset.Size = new Size(525, 34);
            reset.TabIndex = 6;
            reset.Text = "reset files";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // close
            // 
            close.Location = new Point(1158, 680);
            close.Name = "close";
            close.Size = new Size(529, 34);
            close.TabIndex = 7;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.Location = new Point(138, 14);
            label1.Name = "label1";
            label1.Size = new Size(120, 26);
            label1.TabIndex = 8;
            label1.Text = "year";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weekLabel
            // 
            weekLabel.AutoSize = true;
            weekLabel.Location = new Point(390, 14);
            weekLabel.Name = "weekLabel";
            weekLabel.Size = new Size(198, 26);
            weekLabel.TabIndex = 9;
            weekLabel.Text = "championship";
            // 
            // awayTeam
            // 
            awayTeam.Location = new Point(606, 12);
            awayTeam.Name = "awayTeam";
            awayTeam.Size = new Size(70, 33);
            awayTeam.TabIndex = 10;
            // 
            // homeTeam
            // 
            homeTeam.Location = new Point(682, 13);
            homeTeam.Name = "homeTeam";
            homeTeam.Size = new Size(70, 33);
            homeTeam.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(758, 15);
            label2.Name = "label2";
            label2.Size = new Size(97, 26);
            label2.TabIndex = 12;
            label2.Text = "score";
            // 
            // checkplayoffs
            // 
            checkplayoffs.AutoSize = true;
            checkplayoffs.Location = new Point(1535, 51);
            checkplayoffs.Name = "checkplayoffs";
            checkplayoffs.Size = new Size(152, 30);
            checkplayoffs.TabIndex = 13;
            checkplayoffs.Text = "playoffs";
            checkplayoffs.UseVisualStyleBackColor = true;
            // 
            // playerSearch
            // 
            playerSearch.Location = new Point(12, 51);
            playerSearch.Name = "playerSearch";
            playerSearch.Size = new Size(1517, 33);
            playerSearch.TabIndex = 14;
            playerSearch.TextChanged += playerSearch_TextChanged;
            // 
            // playerGameMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1699, 720);
            Controls.Add(playerSearch);
            Controls.Add(checkplayoffs);
            Controls.Add(label2);
            Controls.Add(homeTeam);
            Controls.Add(awayTeam);
            Controls.Add(weekLabel);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(reset);
            Controls.Add(export);
            Controls.Add(playerGrid);
            Controls.Add(teamSel);
            Controls.Add(gameSel);
            Controls.Add(weekSel);
            Controls.Add(yearSel);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "playerGameMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Game Menu";
            Load += playerGameMenu_Load;
            ((System.ComponentModel.ISupportInitialize)yearSel).EndInit();
            ((System.ComponentModel.ISupportInitialize)weekSel).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)awayTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeTeam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown yearSel;
        private NumericUpDown weekSel;
        private ComboBox gameSel;
        private ComboBox teamSel;
        private DataGridView playerGrid;
        private Button export;
        private Button reset;
        private Button close;
        private Label label1;
        private Label weekLabel;
        private NumericUpDown awayTeam;
        private NumericUpDown homeTeam;
        private Label label2;
        private CheckBox checkplayoffs;
        private TextBox playerSearch;
    }
}