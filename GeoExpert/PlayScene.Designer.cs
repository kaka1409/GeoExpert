namespace GeoExpert
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
            label1 = new Label();
            ExitBtn = new Button();
            imageList1 = new ImageList(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 45);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "PLAY";
            label1.Click += label1_Click;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(127, 88);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(568, 335);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // PlayScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurredBackground;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ExitBtn);
            Controls.Add(label1);
            Name = "PlayScene";
            Size = new Size(816, 489);
            Load += PlayScene_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Button ExitBtn;
        private ImageList imageList1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
