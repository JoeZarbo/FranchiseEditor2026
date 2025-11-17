namespace FranchiseEditor2026
{
    partial class PlayerEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerEditor));
            playerSearch = new TextBox();
            playerGrid = new DataGridView();
            expAdd = new Button();
            expSub = new Button();
            ageAdd = new Button();
            ageSub = new Button();
            ovrAdd = new Button();
            ovrEdit = new Button();
            archetypeSel = new Button();
            numberSel = new Button();
            proBowl = new Button();
            close = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)playerGrid).BeginInit();
            SuspendLayout();
            // 
            // playerSearch
            // 
            playerSearch.Location = new Point(12, 12);
            playerSearch.Name = "playerSearch";
            playerSearch.Size = new Size(1213, 33);
            playerSearch.TabIndex = 0;
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
            playerGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Katahdin Round", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            playerGrid.DefaultCellStyle = dataGridViewCellStyle2;
            playerGrid.Location = new Point(12, 51);
            playerGrid.MultiSelect = false;
            playerGrid.Name = "playerGrid";
            playerGrid.Size = new Size(1329, 596);
            playerGrid.TabIndex = 1;
            playerGrid.SelectionChanged += playerGrid_SelectionChanged;
            // 
            // expAdd
            // 
            expAdd.Location = new Point(12, 653);
            expAdd.Name = "expAdd";
            expAdd.Size = new Size(104, 33);
            expAdd.TabIndex = 2;
            expAdd.Text = "+1 exp";
            expAdd.UseVisualStyleBackColor = true;
            expAdd.Click += expAdd_Click;
            // 
            // expSub
            // 
            expSub.Location = new Point(122, 653);
            expSub.Name = "expSub";
            expSub.Size = new Size(106, 33);
            expSub.TabIndex = 3;
            expSub.Text = "-1 exp";
            expSub.UseVisualStyleBackColor = true;
            expSub.Click += expSub_Click;
            // 
            // ageAdd
            // 
            ageAdd.Location = new Point(234, 653);
            ageAdd.Name = "ageAdd";
            ageAdd.Size = new Size(102, 33);
            ageAdd.TabIndex = 4;
            ageAdd.Text = "+1 age";
            ageAdd.UseVisualStyleBackColor = true;
            ageAdd.Click += ageAdd_Click;
            // 
            // ageSub
            // 
            ageSub.Location = new Point(342, 653);
            ageSub.Name = "ageSub";
            ageSub.Size = new Size(102, 33);
            ageSub.TabIndex = 5;
            ageSub.Text = "-1 Age";
            ageSub.UseVisualStyleBackColor = true;
            ageSub.Click += ageSub_Click;
            // 
            // ovrAdd
            // 
            ovrAdd.Enabled = false;
            ovrAdd.Location = new Point(450, 653);
            ovrAdd.Name = "ovrAdd";
            ovrAdd.Size = new Size(107, 33);
            ovrAdd.TabIndex = 6;
            ovrAdd.Text = "+1 ovr";
            ovrAdd.UseVisualStyleBackColor = true;
            ovrAdd.Click += ovrAdd_Click;
            // 
            // ovrEdit
            // 
            ovrEdit.Enabled = false;
            ovrEdit.Location = new Point(563, 653);
            ovrEdit.Name = "ovrEdit";
            ovrEdit.Size = new Size(136, 33);
            ovrEdit.TabIndex = 7;
            ovrEdit.Text = "edit ovr";
            ovrEdit.UseVisualStyleBackColor = true;
            ovrEdit.Click += ovrEdit_Click;
            // 
            // archetypeSel
            // 
            archetypeSel.Enabled = false;
            archetypeSel.Location = new Point(705, 653);
            archetypeSel.Name = "archetypeSel";
            archetypeSel.Size = new Size(228, 33);
            archetypeSel.TabIndex = 8;
            archetypeSel.Text = "edit archetype";
            archetypeSel.UseVisualStyleBackColor = true;
            archetypeSel.Click += archetypeSel_Click;
            // 
            // numberSel
            // 
            numberSel.Enabled = false;
            numberSel.Location = new Point(939, 653);
            numberSel.Name = "numberSel";
            numberSel.Size = new Size(128, 33);
            numberSel.TabIndex = 9;
            numberSel.Text = "number";
            numberSel.UseVisualStyleBackColor = true;
            numberSel.Click += numberSel_Click;
            // 
            // proBowl
            // 
            proBowl.Enabled = false;
            proBowl.Location = new Point(1073, 653);
            proBowl.Name = "proBowl";
            proBowl.Size = new Size(156, 33);
            proBowl.TabIndex = 10;
            proBowl.Text = "pro bowl";
            proBowl.UseVisualStyleBackColor = true;
            proBowl.Click += proBowl_Click;
            // 
            // close
            // 
            close.Location = new Point(1235, 653);
            close.Name = "close";
            close.Size = new Size(106, 33);
            close.TabIndex = 11;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1231, 15);
            label1.Name = "label1";
            label1.Size = new Size(110, 26);
            label1.TabIndex = 12;
            label1.Text = "search";
            // 
            // PlayerEditor
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1358, 698);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(proBowl);
            Controls.Add(numberSel);
            Controls.Add(archetypeSel);
            Controls.Add(ovrEdit);
            Controls.Add(ovrAdd);
            Controls.Add(ageSub);
            Controls.Add(ageAdd);
            Controls.Add(expSub);
            Controls.Add(expAdd);
            Controls.Add(playerGrid);
            Controls.Add(playerSearch);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PlayerEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Editor";
            Load += PlayerEditor_Load;
            ((System.ComponentModel.ISupportInitialize)playerGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox playerSearch;
        private DataGridView playerGrid;
        private Button expAdd;
        private Button expSub;
        private Button ageAdd;
        private Button ageSub;
        private Button ovrAdd;
        private Button ovrEdit;
        private Button archetypeSel;
        private Button numberSel;
        private Button proBowl;
        private Button close;
        private Label label1;
    }
}