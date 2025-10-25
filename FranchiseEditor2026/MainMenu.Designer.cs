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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            // button1
            // 
            button1.Location = new Point(13, 42);
            button1.Name = "button1";
            button1.Size = new Size(342, 36);
            button1.TabIndex = 1;
            button1.Text = "Roster Editor";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(361, 42);
            button2.Name = "button2";
            button2.Size = new Size(342, 36);
            button2.TabIndex = 2;
            button2.Text = "Player Editor";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(13, 84);
            button3.Name = "button3";
            button3.Size = new Size(342, 36);
            button3.TabIndex = 3;
            button3.Text = "Draft Editor";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(361, 84);
            button4.Name = "button4";
            button4.Size = new Size(342, 36);
            button4.TabIndex = 4;
            button4.Text = "Schedule Creator";
            button4.UseVisualStyleBackColor = true;
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
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button close;
        private Button button5;
    }
}
