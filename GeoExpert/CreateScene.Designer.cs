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
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(255, 210, 150);
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
            // CreateScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._71IDn3yU0mL__UF894_1000_QL80_;
            Controls.Add(NoGameMessage);
            Controls.Add(label2);
            Controls.Add(GameListConainer);
            Controls.Add(NewGameBtn);
            Controls.Add(ExitBtn);
            Name = "CreateScene";
            Size = new Size(816, 489);
            Load += CreateScene_Load;
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
    }
}
