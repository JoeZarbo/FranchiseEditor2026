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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            label1 = new Label();
            rosterEditor = new Button();
            playerEditor = new Button();
            draftEditor = new Button();
            schedule = new Button();
            close = new Button();
            potw = new Button();
            h2hCont = new Button();
            teamAdd = new Button();
            playerAdd = new Button();
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
            close.Location = new Point(12, 210);
            close.Name = "close";
            close.Size = new Size(690, 36);
            close.TabIndex = 9;
            close.Text = "close";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // potw
            // 
            potw.Location = new Point(13, 126);
            potw.Name = "potw";
            potw.Size = new Size(342, 36);
            potw.TabIndex = 5;
            potw.Text = "Player of the Week";
            potw.UseVisualStyleBackColor = true;
            potw.Click += potw_Click;
            // 
            // h2hCont
            // 
            h2hCont.Location = new Point(361, 126);
            h2hCont.Name = "h2hCont";
            h2hCont.Size = new Size(342, 36);
            h2hCont.TabIndex = 6;
            h2hCont.Text = "head to head";
            h2hCont.UseVisualStyleBackColor = true;
            h2hCont.Click += h2hCont_Click;
            // 
            // teamAdd
            // 
            teamAdd.Location = new Point(13, 168);
            teamAdd.Name = "teamAdd";
            teamAdd.Size = new Size(342, 36);
            teamAdd.TabIndex = 7;
            teamAdd.Text = "team game";
            teamAdd.UseVisualStyleBackColor = true;
            teamAdd.Click += teamAdd_Click;
            // 
            // playerAdd
            // 
            playerAdd.Location = new Point(361, 168);
            playerAdd.Name = "playerAdd";
            playerAdd.Size = new Size(341, 36);
            playerAdd.TabIndex = 8;
            playerAdd.Text = "player game";
            playerAdd.UseVisualStyleBackColor = true;
            playerAdd.Click += playerAdd_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(715, 251);
            Controls.Add(playerAdd);
            Controls.Add(teamAdd);
            Controls.Add(h2hCont);
            Controls.Add(potw);
            Controls.Add(close);
            Controls.Add(schedule);
            Controls.Add(draftEditor);
            Controls.Add(playerEditor);
            Controls.Add(rosterEditor);
            Controls.Add(label1);
            Font = new Font("Katahdin Round", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button potw;
        private Button h2hCont;
        private Button teamAdd;
        private Button playerAdd;
    }
}
