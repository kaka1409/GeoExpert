using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoExpert
{
    public partial class CreateScene : UserControl
    {
        public CreateScene()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CreateScene_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            this.AddNewGame();
            
            // Hide no game message
            NoGameMessage.Visible = GameListConainer.Controls.Count == 0 ? true : false;
        }

        public void AddNewGame()
        {
            Game Game = new Game();

            // Create new panel
            Panel GamePanel = new RoundedPanel();

            GamePanel.Width = GameListConainer.Width - 20;
            GamePanel.Height = GameListConainer.Height / 4;
            GamePanel.BackColor = Color.FromArgb(255, 210, 150);
            GamePanel.Cursor = Cursors.Hand;

            // Game title
            Label GameTitle = new Label();
            GameTitle.Text = "Untitled";
            GameTitle.Font = new Font(ExitBtn.Font, FontStyle.Bold);
            GameTitle.Location = new Point(10, 15);
            GameTitle.AutoSize = true;

            // Game's question numbers
            Label QuestionNumber = new Label();
            QuestionNumber.Text = "0 Questions";
            QuestionNumber.Font = new Font(ExitBtn.Font, FontStyle.Regular);
            QuestionNumber.Location = new Point(10, 40);
            QuestionNumber.AutoSize = true;

            // Game create date
            Label CreateDate = new Label();
            CreateDate.Text = "Created just now";
            CreateDate.Font = new Font(ExitBtn.Font.FontFamily, 10); // Set font size to 16
            CreateDate.Location = new Point(GamePanel.Width - 150, 10);
            CreateDate.AutoSize = true;

            GamePanel.Controls.Add(GameTitle);
            GamePanel.Controls.Add(QuestionNumber);
            GamePanel.Controls.Add(CreateDate);
            this.GameListConainer.Controls.Add(GamePanel);
        }
    }
}
