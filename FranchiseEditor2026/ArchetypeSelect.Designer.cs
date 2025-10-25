namespace FranchiseEditor2026
{
    partial class ArchetypeSelect
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
            archType = new ComboBox();
            confirm = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // archType
            // 
            archType.FormattingEnabled = true;
            archType.Items.AddRange(new object[] { "Accurate", "Agile", "Blocking", "Deep Threat", "Elusive Back", "Field General", "Hybrid", "Improviser", "Man to Man", "Nose Tackle", "Pass Coverage", "Pass Protector", "Physical", "Playmaker", "Possession", "Power", "Power Back", "Power Rusher", "Receiving Back", "Run Stopper", "Run Support", "Scrambler", "Slot", "Speed Rusher", "Strong Arm", "Utility", "Vertical Threat", "Zone" });
            archType.Location = new Point(12, 12);
            archType.Name = "archType";
            archType.Size = new Size(305, 33);
            archType.TabIndex = 0;
            archType.Text = "select archetype";
            archType.SelectedIndexChanged += archType_SelectedIndexChanged;
            // 
            // confirm
            // 
            confirm.DialogResult = DialogResult.OK;
            confirm.Enabled = false;
            confirm.Location = new Point(12, 51);
            confirm.Name = "confirm";
            confirm.Size = new Size(305, 33);
            confirm.TabIndex = 1;
            confirm.Text = "confirm";
            confirm.TextAlign = ContentAlignment.MiddleLeft;
            confirm.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.DialogResult = DialogResult.Cancel;
            cancel.Location = new Point(12, 90);
            cancel.Name = "cancel";
            cancel.Size = new Size(305, 33);
            cancel.TabIndex = 2;
            cancel.Text = "cancel";
            cancel.TextAlign = ContentAlignment.MiddleLeft;
            cancel.UseVisualStyleBackColor = true;
            // 
            // ArchetypeSelect
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(322, 130);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(archType);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ArchetypeSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Archetype Select";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox archType;
        private Button confirm;
        private Button cancel;
    }
}