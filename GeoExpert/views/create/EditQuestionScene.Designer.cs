using GeoExpert.Views.Widget.Custom;

namespace GeoExpert.views.create
{
    partial class EditQuestionScene
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
            ExitBtn = new Button();
            TrueLabel = new Label();
            TFCorrectIndicatior = new Label();
            FalseRadio = new RadioButton();
            TrueRadio = new RadioButton();
            OpenEndedPage = new TabPage();
            label3 = new Label();
            label2 = new Label();
            RemoveAnswerButton = new Button();
            AnswerInput = new RichTextBox();
            AddAnswerButton = new Button();
            AnswerList = new ListBox();
            CorrectAnswerIndicator = new Label();
            AnswerInput4 = new TextBox();
            Radio4 = new RadioButton();
            AnswerInput3 = new TextBox();
            Radio3 = new RadioButton();
            AnswerInput2 = new TextBox();
            Radio2 = new RadioButton();
            EmptyPage = new TabPage();
            AnswerInput1 = new TextBox();
            TrueFalsePage = new TabPage();
            FalseLabel = new Label();
            Radio1 = new RadioButton();
            MultiChoicePanel = new Panel();
            MultiChoicePage = new TabPage();
            QuestionTypeTab = new TransparentTabControl();
            SaveBtn = new Button();
            QuestionInput = new RichTextBox();
            label1 = new Label();
            QuestionTypeCB = new ComboBox();
            OpenEndedPage.SuspendLayout();
            TrueFalsePage.SuspendLayout();
            MultiChoicePanel.SuspendLayout();
            MultiChoicePage.SuspendLayout();
            QuestionTypeTab.SuspendLayout();
            SuspendLayout();
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
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "< Back";
            ExitBtn.UseVisualStyleBackColor = false;
            // 
            // TrueLabel
            // 
            TrueLabel.AutoSize = true;
            TrueLabel.Font = new Font("Algerian", 10F);
            TrueLabel.Location = new Point(142, 22);
            TrueLabel.Name = "TrueLabel";
            TrueLabel.Size = new Size(42, 15);
            TrueLabel.TabIndex = 31;
            TrueLabel.Text = "TRUE";
            // 
            // TFCorrectIndicatior
            // 
            TFCorrectIndicatior.AutoSize = true;
            TFCorrectIndicatior.BackColor = Color.Transparent;
            TFCorrectIndicatior.Font = new Font("Algerian", 7F);
            TFCorrectIndicatior.ForeColor = Color.Green;
            TFCorrectIndicatior.Location = new Point(2, 22);
            TFCorrectIndicatior.Name = "TFCorrectIndicatior";
            TFCorrectIndicatior.Size = new Size(103, 11);
            TFCorrectIndicatior.TabIndex = 30;
            TFCorrectIndicatior.Text = "Correct answer ✔️";
            // 
            // FalseRadio
            // 
            FalseRadio.AutoSize = true;
            FalseRadio.BackColor = Color.FromArgb(255, 210, 150);
            FalseRadio.FlatStyle = FlatStyle.Flat;
            FalseRadio.Location = new Point(111, 51);
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
            TrueRadio.Location = new Point(112, 23);
            TrueRadio.Name = "TrueRadio";
            TrueRadio.Size = new Size(13, 12);
            TrueRadio.TabIndex = 26;
            TrueRadio.UseVisualStyleBackColor = false;
            TrueRadio.CheckedChanged += TrueRadio_CheckedChanged;
            // 
            // OpenEndedPage
            // 
            OpenEndedPage.BackColor = Color.Transparent;
            OpenEndedPage.Controls.Add(label3);
            OpenEndedPage.Controls.Add(label2);
            OpenEndedPage.Controls.Add(RemoveAnswerButton);
            OpenEndedPage.Controls.Add(AnswerInput);
            OpenEndedPage.Controls.Add(AddAnswerButton);
            OpenEndedPage.Controls.Add(AnswerList);
            OpenEndedPage.Location = new Point(4, 24);
            OpenEndedPage.Name = "OpenEndedPage";
            OpenEndedPage.Padding = new Padding(3);
            OpenEndedPage.Size = new Size(700, 148);
            OpenEndedPage.TabIndex = 2;
            OpenEndedPage.Text = "Open ended";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Algerian", 10F);
            label3.Location = new Point(106, 6);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 6;
            label3.Text = "Answer list";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Algerian", 10F);
            label2.Location = new Point(424, 6);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 5;
            label2.Text = "Type your answer";
            // 
            // RemoveAnswerButton
            // 
            RemoveAnswerButton.BackColor = Color.FromArgb(255, 210, 150);
            RemoveAnswerButton.Cursor = Cursors.Hand;
            RemoveAnswerButton.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            RemoveAnswerButton.FlatAppearance.BorderSize = 3;
            RemoveAnswerButton.FlatStyle = FlatStyle.Flat;
            RemoveAnswerButton.Font = new Font("Algerian", 9.5F);
            RemoveAnswerButton.ForeColor = Color.FromArgb(0, 0, 0, 0);
            RemoveAnswerButton.Location = new Point(567, 93);
            RemoveAnswerButton.Name = "RemoveAnswerButton";
            RemoveAnswerButton.Size = new Size(128, 31);
            RemoveAnswerButton.TabIndex = 4;
            RemoveAnswerButton.Text = "Remove answer";
            RemoveAnswerButton.UseVisualStyleBackColor = false;
            RemoveAnswerButton.Click += RemoveAnswerButton_Click;
            // 
            // AnswerInput
            // 
            AnswerInput.BackColor = Color.FromArgb(255, 210, 150);
            AnswerInput.BorderStyle = BorderStyle.None;
            AnswerInput.Font = new Font("Algerian", 10F);
            AnswerInput.Location = new Point(421, 30);
            AnswerInput.Name = "AnswerInput";
            AnswerInput.Size = new Size(272, 45);
            AnswerInput.TabIndex = 3;
            AnswerInput.Text = "";
            // 
            // AddAnswerButton
            // 
            AddAnswerButton.BackColor = Color.FromArgb(255, 210, 150);
            AddAnswerButton.Cursor = Cursors.Hand;
            AddAnswerButton.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            AddAnswerButton.FlatAppearance.BorderSize = 3;
            AddAnswerButton.FlatStyle = FlatStyle.Flat;
            AddAnswerButton.Font = new Font("Algerian", 10F);
            AddAnswerButton.ForeColor = Color.FromArgb(0, 0, 0, 0);
            AddAnswerButton.Location = new Point(421, 93);
            AddAnswerButton.Name = "AddAnswerButton";
            AddAnswerButton.Size = new Size(118, 31);
            AddAnswerButton.TabIndex = 2;
            AddAnswerButton.Text = "Add answer";
            AddAnswerButton.UseVisualStyleBackColor = false;
            AddAnswerButton.Click += AddAnswerButton_Click;
            // 
            // AnswerList
            // 
            AnswerList.BackColor = Color.FromArgb(255, 210, 150);
            AnswerList.BorderStyle = BorderStyle.None;
            AnswerList.Font = new Font("Algerian", 10F);
            AnswerList.FormattingEnabled = true;
            AnswerList.ItemHeight = 15;
            AnswerList.Location = new Point(107, 30);
            AnswerList.Name = "AnswerList";
            AnswerList.Size = new Size(285, 90);
            AnswerList.TabIndex = 0;
            // 
            // CorrectAnswerIndicator
            // 
            CorrectAnswerIndicator.AutoSize = true;
            CorrectAnswerIndicator.BackColor = Color.Transparent;
            CorrectAnswerIndicator.Font = new Font("Algerian", 7F);
            CorrectAnswerIndicator.ForeColor = Color.Green;
            CorrectAnswerIndicator.Location = new Point(1, 4);
            CorrectAnswerIndicator.Name = "CorrectAnswerIndicator";
            CorrectAnswerIndicator.Size = new Size(103, 11);
            CorrectAnswerIndicator.TabIndex = 25;
            CorrectAnswerIndicator.Text = "Correct answer ✔️";
            // 
            // AnswerInput4
            // 
            AnswerInput4.BackColor = Color.FromArgb(255, 210, 150);
            AnswerInput4.BorderStyle = BorderStyle.FixedSingle;
            AnswerInput4.Font = new Font("Algerian", 9F);
            AnswerInput4.Location = new Point(142, 87);
            AnswerInput4.Name = "AnswerInput4";
            AnswerInput4.Size = new Size(553, 23);
            AnswerInput4.TabIndex = 24;
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
            // AnswerInput3
            // 
            AnswerInput3.BackColor = Color.FromArgb(255, 210, 150);
            AnswerInput3.BorderStyle = BorderStyle.FixedSingle;
            AnswerInput3.Font = new Font("Algerian", 9F);
            AnswerInput3.Location = new Point(142, 58);
            AnswerInput3.Name = "AnswerInput3";
            AnswerInput3.Size = new Size(553, 23);
            AnswerInput3.TabIndex = 22;
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
            // AnswerInput2
            // 
            AnswerInput2.BackColor = Color.FromArgb(255, 210, 150);
            AnswerInput2.BorderStyle = BorderStyle.FixedSingle;
            AnswerInput2.Font = new Font("Algerian", 9F);
            AnswerInput2.Location = new Point(142, 29);
            AnswerInput2.Name = "AnswerInput2";
            AnswerInput2.Size = new Size(553, 23);
            AnswerInput2.TabIndex = 20;
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
            // EmptyPage
            // 
            EmptyPage.Location = new Point(4, 24);
            EmptyPage.Name = "EmptyPage";
            EmptyPage.Padding = new Padding(3);
            EmptyPage.Size = new Size(700, 148);
            EmptyPage.TabIndex = 3;
            EmptyPage.Text = "empty";
            EmptyPage.UseVisualStyleBackColor = true;
            // 
            // AnswerInput1
            // 
            AnswerInput1.BackColor = Color.FromArgb(255, 210, 150);
            AnswerInput1.BorderStyle = BorderStyle.FixedSingle;
            AnswerInput1.Font = new Font("Algerian", 9F);
            AnswerInput1.Location = new Point(142, 0);
            AnswerInput1.Name = "AnswerInput1";
            AnswerInput1.Size = new Size(553, 23);
            AnswerInput1.TabIndex = 18;
            // 
            // TrueFalsePage
            // 
            TrueFalsePage.BackColor = Color.FromArgb(255, 210, 150);
            TrueFalsePage.Controls.Add(FalseLabel);
            TrueFalsePage.Controls.Add(TrueLabel);
            TrueFalsePage.Controls.Add(TFCorrectIndicatior);
            TrueFalsePage.Controls.Add(FalseRadio);
            TrueFalsePage.Controls.Add(TrueRadio);
            TrueFalsePage.Location = new Point(4, 24);
            TrueFalsePage.Name = "TrueFalsePage";
            TrueFalsePage.Padding = new Padding(3);
            TrueFalsePage.Size = new Size(700, 148);
            TrueFalsePage.TabIndex = 1;
            TrueFalsePage.Text = "True False";
            // 
            // FalseLabel
            // 
            FalseLabel.AutoSize = true;
            FalseLabel.Font = new Font("Algerian", 10F);
            FalseLabel.Location = new Point(142, 51);
            FalseLabel.Name = "FalseLabel";
            FalseLabel.Size = new Size(51, 15);
            FalseLabel.TabIndex = 32;
            FalseLabel.Text = "False";
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
            // MultiChoicePanel
            // 
            MultiChoicePanel.BackColor = Color.Transparent;
            MultiChoicePanel.Controls.Add(CorrectAnswerIndicator);
            MultiChoicePanel.Controls.Add(AnswerInput4);
            MultiChoicePanel.Controls.Add(Radio4);
            MultiChoicePanel.Controls.Add(AnswerInput3);
            MultiChoicePanel.Controls.Add(Radio3);
            MultiChoicePanel.Controls.Add(AnswerInput2);
            MultiChoicePanel.Controls.Add(Radio2);
            MultiChoicePanel.Controls.Add(AnswerInput1);
            MultiChoicePanel.Controls.Add(Radio1);
            MultiChoicePanel.Location = new Point(0, 15);
            MultiChoicePanel.Name = "MultiChoicePanel";
            MultiChoicePanel.Size = new Size(707, 120);
            MultiChoicePanel.TabIndex = 18;
            // 
            // MultiChoicePage
            // 
            MultiChoicePage.BackColor = Color.FromArgb(255, 210, 150);
            MultiChoicePage.Controls.Add(MultiChoicePanel);
            MultiChoicePage.Location = new Point(4, 24);
            MultiChoicePage.Name = "MultiChoicePage";
            MultiChoicePage.Padding = new Padding(3);
            MultiChoicePage.Size = new Size(700, 148);
            MultiChoicePage.TabIndex = 0;
            MultiChoicePage.Text = "Multi choice";
            // 
            // QuestionTypeTab
            // 
            QuestionTypeTab.Controls.Add(MultiChoicePage);
            QuestionTypeTab.Controls.Add(TrueFalsePage);
            QuestionTypeTab.Controls.Add(OpenEndedPage);
            QuestionTypeTab.Controls.Add(EmptyPage);
            QuestionTypeTab.ItemSize = new Size(0, 1);
            QuestionTypeTab.Location = new Point(0, 215);
            QuestionTypeTab.Name = "QuestionTypeTab";
            QuestionTypeTab.SelectedIndex = 3;
            QuestionTypeTab.Size = new Size(708, 176);
            QuestionTypeTab.SizeMode = TabSizeMode.Fixed;
            QuestionTypeTab.TabIndex = 25;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(128, 64, 0);
            SaveBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            SaveBtn.FlatAppearance.BorderSize = 3;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Algerian", 10F);
            SaveBtn.ForeColor = Color.FromArgb(255, 210, 150);
            SaveBtn.Location = new Point(110, 401);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 32);
            SaveBtn.TabIndex = 24;
            SaveBtn.Text = "Save ";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // QuestionInput
            // 
            QuestionInput.BackColor = Color.FromArgb(255, 210, 150);
            QuestionInput.BorderStyle = BorderStyle.None;
            QuestionInput.Font = new Font("Algerian", 10F);
            QuestionInput.Location = new Point(111, 96);
            QuestionInput.Name = "QuestionInput";
            QuestionInput.Size = new Size(585, 120);
            QuestionInput.TabIndex = 23;
            QuestionInput.Text = "";
            QuestionInput.TextChanged += QuestionInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Algerian", 10F);
            label1.Location = new Point(111, 70);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 22;
            label1.Text = "Question type";
            // 
            // QuestionTypeCB
            // 
            QuestionTypeCB.AllowDrop = true;
            QuestionTypeCB.BackColor = Color.FromArgb(255, 210, 150);
            QuestionTypeCB.Enabled = false;
            QuestionTypeCB.FlatStyle = FlatStyle.Flat;
            QuestionTypeCB.Font = new Font("Algerian", 10F);
            QuestionTypeCB.ForeColor = SystemColors.ActiveCaptionText;
            QuestionTypeCB.FormattingEnabled = true;
            QuestionTypeCB.Location = new Point(226, 67);
            QuestionTypeCB.Name = "QuestionTypeCB";
            QuestionTypeCB.Size = new Size(170, 23);
            QuestionTypeCB.TabIndex = 21;
            QuestionTypeCB.SelectedIndexChanged += QuestionTypeCB_SelectedIndexChanged;
            // 
            // EditQuestionScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurredBackground;
            Controls.Add(QuestionTypeTab);
            Controls.Add(SaveBtn);
            Controls.Add(QuestionInput);
            Controls.Add(label1);
            Controls.Add(QuestionTypeCB);
            Controls.Add(ExitBtn);
            Name = "EditQuestionScene";
            Size = new Size(816, 489);
            Load += EditQuestionScene_Load;
            OpenEndedPage.ResumeLayout(false);
            OpenEndedPage.PerformLayout();
            TrueFalsePage.ResumeLayout(false);
            TrueFalsePage.PerformLayout();
            MultiChoicePanel.ResumeLayout(false);
            MultiChoicePanel.PerformLayout();
            MultiChoicePage.ResumeLayout(false);
            QuestionTypeTab.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button ExitBtn;
        private Label TrueLabel;
        private Label TFCorrectIndicatior;
        private RadioButton FalseRadio;
        private RadioButton TrueRadio;
        private TabPage OpenEndedPage;
        private Label label3;
        private Label label2;
        private Button RemoveAnswerButton;
        private RichTextBox AnswerInput;
        private Button AddAnswerButton;
        private ListBox AnswerList;
        private Label CorrectAnswerIndicator;
        private TextBox AnswerInput4;
        private RadioButton Radio4;
        private TextBox AnswerInput3;
        private RadioButton Radio3;
        private TextBox AnswerInput2;
        private RadioButton Radio2;
        private TabPage EmptyPage;
        private TextBox AnswerInput1;
        private TabPage TrueFalsePage;
        private Label FalseLabel;
        private RadioButton Radio1;
        private Panel MultiChoicePanel;
        private TabPage MultiChoicePage;
        private TransparentTabControl QuestionTypeTab;
        public Button SaveBtn;
        private RichTextBox QuestionInput;
        private Label label1;
        private ComboBox QuestionTypeCB;
    }
}
