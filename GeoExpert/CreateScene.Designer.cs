namespace GeoExpert
{
    partial class CreateScene
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
            NewGameBtn = new Button();
            GameListConainer = new FlowLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            NoGameMessage = new Label();
            NewGamePopup = new Panel();
            CloseGameTitlePopupBtn = new Button();
            label1 = new Label();
            GameNameInput = new TextBox();
            ConfirmGameBtn = new Button();
            NewGamePopup.SuspendLayout();
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
            ExitBtn.TabIndex = 2;
            ExitBtn.Text = "< Back";
            ExitBtn.UseVisualStyleBackColor = false;
            // 
            // NewGameBtn
            // 
            NewGameBtn.BackColor = Color.FromArgb(128, 64, 0);
            NewGameBtn.Cursor = Cursors.Hand;
            NewGameBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            NewGameBtn.FlatAppearance.BorderSize = 0;
            NewGameBtn.FlatStyle = FlatStyle.Flat;
            NewGameBtn.Font = new Font("Algerian", 10F);
            NewGameBtn.ForeColor = Color.FromArgb(255, 210, 150);
            NewGameBtn.Location = new Point(612, 72);
            NewGameBtn.Name = "NewGameBtn";
            NewGameBtn.Size = new Size(107, 41);
            NewGameBtn.TabIndex = 4;
            NewGameBtn.Text = "+ New game";
            NewGameBtn.UseVisualStyleBackColor = false;
            NewGameBtn.Click += NewGameBtn_Click;
            // 
            // GameListConainer
            // 
            GameListConainer.AutoScroll = true;
            GameListConainer.BackColor = Color.Transparent;
            GameListConainer.FlowDirection = FlowDirection.TopDown;
            GameListConainer.Location = new Point(93, 128);
            GameListConainer.Name = "GameListConainer";
            GameListConainer.Size = new Size(639, 312);
            GameListConainer.TabIndex = 5;
            GameListConainer.WrapContents = false;
            GameListConainer.Paint += flowLayoutPanel2_Paint_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Algerian", 20F);
            label2.Location = new Point(93, 80);
            label2.Name = "label2";
            label2.Size = new Size(177, 30);
            label2.TabIndex = 6;
            label2.Text = "Your games";
            // 
            // NoGameMessage
            // 
            NoGameMessage.AutoSize = true;
            NoGameMessage.BackColor = Color.Transparent;
            NoGameMessage.Font = new Font("Algerian", 16F, FontStyle.Bold);
            NoGameMessage.ForeColor = Color.Red;
            NoGameMessage.Location = new Point(100, 130);
            NoGameMessage.Name = "NoGameMessage";
            NoGameMessage.Size = new Size(627, 25);
            NoGameMessage.TabIndex = 0;
            NoGameMessage.Text = "You currently have no games, Create new game?";
            // 
            // NewGamePopup
            // 
            NewGamePopup.BackColor = Color.FromArgb(255, 210, 150);
            NewGamePopup.BorderStyle = BorderStyle.FixedSingle;
            NewGamePopup.Controls.Add(CloseGameTitlePopupBtn);
            NewGamePopup.Controls.Add(label1);
            NewGamePopup.Controls.Add(GameNameInput);
            NewGamePopup.Controls.Add(ConfirmGameBtn);
            NewGamePopup.Location = new Point(303, 160);
            NewGamePopup.Name = "NewGamePopup";
            NewGamePopup.Size = new Size(238, 132);
            NewGamePopup.TabIndex = 7;
            NewGamePopup.Visible = false;
            // 
            // CloseGameTitlePopupBtn
            // 
            CloseGameTitlePopupBtn.BackColor = Color.FromArgb(255, 210, 150);
            CloseGameTitlePopupBtn.Cursor = Cursors.Hand;
            CloseGameTitlePopupBtn.FlatAppearance.BorderSize = 0;
            CloseGameTitlePopupBtn.FlatStyle = FlatStyle.Flat;
            CloseGameTitlePopupBtn.Font = new Font("Algerian", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseGameTitlePopupBtn.Location = new Point(207, 3);
            CloseGameTitlePopupBtn.Name = "CloseGameTitlePopupBtn";
            CloseGameTitlePopupBtn.Size = new Size(28, 28);
            CloseGameTitlePopupBtn.TabIndex = 3;
            CloseGameTitlePopupBtn.Text = "X";
            CloseGameTitlePopupBtn.UseVisualStyleBackColor = false;
            CloseGameTitlePopupBtn.Click += CloseGameTitlePopupBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 12F);
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 2;
            label1.Text = "Enter game title";
            // 
            // GameNameInput
            // 
            GameNameInput.BackColor = Color.FromArgb(255, 210, 150);
            GameNameInput.BorderStyle = BorderStyle.FixedSingle;
            GameNameInput.Cursor = Cursors.Hand;
            GameNameInput.Font = new Font("Algerian", 9F);
            GameNameInput.Location = new Point(14, 56);
            GameNameInput.Name = "GameNameInput";
            GameNameInput.Size = new Size(212, 23);
            GameNameInput.TabIndex = 1;
            // 
            // ConfirmGameBtn
            // 
            ConfirmGameBtn.BackColor = Color.FromArgb(128, 64, 0);
            ConfirmGameBtn.Cursor = Cursors.Hand;
            ConfirmGameBtn.FlatAppearance.BorderSize = 0;
            ConfirmGameBtn.FlatStyle = FlatStyle.Flat;
            ConfirmGameBtn.Font = new Font("Algerian", 10F);
            ConfirmGameBtn.ForeColor = Color.FromArgb(255, 210, 150);
            ConfirmGameBtn.Location = new Point(87, 91);
            ConfirmGameBtn.Name = "ConfirmGameBtn";
            ConfirmGameBtn.Size = new Size(75, 30);
            ConfirmGameBtn.TabIndex = 0;
            ConfirmGameBtn.Text = "Done";
            ConfirmGameBtn.UseVisualStyleBackColor = false;
            ConfirmGameBtn.Click += ConfirmGameBtn_Click;
            // 
            // CreateScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurredBackground;
            Controls.Add(NewGamePopup);
            Controls.Add(NoGameMessage);
            Controls.Add(label2);
            Controls.Add(GameListConainer);
            Controls.Add(NewGameBtn);
            Controls.Add(ExitBtn);
            Name = "CreateScene";
            Size = new Size(816, 489);
            Load += CreateScene_Load;
            NewGamePopup.ResumeLayout(false);
            NewGamePopup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button ExitBtn;
        public Button NewGameBtn;
        public FlowLayoutPanel GameListConainer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        public Label NoGameMessage;
        public Button ConfirmGameBtn;
        private Button CloseGameTitlePopupBtn;
        private Label label1;
        private TextBox GameNameInput;
        public Panel NewGamePopup;
    }
}
