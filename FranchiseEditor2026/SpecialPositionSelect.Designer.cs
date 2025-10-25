namespace FranchiseEditor2026
{
    partial class SpecialPositionSelect
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
            posSel = new ComboBox();
            confirm = new Button();
            cancel = new Button();
            SuspendLayout();
            // 
            // posSel
            // 
            posSel.FormattingEnabled = true;
            posSel.Items.AddRange(new object[] { "FB", "SWR", "LT", "LG", "C", "RG", "RT", "DE", "DT", "NT", "LB", "SCB" });
            posSel.Location = new Point(12, 12);
            posSel.Name = "posSel";
            posSel.Size = new Size(244, 33);
            posSel.TabIndex = 0;
            posSel.Text = "select position";
            posSel.SelectedIndexChanged += posSel_SelectedIndexChanged;
            // 
            // confirm
            // 
            confirm.DialogResult = DialogResult.OK;
            confirm.Enabled = false;
            confirm.Location = new Point(12, 51);
            confirm.Name = "confirm";
            confirm.Size = new Size(244, 33);
            confirm.TabIndex = 1;
            confirm.Text = "CONFIRM";
            confirm.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            cancel.DialogResult = DialogResult.Cancel;
            cancel.Location = new Point(12, 90);
            cancel.Name = "cancel";
            cancel.Size = new Size(244, 33);
            cancel.TabIndex = 2;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // SpecialPositionSelect
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(266, 135);
            Controls.Add(cancel);
            Controls.Add(confirm);
            Controls.Add(posSel);
            Font = new Font("Katahdin Round", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SpecialPositionSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Special Position Select";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox posSel;
        private Button confirm;
        private Button cancel;
    }
}