namespace FranchiseEditor2026
{
    partial class RosterEditor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            teamSel = new ComboBox();
            playerSearch = new TextBox();
            playerGrid = new DataGridView();
            cutPlayer = new Button();
            signPlayer = new Button();
            tradePlayer = new Button();
            toggleStarter = new Button();
            posSel = new Button();
            close = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)playerGrid).BeginInit();
            SuspendLayout();
            // 
            // teamSel
            // 
            teamSel.FormattingEnabled = true;
            teamSel.Location = new Point(12, 12);
            teamSel.Name = "teamSel";
            teamSel.Size = new Size(831, 33);
            teamSel.TabIndex = 0;
            teamSel.Text = "select team";
            teamSel.SelectedIndexChanged += teamSel_SelectedIndexChanged;
            // 
            // playerSearch
            // 
            playerSearch.Enabled = false;
            playerSearch.Location = new Point(12, 51);
            playerSearch.Name = "playerSearch";
            playerSearch.Size = new Size(730, 33);
            playerSearch.TabIndex = 1;
            playerSearch.TextChanged += playerSearch_TextChanged;
            // 
            // playerGrid
            // 
            playerGrid.AllowUserToAddRows = false;
            playerGrid.AllowUserToDeleteRows = false;
            playerGrid.AllowUserToResizeColumns = false;
            playerGrid.AllowUserToResizeRows = false;
            playerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Katahdin Round", 14F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            playerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            playerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Katahdin Round", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            playerGrid.DefaultCellStyle = dataGridViewCellStyle2;
            playerGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            playerGrid.Location = new Point(12, 90);
            playerGrid.Name = "playerGrid";
            playerGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            playerGrid.Size = new Size(831, 275);
            playerGrid.TabIndex = 2;
            // 
            // cutPlayer
            // 
            cutPlayer.Enabled = false;
            cutPlayer.Location = new Point(12, 371);
            cutPlayer.Name = "cutPlayer";
            cutPlayer.Size = new Size(74, 33);
            cutPlayer.TabIndex = 3;
            cutPlayer.Text = "cut";
            cutPlayer.UseVisualStyleBackColor = true;
            cutPlayer.Click += cutPlayer_Click;
            // 
            // signPlayer
            // 
            signPlayer.Enabled = false;
            signPlayer.Location = new Point(92, 371);
            signPlayer.Name = "signPlayer";
            signPlayer.Size = new Size(80, 33);
            signPlayer.TabIndex = 4;
            signPlayer.Text = "sign";
            signPlayer.UseVisualStyleBackColor = true;
            signPlayer.Click += signPlayer_Click;
            // 
            // tradePlayer
            // 
            tradePlayer.Enabled = false;
            tradePlayer.Location = new Point(178, 371);
            tradePlayer.Name = "tradePlayer";
            tradePlayer.Size = new Size(105, 33);
            tradePlayer.TabIndex = 5;
            tradePlayer.Text = "trade";
            tradePlayer.UseVisualStyleBackColor = true;
            tradePlayer.Click += tradePlayer_Click;
            // 
            // toggleStarter
            // 
            toggleStarter.Enabled = false;
            toggleStarter.Location = new Point(289, 371);
            toggleStarter.Name = "toggleStarter";
            toggleStarter.Size = new Size(238, 33);
            toggleStarter.TabIndex = 6;
            toggleStarter.Text = "toggle starter";
            toggleStarter.UseVisualStyleBackColor = true;
            toggleStarter.Click += toggleStarter_Click;
            // 
            // posSel
            // 
            posSel.Enabled = false;
            posSel.Location = new Point(533, 371);
            posSel.Name = "posSel";
            posSel.Size = new Size(196, 33);
            posSel.TabIndex = 7;
            posSel.Text = "set position";
            posSel.UseVisualStyleBackColor = true;
            posSel.Click += posSel_Click;
            // 
            // close
            // 
            close.Location = new Point(735, 371);
            close.Name = "close";
            close.Size = new Size(108, 33);
            close.TabIndex = 8;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Katahdin Round", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(748, 56);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 9;
            label1.Text = "search";
            // 
            // RosterEditor
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(854, 411);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(posSel);
            Controls.Add(toggleStarter);
            Controls.Add(tradePlayer);
            Controls.Add(signPlayer);
            Controls.Add(cutPlayer);
            Controls.Add(playerGrid);
            Controls.Add(playerSearch);
            Controls.Add(teamSel);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RosterEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Roster Editor";
            Load += RosterEditor_Load;
            ((System.ComponentModel.ISupportInitialize)playerGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox teamSel;
        private TextBox playerSearch;
        private DataGridView playerGrid;
        private Button cutPlayer;
        private Button signPlayer;
        private Button tradePlayer;
        private Button toggleStarter;
        private Button posSel;
        private Button close;
        private Label label1;
    }
}