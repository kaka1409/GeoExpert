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
            QuestionList = new ListBox();
            button2 = new Button();
            DeleteQuestionBtn = new Button();
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
            // QuestionList
            // 
            QuestionList.FormattingEnabled = true;
            QuestionList.ItemHeight = 15;
            QuestionList.Location = new Point(91, 114);
            QuestionList.Name = "QuestionList";
            QuestionList.Size = new Size(451, 259);
            QuestionList.TabIndex = 4;
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
            // DeleteQuestionBtn
            // 
            DeleteQuestionBtn.Location = new Point(613, 239);
            DeleteQuestionBtn.Name = "DeleteQuestionBtn";
            DeleteQuestionBtn.Size = new Size(114, 23);
            DeleteQuestionBtn.TabIndex = 6;
            DeleteQuestionBtn.Text = "Delete question";
            DeleteQuestionBtn.UseVisualStyleBackColor = true;
            DeleteQuestionBtn.Click += DeleteQuestionBtn_Click;
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
            Controls.Add(DeleteQuestionBtn);
            Controls.Add(button2);
            Controls.Add(QuestionList);
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
        private ListBox QuestionList;
        private Button button2;
        private Button DeleteQuestionBtn;
        private Label GameTitle;
    }
}
