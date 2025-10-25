namespace FranchiseEditor2026
{
    partial class TeamSelect
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
            teamSel = new ComboBox();
            confirm = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // teamSel
            // 
            teamSel.FormattingEnabled = true;
            teamSel.Location = new Point(12, 12);
            teamSel.Name = "teamSel";
            teamSel.Size = new Size(452, 33);
            teamSel.TabIndex = 0;
            teamSel.Text = "select team";
            teamSel.SelectedIndexChanged += teamSel_SelectedIndexChanged;
            // 
            // confirm
            // 
            confirm.DialogResult = DialogResult.OK;
            confirm.Enabled = false;
            confirm.Location = new Point(12, 51);
            confirm.Name = "confirm";
            confirm.Size = new Size(452, 33);
            confirm.TabIndex = 1;
            confirm.Text = "confirm";
            confirm.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.DialogResult = DialogResult.Cancel;
            cancel.Location = new Point(12, 90);
            cancel.Name = "cancel";
            cancel.Size = new Size(452, 33);
            cancel.TabIndex = 2;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // TeamSelect
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(474, 132);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(teamSel);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TeamSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Team Select";
            Load += TeamSelect_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox teamSel;
        private Button confirm;
        private Button cancel;
    }
}