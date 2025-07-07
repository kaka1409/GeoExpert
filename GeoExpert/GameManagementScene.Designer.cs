namespace GeoExpert
{
    partial class GameManagementScene
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddQuestionBtn = new Button();
            ExitBtn = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            GameTitle = new Label();
            SuspendLayout();
            // 
            // AddQuestionBtn
            // 
            AddQuestionBtn.Cursor = Cursors.Hand;
            AddQuestionBtn.Location = new Point(613, 114);
            AddQuestionBtn.Name = "AddQuestionBtn";
            AddQuestionBtn.Size = new Size(114, 23);
            AddQuestionBtn.TabIndex = 0;
            AddQuestionBtn.Text = "Add question";
            AddQuestionBtn.UseVisualStyleBackColor = true;
            AddQuestionBtn.Click += button1_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(255, 210, 150);
            ExitBtn.Cursor = Cursors.Hand;
            ExitBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            ExitBtn.FlatAppearance.BorderSize = 3;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Algerian", 10F);
            ExitBtn.Location = new Point(15, 18);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(76, 31);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "< Back";
            ExitBtn.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(91, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(451, 259);
            listBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(613, 179);
            button2.Name = "button2";
            button2.Size = new Size(114, 23);
            button2.TabIndex = 5;
            button2.Text = "Edit question";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(613, 239);
            button3.Name = "button3";
            button3.Size = new Size(114, 23);
            button3.TabIndex = 6;
            button3.Text = "Delete question";
            button3.UseVisualStyleBackColor = true;
            // 
            // GameTitle
            // 
            GameTitle.AutoSize = true;
            GameTitle.Font = new Font("Algerian", 15F);
            GameTitle.Location = new Point(91, 79);
            GameTitle.Name = "GameTitle";
            GameTitle.Size = new Size(187, 22);
            GameTitle.TabIndex = 7;
            GameTitle.Text = "Game's questions";
            // 
            // GameManagementScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.blurredBackground;
            Controls.Add(GameTitle);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(ExitBtn);
            Controls.Add(AddQuestionBtn);
            Name = "GameManagementScene";
            Size = new Size(816, 489);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button AddQuestionBtn;
        public Button ExitBtn;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Label GameTitle;
    }
}
