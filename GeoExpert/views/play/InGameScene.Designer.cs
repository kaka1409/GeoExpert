namespace GeoExpert.Views.Play
{
    partial class InGameScene
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
            components = new System.ComponentModel.Container();
            NumberIndicator = new Label();
            QuestionList = new ListBox();
            NextButton = new Button();
            PreviousButton = new Button();
            ExitButton = new Button();
            QuestionTypeTab = new GeoExpert.Views.Widget.Custom.TransparentTabControl();
            MultiChoicePage = new TabPage();
            MultiChoicePanel = new Panel();
            Answer4Label = new Label();
            Answer3Label = new Label();
            Answer2Label = new Label();
            Answer1Label = new Label();
            AnswerIndicator = new Label();
            Radio4 = new RadioButton();
            Radio3 = new RadioButton();
            Radio2 = new RadioButton();
            Radio1 = new RadioButton();
            TrueFalsePage = new TabPage();
            TrueFalseAnswerIndicator = new Label();
            FalseLabel = new Label();
            TrueLabel = new Label();
            FalseRadio = new RadioButton();
            TrueRadio = new RadioButton();
            OpenEndedPage = new TabPage();
            label2 = new Label();
            AnswerInput = new RichTextBox();
            EmptyPage = new TabPage();
            QuestionListButton = new Button();
            SubmitButton = new Button();
            QuestionNumerLabel = new Label();
            TimeLabel = new Label();
            Time = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            QuestionContent = new RichTextBox();
            QuestionTypeTab.SuspendLayout();
            MultiChoicePage.SuspendLayout();
            MultiChoicePanel.SuspendLayout();
            TrueFalsePage.SuspendLayout();
            OpenEndedPage.SuspendLayout();
            SuspendLayout();
            // 
            // NumberIndicator
            // 
            NumberIndicator.AutoSize = true;
            NumberIndicator.BackColor = Color.Transparent;
            NumberIndicator.Font = new Font("Algerian", 12F);
            NumberIndicator.Location = new Point(116, 75);
            NumberIndicator.Name = "NumberIndicator";
            NumberIndicator.Size = new Size(98, 18);
            NumberIndicator.TabIndex = 0;
            NumberIndicator.Text = "Question 0:";
            // 
            // QuestionList
            // 
            QuestionList.BackColor = Color.FromArgb(255, 210, 150);
            QuestionList.BorderStyle = BorderStyle.None;
            QuestionList.Font = new Font("Algerian", 9F);
            QuestionList.FormattingEnabled = true;
            QuestionList.ItemHeight = 14;
            QuestionList.Location = new Point(613, 74);
            QuestionList.Name = "QuestionList";
            QuestionList.Size = new Size(165, 294);
            QuestionList.TabIndex = 2;
            QuestionList.Visible = false;
            QuestionList.SelectedIndexChanged += QuestionList_SelectedIndexChanged;
            // 
            // NextButton
            // 
            NextButton.BackColor = Color.FromArgb(255, 210, 150);
            NextButton.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            NextButton.FlatAppearance.BorderSize = 3;
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Algerian", 10F);
            NextButton.Location = new Point(493, 395);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(81, 33);
            NextButton.TabIndex = 3;
            NextButton.Text = "Next";
            NextButton.UseVisualStyleBackColor = false;
            NextButton.Click += NextButton_Click;
            // 
            // PreviousButton
            // 
            PreviousButton.BackColor = Color.FromArgb(255, 210, 150);
            PreviousButton.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            PreviousButton.FlatAppearance.BorderSize = 3;
            PreviousButton.FlatStyle = FlatStyle.Flat;
            PreviousButton.Font = new Font("Algerian", 10F);
            PreviousButton.Location = new Point(113, 395);
            PreviousButton.Name = "PreviousButton";
            PreviousButton.Size = new Size(87, 33);
            PreviousButton.TabIndex = 4;
            PreviousButton.Text = "Previous";
            PreviousButton.UseVisualStyleBackColor = false;
            PreviousButton.Click += PreviousButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(255, 210, 150);
            ExitButton.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            ExitButton.FlatAppearance.BorderSize = 3;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Algerian", 10F);
            ExitButton.Location = new Point(27, 20);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 30);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // QuestionTypeTab
            // 
            QuestionTypeTab.Controls.Add(MultiChoicePage);
            QuestionTypeTab.Controls.Add(TrueFalsePage);
            QuestionTypeTab.Controls.Add(OpenEndedPage);
            QuestionTypeTab.Controls.Add(EmptyPage);
            QuestionTypeTab.ItemSize = new Size(0, 1);
            QuestionTypeTab.Location = new Point(3, 192);
            QuestionTypeTab.Name = "QuestionTypeTab";
            QuestionTypeTab.SelectedIndex = 3;
            QuestionTypeTab.Size = new Size(575, 176);
            QuestionTypeTab.SizeMode = TabSizeMode.Fixed;
            QuestionTypeTab.TabIndex = 26;
            // 
            // MultiChoicePage
            // 
            MultiChoicePage.BackColor = Color.FromArgb(255, 210, 150);
            MultiChoicePage.Controls.Add(MultiChoicePanel);
            MultiChoicePage.Location = new Point(4, 5);
            MultiChoicePage.Name = "MultiChoicePage";
            MultiChoicePage.Padding = new Padding(3);
            MultiChoicePage.Size = new Size(567, 167);
            MultiChoicePage.TabIndex = 0;
            MultiChoicePage.Text = "Multi choice";
            // 
            // MultiChoicePanel
            // 
            MultiChoicePanel.BackColor = Color.Transparent;
            MultiChoicePanel.Controls.Add(Answer4Label);
            MultiChoicePanel.Controls.Add(Answer3Label);
            MultiChoicePanel.Controls.Add(Answer2Label);
            MultiChoicePanel.Controls.Add(Answer1Label);
            MultiChoicePanel.Controls.Add(AnswerIndicator);
            MultiChoicePanel.Controls.Add(Radio4);
            MultiChoicePanel.Controls.Add(Radio3);
            MultiChoicePanel.Controls.Add(Radio2);
            MultiChoicePanel.Controls.Add(Radio1);
            MultiChoicePanel.Location = new Point(0, 15);
            MultiChoicePanel.Name = "MultiChoicePanel";
            MultiChoicePanel.Size = new Size(605, 120);
            MultiChoicePanel.TabIndex = 18;
            // 
            // Answer4Label
            // 
            Answer4Label.AutoSize = true;
            Answer4Label.Font = new Font("Algerian", 10F);
            Answer4Label.Location = new Point(143, 89);
            Answer4Label.Name = "Answer4Label";
            Answer4Label.Size = new Size(15, 15);
            Answer4Label.TabIndex = 29;
            Answer4Label.Text = "D";
            // 
            // Answer3Label
            // 
            Answer3Label.AutoSize = true;
            Answer3Label.Font = new Font("Algerian", 10F);
            Answer3Label.Location = new Point(143, 60);
            Answer3Label.Name = "Answer3Label";
            Answer3Label.Size = new Size(15, 15);
            Answer3Label.TabIndex = 28;
            Answer3Label.Text = "C";
            // 
            // Answer2Label
            // 
            Answer2Label.AutoSize = true;
            Answer2Label.Font = new Font("Algerian", 10F);
            Answer2Label.Location = new Point(143, 31);
            Answer2Label.Name = "Answer2Label";
            Answer2Label.Size = new Size(16, 15);
            Answer2Label.TabIndex = 27;
            Answer2Label.Text = "B";
            // 
            // Answer1Label
            // 
            Answer1Label.AutoSize = true;
            Answer1Label.Font = new Font("Algerian", 10F);
            Answer1Label.Location = new Point(143, 4);
            Answer1Label.Name = "Answer1Label";
            Answer1Label.Size = new Size(18, 15);
            Answer1Label.TabIndex = 26;
            Answer1Label.Text = "A";
            // 
            // AnswerIndicator
            // 
            AnswerIndicator.AutoSize = true;
            AnswerIndicator.BackColor = Color.Transparent;
            AnswerIndicator.Font = new Font("Algerian", 9F);
            AnswerIndicator.ForeColor = SystemColors.ActiveCaptionText;
            AnswerIndicator.Location = new Point(20, 5);
            AnswerIndicator.Name = "AnswerIndicator";
            AnswerIndicator.Size = new Size(75, 14);
            AnswerIndicator.TabIndex = 25;
            AnswerIndicator.Text = "You choose";
            // 
            // Radio4
            // 
            Radio4.AutoSize = true;
            Radio4.BackColor = Color.FromArgb(255, 210, 150);
            Radio4.FlatStyle = FlatStyle.Flat;
            Radio4.Location = new Point(110, 91);
            Radio4.Name = "Radio4";
            Radio4.Size = new Size(13, 12);
            Radio4.TabIndex = 23;
            Radio4.TabStop = true;
            Radio4.UseVisualStyleBackColor = false;
            Radio4.CheckedChanged += Radio4_CheckedChanged;
            // 
            // Radio3
            // 
            Radio3.AutoSize = true;
            Radio3.BackColor = Color.FromArgb(255, 210, 150);
            Radio3.FlatStyle = FlatStyle.Flat;
            Radio3.Location = new Point(110, 62);
            Radio3.Name = "Radio3";
            Radio3.Size = new Size(13, 12);
            Radio3.TabIndex = 21;
            Radio3.TabStop = true;
            Radio3.UseVisualStyleBackColor = false;
            Radio3.CheckedChanged += Radio3_CheckedChanged;
            // 
            // Radio2
            // 
            Radio2.AutoSize = true;
            Radio2.BackColor = Color.FromArgb(255, 210, 150);
            Radio2.FlatStyle = FlatStyle.Flat;
            Radio2.Location = new Point(110, 33);
            Radio2.Name = "Radio2";
            Radio2.Size = new Size(13, 12);
            Radio2.TabIndex = 19;
            Radio2.TabStop = true;
            Radio2.UseVisualStyleBackColor = false;
            Radio2.CheckedChanged += Radio2_CheckedChanged;
            // 
            // Radio1
            // 
            Radio1.AutoSize = true;
            Radio1.BackColor = Color.FromArgb(255, 210, 150);
            Radio1.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            Radio1.FlatAppearance.BorderSize = 2;
            Radio1.FlatStyle = FlatStyle.Flat;
            Radio1.Location = new Point(111, 5);
            Radio1.Name = "Radio1";
            Radio1.Size = new Size(13, 12);
            Radio1.TabIndex = 17;
            Radio1.TabStop = true;
            Radio1.UseVisualStyleBackColor = false;
            Radio1.CheckedChanged += Radio1_CheckedChanged;
            // 
            // TrueFalsePage
            // 
            TrueFalsePage.BackColor = Color.FromArgb(255, 210, 150);
            TrueFalsePage.Controls.Add(TrueFalseAnswerIndicator);
            TrueFalsePage.Controls.Add(FalseLabel);
            TrueFalsePage.Controls.Add(TrueLabel);
            TrueFalsePage.Controls.Add(FalseRadio);
            TrueFalsePage.Controls.Add(TrueRadio);
            TrueFalsePage.Location = new Point(4, 5);
            TrueFalsePage.Name = "TrueFalsePage";
            TrueFalsePage.Padding = new Padding(3);
            TrueFalsePage.Size = new Size(567, 167);
            TrueFalsePage.TabIndex = 1;
            TrueFalsePage.Text = "True False";
            // 
            // TrueFalseAnswerIndicator
            // 
            TrueFalseAnswerIndicator.AutoSize = true;
            TrueFalseAnswerIndicator.BackColor = Color.Transparent;
            TrueFalseAnswerIndicator.Font = new Font("Algerian", 9F);
            TrueFalseAnswerIndicator.ForeColor = SystemColors.ActiveCaptionText;
            TrueFalseAnswerIndicator.Location = new Point(20, 23);
            TrueFalseAnswerIndicator.Name = "TrueFalseAnswerIndicator";
            TrueFalseAnswerIndicator.Size = new Size(75, 14);
            TrueFalseAnswerIndicator.TabIndex = 33;
            TrueFalseAnswerIndicator.Text = "You choose";
            // 
            // FalseLabel
            // 
            FalseLabel.AutoSize = true;
            FalseLabel.Font = new Font("Algerian", 10F);
            FalseLabel.Location = new Point(141, 53);
            FalseLabel.Name = "FalseLabel";
            FalseLabel.Size = new Size(51, 15);
            FalseLabel.TabIndex = 32;
            FalseLabel.Text = "False";
            // 
            // TrueLabel
            // 
            TrueLabel.AutoSize = true;
            TrueLabel.Font = new Font("Algerian", 10F);
            TrueLabel.Location = new Point(141, 24);
            TrueLabel.Name = "TrueLabel";
            TrueLabel.Size = new Size(42, 15);
            TrueLabel.TabIndex = 31;
            TrueLabel.Text = "TRUE";
            // 
            // FalseRadio
            // 
            FalseRadio.AutoSize = true;
            FalseRadio.BackColor = Color.FromArgb(255, 210, 150);
            FalseRadio.FlatStyle = FlatStyle.Flat;
            FalseRadio.Location = new Point(110, 53);
            FalseRadio.Name = "FalseRadio";
            FalseRadio.Size = new Size(13, 12);
            FalseRadio.TabIndex = 28;
            FalseRadio.UseVisualStyleBackColor = false;
            FalseRadio.CheckedChanged += FalseRadio_CheckedChanged;
            // 
            // TrueRadio
            // 
            TrueRadio.AutoSize = true;
            TrueRadio.BackColor = Color.FromArgb(255, 210, 150);
            TrueRadio.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            TrueRadio.FlatAppearance.BorderSize = 2;
            TrueRadio.FlatStyle = FlatStyle.Flat;
            TrueRadio.Location = new Point(111, 25);
            TrueRadio.Name = "TrueRadio";
            TrueRadio.Size = new Size(13, 12);
            TrueRadio.TabIndex = 26;
            TrueRadio.UseVisualStyleBackColor = false;
            TrueRadio.CheckedChanged += TrueRadio_CheckedChanged;
            // 
            // OpenEndedPage
            // 
            OpenEndedPage.BackColor = Color.Transparent;
            OpenEndedPage.Controls.Add(label2);
            OpenEndedPage.Controls.Add(AnswerInput);
            OpenEndedPage.Location = new Point(4, 5);
            OpenEndedPage.Name = "OpenEndedPage";
            OpenEndedPage.Padding = new Padding(3);
            OpenEndedPage.Size = new Size(567, 167);
            OpenEndedPage.TabIndex = 2;
            OpenEndedPage.Text = "Open ended";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 10F);
            label2.Location = new Point(106, 14);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 5;
            label2.Text = "Type your answer";
            // 
            // AnswerInput
            // 
            AnswerInput.BackColor = Color.FromArgb(255, 210, 150);
            AnswerInput.BorderStyle = BorderStyle.None;
            AnswerInput.Font = new Font("Algerian", 10F);
            AnswerInput.Location = new Point(109, 32);
            AnswerInput.Name = "AnswerInput";
            AnswerInput.Size = new Size(272, 45);
            AnswerInput.TabIndex = 3;
            AnswerInput.Text = "";
            AnswerInput.TextChanged += AnswerInput_TextChanged;
            // 
            // EmptyPage
            // 
            EmptyPage.Location = new Point(4, 5);
            EmptyPage.Name = "EmptyPage";
            EmptyPage.Padding = new Padding(3);
            EmptyPage.Size = new Size(567, 167);
            EmptyPage.TabIndex = 3;
            EmptyPage.Text = "empty";
            EmptyPage.UseVisualStyleBackColor = true;
            // 
            // QuestionListButton
            // 
            QuestionListButton.BackColor = Color.FromArgb(255, 210, 150);
            QuestionListButton.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            QuestionListButton.FlatAppearance.BorderSize = 3;
            QuestionListButton.FlatStyle = FlatStyle.Flat;
            QuestionListButton.Font = new Font("Algerian", 10F);
            QuestionListButton.Location = new Point(611, 20);
            QuestionListButton.Name = "QuestionListButton";
            QuestionListButton.Size = new Size(168, 33);
            QuestionListButton.TabIndex = 27;
            QuestionListButton.Text = "Question list";
            QuestionListButton.UseVisualStyleBackColor = false;
            QuestionListButton.Click += QuestionListButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(128, 64, 0);
            SubmitButton.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            SubmitButton.FlatAppearance.BorderSize = 0;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Algerian", 14F);
            SubmitButton.ForeColor = Color.FromArgb(255, 210, 150);
            SubmitButton.Location = new Point(610, 395);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(165, 33);
            SubmitButton.TabIndex = 28;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // QuestionNumerLabel
            // 
            QuestionNumerLabel.AutoSize = true;
            QuestionNumerLabel.BackColor = Color.Transparent;
            QuestionNumerLabel.Font = new Font("Algerian", 12F);
            QuestionNumerLabel.Location = new Point(540, 75);
            QuestionNumerLabel.Name = "QuestionNumerLabel";
            QuestionNumerLabel.Size = new Size(34, 18);
            QuestionNumerLabel.TabIndex = 29;
            QuestionNumerLabel.Text = "0/0";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.BackColor = Color.Transparent;
            TimeLabel.Font = new Font("Algerian", 12F);
            TimeLabel.ForeColor = Color.Red;
            TimeLabel.Location = new Point(27, 108);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(48, 18);
            TimeLabel.TabIndex = 30;
            TimeLabel.Text = "00:00";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.BackColor = Color.Transparent;
            Time.Font = new Font("Algerian", 12F);
            Time.ForeColor = Color.Red;
            Time.Location = new Point(27, 75);
            Time.Name = "Time";
            Time.Size = new Size(44, 18);
            Time.TabIndex = 31;
            Time.Text = "Time";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            // 
            // QuestionContent
            // 
            QuestionContent.BackColor = Color.FromArgb(255, 210, 150);
            QuestionContent.BorderStyle = BorderStyle.None;
            QuestionContent.Font = new Font("Algerian", 12F);
            QuestionContent.HideSelection = false;
            QuestionContent.Location = new Point(118, 108);
            QuestionContent.Name = "QuestionContent";
            QuestionContent.Size = new Size(453, 84);
            QuestionContent.TabIndex = 32;
            QuestionContent.Text = "";
            // 
            // InGameScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurredBackground;
            Controls.Add(QuestionContent);
            Controls.Add(Time);
            Controls.Add(TimeLabel);
            Controls.Add(QuestionNumerLabel);
            Controls.Add(SubmitButton);
            Controls.Add(QuestionListButton);
            Controls.Add(QuestionTypeTab);
            Controls.Add(ExitButton);
            Controls.Add(PreviousButton);
            Controls.Add(NextButton);
            Controls.Add(QuestionList);
            Controls.Add(NumberIndicator);
            Name = "InGameScene";
            Size = new Size(816, 489);
            Load += InGameScene_Load;
            QuestionTypeTab.ResumeLayout(false);
            MultiChoicePage.ResumeLayout(false);
            MultiChoicePanel.ResumeLayout(false);
            MultiChoicePanel.PerformLayout();
            TrueFalsePage.ResumeLayout(false);
            TrueFalsePage.PerformLayout();
            OpenEndedPage.ResumeLayout(false);
            OpenEndedPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumberIndicator;
        private ListBox QuestionList;
        private Button NextButton;
        private Button PreviousButton;
        public Button ExitButton;
        private Widget.Custom.TransparentTabControl QuestionTypeTab;
        private TabPage MultiChoicePage;
        private Panel MultiChoicePanel;
        private Label AnswerIndicator;
        private RadioButton Radio4;
        private RadioButton Radio3;
        private RadioButton Radio2;
        private RadioButton Radio1;
        private TabPage TrueFalsePage;
        private Label FalseLabel;
        private Label TrueLabel;
        private RadioButton FalseRadio;
        private RadioButton TrueRadio;
        private TabPage OpenEndedPage;
        private Label label2;
        private RichTextBox AnswerInput;
        private TabPage EmptyPage;
        private Label Answer1Label;
        private Label TrueFalseAnswerIndicator;
        private Button QuestionListButton;
        private Label Answer4Label;
        private Label Answer3Label;
        private Label Answer2Label;
        public Button SubmitButton;
        private Label QuestionNumerLabel;
        private Label TimeLabel;
        private Label Time;
        private System.Windows.Forms.Timer gameTimer;
        private RichTextBox QuestionContent;
    }
}
