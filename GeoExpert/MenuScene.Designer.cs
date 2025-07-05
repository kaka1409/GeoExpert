namespace GeoExpert
{
    partial class MenuScene
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
            titleLabel = new Label();
            CreateBtn = new Button();
            PlayBtn = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Curlz MT", 70F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(136, 44);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(545, 125);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "GEOEXPERT";
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.FromArgb(255, 210, 150);
            CreateBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            CreateBtn.FlatAppearance.BorderSize = 3;
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("Algerian", 15F);
            CreateBtn.Location = new Point(323, 358);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(176, 46);
            CreateBtn.TabIndex = 7;
            CreateBtn.Text = "Create game";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // PlayBtn
            // 
            PlayBtn.BackColor = Color.FromArgb(255, 210, 150);
            PlayBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            PlayBtn.FlatAppearance.BorderSize = 3;
            PlayBtn.FlatStyle = FlatStyle.Flat;
            PlayBtn.Font = new Font("Algerian", 15F);
            PlayBtn.Location = new Point(323, 285);
            PlayBtn.Name = "PlayBtn";
            PlayBtn.Size = new Size(176, 46);
            PlayBtn.TabIndex = 6;
            PlayBtn.Text = "Play game";
            PlayBtn.UseVisualStyleBackColor = false;
            PlayBtn.Click += PlayBtn_Click;
            // 
            // MenuScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._71IDn3yU0mL__UF894_1000_QL80_;
            Controls.Add(titleLabel);
            Controls.Add(CreateBtn);
            Controls.Add(PlayBtn);
            Name = "MenuScene";
            Size = new Size(816, 489);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        public Button CreateBtn;
        public Button PlayBtn;
    }
}
