using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeoExpert
{
    partial class CreateScene : UserControl
    {
        // attribute to store game objects
        private List<Game> games = new List<Game>();

        public CreateScene()
        {
            InitializeComponent();
        }

        private void CreateScene_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {

            // Display game name prompt
            NewGamePopup.Visible = true;
        }

        private void ConfirmGameBtn_Click(object sender, EventArgs e)
        {
            AddNewGame();

            // Hide game name prompt
            NewGamePopup.Visible = false;

            // Hide no game message
            NoGameMessage.Visible = GameListConainer.Controls.Count == 0 ? true : false;
        }

        private void CloseGameTitlePopupBtn_Click(object sender, EventArgs e)
        {
            // Hide game name prompt
            NewGamePopup.Visible = false;
        }

        public string GetGameName()
        {
            return string.IsNullOrEmpty(GameNameInput.Text) ? "Untitled" : GameNameInput.Text;
        }

        public string GetGameDate(DateTime gameCreateDate)
        {
            TimeSpan timePassed = DateTime.Now - gameCreateDate;
            string result;

            if (timePassed.Days >= 365 * 2)
            {
                result = ("Created " + timePassed.Days / 365 + " years ago");
            }
            else if (timePassed.Days < 365 * 2 && timePassed.Days > 365)
            {
                result = ("Created 1 year ago");
            }
            else if (timePassed.Days > 60)
            {
                result = ("Created " + timePassed.Days / 30 + " months ago");
            }
            else if (timePassed.Days < 60 && timePassed.Days > 30)
            {
                result = ("Created 1 month ago");
            }
            else if (timePassed.Days >= 1 && timePassed.Days <= 30)
            {
                result = ("Created " + timePassed.Days + " days ago");
            }
            else if (timePassed.Days == 0 && timePassed.Hours > 0)
            {
                result = ("Created " + timePassed.Hours + " hours ago");
            }
            else if (timePassed.Hours == 0 && timePassed.Minutes > 0)
            {
                result = ("Created " + timePassed.Minutes + " minutes ago");
            }
            else
            {
                result = ("Created Just Now");
            }

            return result;
        }

        public void AddNewGame()
        {
            Game game = new Game();
            game.Title = GetGameName();
            game.CreateDate = DateTime.Now;
            game.QuestionNumber = 0;
            games.Add(game);

            // Create new panel
            Panel GamePanel = new RoundedPanel();

            GamePanel.Name = game.Title;
            GamePanel.Width = GameListConainer.Width - 20;
            GamePanel.Height = GameListConainer.Height / 4;
            GamePanel.BackColor = Color.FromArgb(255, 210, 150);
            GamePanel.Cursor = Cursors.Hand;
            

            // Game title
            Label GameTitle = new Label();
            GameTitle.Text = game.Title;
            GameTitle.Font = new Font(ExitBtn.Font, FontStyle.Bold);
            GameTitle.Location = new Point(10, 15);
            GameTitle.AutoSize = true;

            // Game's question numbers
            Label QuestionNumber = new Label();
            QuestionNumber.Text = game.QuestionNumber + " Questions";
            QuestionNumber.Font = new Font(ExitBtn.Font, FontStyle.Regular);
            QuestionNumber.Location = new Point(10, 40);
            QuestionNumber.AutoSize = true;

            // Game create date
            Label CreateDate = new Label();
            CreateDate.Text = GetGameDate(game.CreateDate);
            CreateDate.Font = new Font(ExitBtn.Font.FontFamily, 10); // Set font size to 16
            CreateDate.Location = new Point(GamePanel.Width - 150, 10);
            CreateDate.AutoSize = true;

            GamePanel.Controls.Add(GameTitle);
            GamePanel.Controls.Add(QuestionNumber);
            GamePanel.Controls.Add(CreateDate);
            GameListConainer.Controls.Add(GamePanel);

            // Event
            GamePanel.Click += (s, e) =>
            {
                // update game create date
                //foreach (Game game in games)
                //{
                //    if (games.Count == 0) break;

                //    Control gamePanel = GameListConainer.Controls[0];
                //    if (gamePanel == null) continue;

                //    if (game.Title == gamePanel.Text)
                //    {
                //        gamePanel.Controls["CreateDate"].Text = GetGameDate(game.CreateDate);
                //    }
                //}
            };

            // Reset input
            GameNameInput.Text = "";
        }

        public Game FindGame(string gameTitle)
        {
            foreach (var game in games)
            {
                if (game.Title == gameTitle)
                {
                    return game;
                }
            }

            return null;
        }
    }
}
