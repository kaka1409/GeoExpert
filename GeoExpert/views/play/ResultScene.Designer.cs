namespace GeoExpert.Views.Play
{
    partial class ResultScene
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
            ContinueButton = new Button();
            BacktoMenuButton = new Button();
            ResultLabel = new Label();
            TimeResult = new Label();
            TimeResultLabel = new Label();
            label2 = new Label();
            ScoreResultLabel = new Label();
            CorrectAnswersResultLabel = new Label();
            label5 = new Label();
            InccorrectAnswerResultLabel = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = Color.FromArgb(255, 210, 150);
            ContinueButton.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            ContinueButton.FlatAppearance.BorderSize = 3;
            ContinueButton.FlatStyle = FlatStyle.Flat;
            ContinueButton.Font = new Font("Algerian", 10F);
            ContinueButton.Location = new Point(576, 391);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(156, 30);
            ContinueButton.TabIndex = 6;
            ContinueButton.Text = "Continue playning";
            ContinueButton.UseVisualStyleBackColor = false;
            // 
            // BacktoMenuButton
            // 
            BacktoMenuButton.BackColor = Color.FromArgb(255, 210, 150);
            BacktoMenuButton.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            BacktoMenuButton.FlatAppearance.BorderSize = 3;
            BacktoMenuButton.FlatStyle = FlatStyle.Flat;
            BacktoMenuButton.Font = new Font("Algerian", 10F);
            BacktoMenuButton.Location = new Point(161, 391);
            BacktoMenuButton.Name = "BacktoMenuButton";
            BacktoMenuButton.Size = new Size(141, 30);
            BacktoMenuButton.TabIndex = 7;
            BacktoMenuButton.Text = "Back to menu";
            BacktoMenuButton.UseVisualStyleBackColor = false;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.BackColor = Color.Transparent;
            ResultLabel.Font = new Font("Algerian", 25F);
            ResultLabel.Location = new Point(319, 30);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(253, 38);
            ResultLabel.TabIndex = 8;
            ResultLabel.Text = "Your results";
            // 
            // TimeResult
            // 
            TimeResult.AutoSize = true;
            TimeResult.BackColor = Color.Transparent;
            TimeResult.Font = new Font("Algerian", 15F);
            TimeResult.Location = new Point(161, 118);
            TimeResult.Name = "TimeResult";
            TimeResult.Size = new Size(130, 22);
            TimeResult.TabIndex = 9;
            TimeResult.Text = "Time taken:";
            // 
            // TimeResultLabel
            // 
            TimeResultLabel.AutoSize = true;
            TimeResultLabel.BackColor = Color.Transparent;
            TimeResultLabel.Font = new Font("Algerian", 15F, FontStyle.Bold);
            TimeResultLabel.ForeColor = SystemColors.ActiveCaptionText;
            TimeResultLabel.Location = new Point(454, 118);
            TimeResultLabel.Name = "TimeResultLabel";
            TimeResultLabel.Size = new Size(278, 22);
            TimeResultLabel.TabIndex = 10;
            TimeResultLabel.Text = "0 minutes and 0 seconds";
            TimeResultLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Algerian", 15F);
            label2.Location = new Point(161, 174);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 11;
            label2.Text = "Score: ";
            // 
            // ScoreResultLabel
            // 
            ScoreResultLabel.AutoSize = true;
            ScoreResultLabel.BackColor = Color.Transparent;
            ScoreResultLabel.Font = new Font("Algerian", 15F, FontStyle.Bold);
            ScoreResultLabel.ForeColor = SystemColors.ActiveCaptionText;
            ScoreResultLabel.Location = new Point(709, 174);
            ScoreResultLabel.Name = "ScoreResultLabel";
            ScoreResultLabel.Size = new Size(23, 22);
            ScoreResultLabel.TabIndex = 12;
            ScoreResultLabel.Text = "0";
            ScoreResultLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CorrectAnswersResultLabel
            // 
            CorrectAnswersResultLabel.AutoSize = true;
            CorrectAnswersResultLabel.BackColor = Color.Transparent;
            CorrectAnswersResultLabel.Font = new Font("Algerian", 15F, FontStyle.Bold);
            CorrectAnswersResultLabel.ForeColor = Color.FromArgb(0, 150, 0);
            CorrectAnswersResultLabel.Location = new Point(685, 231);
            CorrectAnswersResultLabel.Name = "CorrectAnswersResultLabel";
            CorrectAnswersResultLabel.Size = new Size(47, 22);
            CorrectAnswersResultLabel.TabIndex = 14;
            CorrectAnswersResultLabel.Text = "0/0";
            CorrectAnswersResultLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Algerian", 15F);
            label5.Location = new Point(161, 231);
            label5.Name = "label5";
            label5.Size = new Size(233, 22);
            label5.TabIndex = 13;
            label5.Text = "Answered correctly:";
            // 
            // InccorrectAnswerResultLabel
            // 
            InccorrectAnswerResultLabel.AutoSize = true;
            InccorrectAnswerResultLabel.BackColor = Color.Transparent;
            InccorrectAnswerResultLabel.Font = new Font("Algerian", 15F, FontStyle.Bold);
            InccorrectAnswerResultLabel.ForeColor = Color.Red;
            InccorrectAnswerResultLabel.Location = new Point(685, 287);
            InccorrectAnswerResultLabel.Name = "InccorrectAnswerResultLabel";
            InccorrectAnswerResultLabel.Size = new Size(47, 22);
            InccorrectAnswerResultLabel.TabIndex = 16;
            InccorrectAnswerResultLabel.Text = "0/0";
            InccorrectAnswerResultLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Algerian", 15F);
            label7.Location = new Point(161, 287);
            label7.Name = "label7";
            label7.Size = new Size(251, 22);
            label7.TabIndex = 15;
            label7.Text = "Answered Incorrectly:";
            // 
            // ResultScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurredBackground;
            Controls.Add(InccorrectAnswerResultLabel);
            Controls.Add(label7);
            Controls.Add(CorrectAnswersResultLabel);
            Controls.Add(label5);
            Controls.Add(ScoreResultLabel);
            Controls.Add(label2);
            Controls.Add(TimeResultLabel);
            Controls.Add(TimeResult);
            Controls.Add(ResultLabel);
            Controls.Add(BacktoMenuButton);
            Controls.Add(ContinueButton);
            Name = "ResultScene";
            Size = new Size(899, 483);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button ContinueButton;
        public Button BacktoMenuButton;
        private Label ResultLabel;
        private Label TimeResult;
        private Label TimeResultLabel;
        private Label label2;
        private Label ScoreResultLabel;
        private Label CorrectAnswersResultLabel;
        private Label label5;
        private Label InccorrectAnswerResultLabel;
        private Label label7;
    }
}
