namespace FranchiseEditor2026
{
    partial class DraftController
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
            playerSearch = new TextBox();
            playerGrid = new DataGridView();
            teamSel = new ComboBox();
            draft = new Button();
            udfa = new Button();
            close = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)yearSel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerGrid).BeginInit();
            SuspendLayout();
            // 
            // yearSel
            // 
            yearSel.Location = new Point(12, 12);
            yearSel.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            yearSel.Minimum = new decimal(new int[] { 2026, 0, 0, 0 });
            yearSel.Name = "yearSel";
            yearSel.Size = new Size(88, 33);
            yearSel.TabIndex = 0;
            yearSel.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            yearSel.ValueChanged += yearSel_ValueChanged;
            // 
            // playerSearch
            // 
            playerSearch.Location = new Point(189, 12);
            playerSearch.Name = "playerSearch";
            playerSearch.Size = new Size(332, 33);
            playerSearch.TabIndex = 1;
            playerSearch.TextChanged += playerSearch_TextChanged;
            // 
            // playerGrid
            // 
            playerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            playerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerGrid.Location = new Point(12, 51);
            playerGrid.Name = "playerGrid";
            playerGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            playerGrid.Size = new Size(625, 509);
            playerGrid.TabIndex = 2;
            playerGrid.SelectionChanged += playerGrid_SelectionChanged;
            // 
            // teamSel
            // 
            teamSel.FormattingEnabled = true;
            teamSel.Location = new Point(12, 566);
            teamSel.Name = "teamSel";
            teamSel.Size = new Size(625, 33);
            teamSel.TabIndex = 3;
            teamSel.Text = "select team";
            teamSel.SelectedIndexChanged += teamSel_SelectedIndexChanged;
            // 
            // draft
            // 
            draft.Location = new Point(12, 605);
            draft.Name = "draft";
            draft.Size = new Size(295, 33);
            draft.TabIndex = 4;
            draft.Text = "draft";
            draft.UseVisualStyleBackColor = true;
            draft.Click += draft_Click;
            // 
            // udfa
            // 
            udfa.Location = new Point(313, 605);
            udfa.Name = "udfa";
            udfa.Size = new Size(324, 33);
            udfa.TabIndex = 5;
            udfa.Text = "make udfas";
            udfa.UseVisualStyleBackColor = true;
            udfa.Click += udfa_Click;
            // 
            // close
            // 
            close.Location = new Point(12, 644);
            close.Name = "close";
            close.Size = new Size(625, 33);
            close.TabIndex = 6;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 14);
            label1.Name = "label1";
            label1.Size = new Size(77, 26);
            label1.TabIndex = 7;
            label1.Text = "year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 14);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 8;
            label2.Text = "search";
            // 
            // DraftController
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(648, 686);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(udfa);
            Controls.Add(draft);
            Controls.Add(teamSel);
            Controls.Add(playerGrid);
            Controls.Add(playerSearch);
            Controls.Add(yearSel);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DraftController";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Draft Controller";
            Load += DraftController_Load;
            ((System.ComponentModel.ISupportInitialize)yearSel).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown yearSel;
        private TextBox playerSearch;
        private DataGridView playerGrid;
        private ComboBox teamSel;
        private Button draft;
        private Button udfa;
        private Button close;
        private Label label1;
        private Label label2;
    }
}