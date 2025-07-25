using System.Windows.Forms;

namespace GeoExpert.views.create
{
    partial class QuestionManagementScene
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
            QuestionTypeCB = new ComboBox();
            label1 = new Label();
            QuestionInput = new RichTextBox();
            SaveBtn = new Button();
            MultiChoicePanel = new Panel();
            CorrectAnswerIndicator = new Label();
            AnswerInput4 = new TextBox();
            Radio4 = new RadioButton();
            AnswerInput3 = new TextBox();
            Radio3 = new RadioButton();
            AnswerInput2 = new TextBox();
            Radio2 = new RadioButton();
            AnswerInput1 = new TextBox();
            Radio1 = new RadioButton();
            QuestionTypeTab = new TabControl();
            MultiChoicePage = new TabPage();
            TrueFalsePage = new TabPage();
            OpenEndedPage = new TabPage();
            MultiChoicePanel.SuspendLayout();
            QuestionTypeTab.SuspendLayout();
            MultiChoicePage.SuspendLayout();
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
            // QuestionTypeCB
            // 
            QuestionTypeCB.BackColor = Color.FromArgb(255, 210, 150);
            QuestionTypeCB.FlatStyle = FlatStyle.Flat;
            QuestionTypeCB.Font = new Font("Algerian", 10F);
            QuestionTypeCB.ForeColor = SystemColors.ActiveCaptionText;
            QuestionTypeCB.FormattingEnabled = true;
            QuestionTypeCB.Location = new Point(282, 67);
            QuestionTypeCB.Name = "QuestionTypeCB";
            QuestionTypeCB.Size = new Size(170, 23);
            QuestionTypeCB.TabIndex = 5;
            QuestionTypeCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Algerian", 10F);
            label1.Location = new Point(111, 70);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 6;
            label1.Text = "Choose question type";
            // 
            // QuestionInput
            // 
            QuestionInput.BackColor = Color.FromArgb(255, 210, 150);
            QuestionInput.BorderStyle = BorderStyle.None;
            QuestionInput.Font = new Font("Algerian", 10F);
            QuestionInput.Location = new Point(111, 96);
            QuestionInput.Name = "QuestionInput";
            QuestionInput.Size = new Size(585, 120);
            QuestionInput.TabIndex = 7;
            QuestionInput.Text = "";
            QuestionInput.TextChanged += richTextBox1_TextChanged;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(255, 210, 150);
            SaveBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            SaveBtn.FlatAppearance.BorderSize = 3;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Algerian", 10F);
            SaveBtn.Location = new Point(110, 401);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(75, 32);
            SaveBtn.TabIndex = 17;
            SaveBtn.Text = "Save ";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Clicked;
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
            MultiChoicePanel.Location = new Point(0, 6);
            MultiChoicePanel.Name = "MultiChoicePanel";
            MultiChoicePanel.Size = new Size(707, 120);
            MultiChoicePanel.TabIndex = 18;
            MultiChoicePanel.Paint += MultiChoicePanel_Paint;
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
            AnswerInput4.TextChanged += AnswerInput4_TextChanged;
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
            AnswerInput3.TextChanged += AnswerInput3_TextChanged;
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
            AnswerInput2.TextChanged += AnswerInput2_TextChanged;
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
            // AnswerInput1
            // 
            AnswerInput1.BackColor = Color.FromArgb(255, 210, 150);
            AnswerInput1.BorderStyle = BorderStyle.FixedSingle;
            AnswerInput1.Font = new Font("Algerian", 9F);
            AnswerInput1.Location = new Point(142, 0);
            AnswerInput1.Name = "AnswerInput1";
            AnswerInput1.Size = new Size(553, 23);
            AnswerInput1.TabIndex = 18;
            AnswerInput1.TextChanged += AnswerInput1_TextChanged;
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
            // QuestionTypeTab
            // 
            QuestionTypeTab.Appearance = TabAppearance.Buttons;
            QuestionTypeTab.ItemSize = new Size(0, 1);
            QuestionTypeTab.SizeMode = TabSizeMode.Fixed;
            //QuestionTypeTab.Region = new Region(new RectangleF(
            //    this.tabPage1.Left, this.tabPage1.Top,
            //    this.tabPage1.Width, this.tabPage1.Height
            //));
            QuestionTypeTab.Controls.Add(MultiChoicePage);
            QuestionTypeTab.Controls.Add(TrueFalsePage);
            QuestionTypeTab.Controls.Add(OpenEndedPage);
            QuestionTypeTab.Location = new Point(0, 222);
            QuestionTypeTab.Name = "QuestionTypeTab";
            QuestionTypeTab.SelectedIndex = 0;
            QuestionTypeTab.Size = new Size(751, 169);
            QuestionTypeTab.TabIndex = 19;
            // 
            // MultiChoicePage
            // 
            MultiChoicePage.AccessibleRole = AccessibleRole.PushButton;
            MultiChoicePage.BackColor = Color.FromArgb(255, 210, 150);
            MultiChoicePage.Controls.Add(MultiChoicePanel);
            MultiChoicePage.Location = new Point(4, 24);
            MultiChoicePage.Name = "MultiChoicePage";
            MultiChoicePage.Padding = new Padding(3);
            MultiChoicePage.Size = new Size(743, 141);
            MultiChoicePage.TabIndex = 0;
            MultiChoicePage.Text = "Multi choice";
            // 
            // TrueFalsePage
            // 
            TrueFalsePage.BackColor = Color.FromArgb(255, 210, 150);
            TrueFalsePage.Location = new Point(4, 24);
            TrueFalsePage.Name = "TrueFalsePage";
            TrueFalsePage.Padding = new Padding(3);
            TrueFalsePage.Size = new Size(743, 141);
            TrueFalsePage.TabIndex = 1;
            TrueFalsePage.Text = "True False";
            // 
            // OpenEndedPage
            // 
            OpenEndedPage.BackColor = Color.FromArgb(255, 210, 150);
            OpenEndedPage.Location = new Point(4, 24);
            OpenEndedPage.Name = "OpenEndedPage";
            OpenEndedPage.Padding = new Padding(3);
            OpenEndedPage.Size = new Size(743, 141);
            OpenEndedPage.TabIndex = 2;
            OpenEndedPage.Text = "Open ended";
            // 
            // QuestionManagementScene
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
            Name = "QuestionManagementScene";
            Size = new Size(816, 489);
            Load += QuestionManagementScene_Load;
            MultiChoicePanel.ResumeLayout(false);
            MultiChoicePanel.PerformLayout();
            QuestionTypeTab.ResumeLayout(false);
            MultiChoicePage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button ExitBtn;
        private ComboBox QuestionTypeCB;
        private Label label1;
        private RichTextBox QuestionInput;
        public Button SaveBtn;
        private Panel MultiChoicePanel;
        private Label CorrectAnswerIndicator;
        private TextBox AnswerInput4;
        private RadioButton Radio4;
        private TextBox AnswerInput3;
        private RadioButton Radio3;
        private TextBox AnswerInput2;
        private RadioButton Radio2;
        private TextBox AnswerInput1;
        private RadioButton Radio1;
        private TabControl QuestionTypeTab;
        private TabPage MultiChoicePage;
        private TabPage TrueFalsePage;
        private TabPage OpenEndedPage;
    }
}
