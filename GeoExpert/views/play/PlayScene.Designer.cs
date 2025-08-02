namespace GeoExpert.views.play
{
    partial class PlayScene
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
            ExitBtn = new Button();
            imageList1 = new ImageList(components);
            GameList = new FlowLayoutPanel();
            label2 = new Label();
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
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "< Back";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += exitBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // GameList
            // 
            GameList.BackColor = Color.Transparent;
            GameList.Location = new Point(93, 128);
            GameList.Name = "GameList";
            GameList.Size = new Size(639, 312);
            GameList.TabIndex = 2;
            GameList.Paint += flowLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Algerian", 20F);
            label2.Location = new Point(93, 80);
            label2.Name = "label2";
            label2.Size = new Size(177, 30);
            label2.TabIndex = 7;
            label2.Text = "Your games";
            // 
            // PlayScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurredBackground;
            Controls.Add(label2);
            Controls.Add(GameList);
            Controls.Add(ExitBtn);
            Name = "PlayScene";
            Size = new Size(816, 489);
            Load += PlayScene_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button ExitBtn;
        private ImageList imageList1;
        public FlowLayoutPanel GameList;
        private Label label2;
    }
}
