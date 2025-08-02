using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeoExpert.controllers;
using GeoExpert.models;
using GeoExpert.Utils;
using GeoExpert.Views.Widget.Custom;

namespace GeoExpert.views.play
{
    partial class PlayScene : UserControl
    {
        private GameController gameController;
        public GameController GameController
        {
            get { return gameController; }
            set { gameController = value; }
        }

        public PlayScene()
        {
            InitializeComponent();
        }

        public void UpdateWidgetInfo()
        {
            ListAllGames();
        }

        public void ListAllGames()
        {
            GameList.Controls.Clear();

            foreach(Game game in gameController.Games)
            {
                // Create new panel
                Panel GamePanel = new RoundedPanel();

                GamePanel.Name = game.Title;
                GamePanel.Width = GameList.Width - 20;
                GamePanel.Height = GameList.Height / 4;
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
                QuestionNumber.Name = "QuestionNumber";
                QuestionNumber.Text = game.GetNumberOfQuestions() + " Questions";
                QuestionNumber.Font = new Font(ExitBtn.Font, FontStyle.Regular);
                QuestionNumber.Location = new Point(10, 40);
                QuestionNumber.AutoSize = true;

                // Game create date
                Label CreateDate = new Label();
                CreateDate.Name = "CreateDate";
                CreateDate.Text = ViewHelper.FormatDate(game.CreateDate);
                CreateDate.Font = new Font(ExitBtn.Font.FontFamily, 10); // Set font size to 16
                CreateDate.Location = new Point(GamePanel.Width - 150, 10);
                CreateDate.AutoSize = true;

                GamePanel.Controls.Add(GameTitle);
                GamePanel.Controls.Add(QuestionNumber);
                GamePanel.Controls.Add(CreateDate);
                GameList.Controls.Add(GamePanel);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {

        }

        private void PlayScene_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
