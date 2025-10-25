namespace FranchiseEditor2026
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            rosterEditor = new Button();
            playerEditor = new Button();
            draftEditor = new Button();
            schedule = new Button();
            close = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 0;
            label1.Text = "main menu";
            // 
            // rosterEditor
            // 
            rosterEditor.Location = new Point(13, 42);
            rosterEditor.Name = "rosterEditor";
            rosterEditor.Size = new Size(342, 36);
            rosterEditor.TabIndex = 1;
            rosterEditor.Text = "Roster Editor";
            rosterEditor.UseVisualStyleBackColor = true;
            rosterEditor.Click += rosterEditor_Click;
            // 
            // playerEditor
            // 
            playerEditor.Location = new Point(361, 42);
            playerEditor.Name = "playerEditor";
            playerEditor.Size = new Size(342, 36);
            playerEditor.TabIndex = 2;
            playerEditor.Text = "Player Editor";
            playerEditor.UseVisualStyleBackColor = true;
            playerEditor.Click += playerEditor_Click;
            // 
            // draftEditor
            // 
            draftEditor.Location = new Point(13, 84);
            draftEditor.Name = "draftEditor";
            draftEditor.Size = new Size(342, 36);
            draftEditor.TabIndex = 3;
            draftEditor.Text = "Draft Editor";
            draftEditor.UseVisualStyleBackColor = true;
            draftEditor.Click += draftEditor_Click;
            // 
            // schedule
            // 
            schedule.Location = new Point(361, 84);
            schedule.Name = "schedule";
            schedule.Size = new Size(342, 36);
            schedule.TabIndex = 4;
            schedule.Text = "Schedule Creator";
            schedule.UseVisualStyleBackColor = true;
            schedule.Click += schedule_Click;
            // 
            // close
            // 
            close.Location = new Point(361, 126);
            close.Name = "close";
            close.Size = new Size(342, 36);
            close.TabIndex = 6;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // button5
            // 
            button5.Location = new Point(13, 126);
            button5.Name = "button5";
            button5.Size = new Size(342, 36);
            button5.TabIndex = 5;
            button5.Text = "Player of the Week";
            button5.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(715, 172);
            Controls.Add(button5);
            Controls.Add(close);
            Controls.Add(schedule);
            Controls.Add(draftEditor);
            Controls.Add(playerEditor);
            Controls.Add(rosterEditor);
            Controls.Add(label1);
            Font = new Font("Katahdin Round", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenu";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button rosterEditor;
        private Button playerEditor;
        private Button draftEditor;
        private Button schedule;
        private Button close;
        private Button button5;
    }
}
