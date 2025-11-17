namespace FranchiseEditor2026
{
    partial class HeadToHead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadToHead));
            yearSel = new NumericUpDown();
            weekSel = new NumericUpDown();
            teamGrid = new DataGridView();
            confirm = new Button();
            close = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)yearSel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weekSel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamGrid).BeginInit();
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
            yearSel.ValueChanged += yearSel_ValueChanged;
            // 
            // weekSel
            // 
            weekSel.Location = new Point(221, 12);
            weekSel.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            weekSel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            weekSel.Name = "weekSel";
            weekSel.Size = new Size(120, 33);
            weekSel.TabIndex = 1;
            weekSel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            weekSel.ValueChanged += weekSel_ValueChanged;
            // 
            // teamGrid
            // 
            teamGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            teamGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teamGrid.Location = new Point(12, 51);
            teamGrid.Name = "teamGrid";
            teamGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            teamGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            teamGrid.Size = new Size(816, 312);
            teamGrid.TabIndex = 2;
            // 
            // confirm
            // 
            confirm.Location = new Point(12, 369);
            confirm.Name = "confirm";
            confirm.Size = new Size(406, 33);
            confirm.TabIndex = 3;
            confirm.Text = "add";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // close
            // 
            close.Location = new Point(424, 369);
            close.Name = "close";
            close.Size = new Size(404, 33);
            close.TabIndex = 4;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 14);
            label1.Name = "label1";
            label1.Size = new Size(77, 26);
            label1.TabIndex = 5;
            label1.Text = "year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 14);
            label2.Name = "label2";
            label2.Size = new Size(81, 26);
            label2.TabIndex = 6;
            label2.Text = "week";
            // 
            // HeadToHead
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(840, 412);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(confirm);
            Controls.Add(teamGrid);
            Controls.Add(weekSel);
            Controls.Add(yearSel);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HeadToHead";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Head to Head";
            Load += HeadToHead_Load;
            ((System.ComponentModel.ISupportInitialize)yearSel).EndInit();
            ((System.ComponentModel.ISupportInitialize)weekSel).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown yearSel;
        private NumericUpDown weekSel;
        private DataGridView teamGrid;
        private Button confirm;
        private Button close;
        private Label label1;
        private Label label2;
    }
}