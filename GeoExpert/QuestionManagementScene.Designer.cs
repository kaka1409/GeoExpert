namespace GeoExpert
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
            richTextBox1 = new RichTextBox();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            textBox3 = new TextBox();
            radioButton3 = new RadioButton();
            textBox4 = new TextBox();
            radioButton4 = new RadioButton();
            label2 = new Label();
            button1 = new Button();
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
            QuestionTypeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            QuestionTypeCB.FormattingEnabled = true;
            QuestionTypeCB.Location = new Point(239, 67);
            QuestionTypeCB.Name = "QuestionTypeCB";
            QuestionTypeCB.Size = new Size(121, 23);
            QuestionTypeCB.TabIndex = 5;
            QuestionTypeCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(111, 70);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 6;
            label1.Text = "Choose question type";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(111, 96);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(585, 120);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(111, 250);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(553, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 275);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(553, 23);
            textBox2.TabIndex = 11;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(111, 279);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 304);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(553, 23);
            textBox3.TabIndex = 13;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(111, 308);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(143, 333);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(553, 23);
            textBox4.TabIndex = 15;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(111, 337);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(14, 13);
            radioButton4.TabIndex = 14;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(4, 246);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 16;
            label2.Text = "Correct answer ✔️";
            // 
            // button1
            // 
            button1.Location = new Point(111, 387);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Save ";
            button1.UseVisualStyleBackColor = true;
            // 
            // QuestionManagementScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurredBackground;
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(radioButton4);
            Controls.Add(textBox3);
            Controls.Add(radioButton3);
            Controls.Add(textBox2);
            Controls.Add(radioButton2);
            Controls.Add(textBox1);
            Controls.Add(radioButton1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(QuestionTypeCB);
            Controls.Add(ExitBtn);
            Name = "QuestionManagementScene";
            Size = new Size(816, 489);
            Load += QuestionManagementScene_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button ExitBtn;
        private ComboBox QuestionTypeCB;
        private Label label1;
        private RichTextBox richTextBox1;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton2;
        private TextBox textBox3;
        private RadioButton radioButton3;
        private TextBox textBox4;
        private RadioButton radioButton4;
        private Label label2;
        private Button button1;
    }
}
