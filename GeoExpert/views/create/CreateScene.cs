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

using GeoExpert.Utils;
using GeoExpert.models;
using GeoExpert.controllers;
using GeoExpert.Views.Widget.Custom;

namespace GeoExpert.views.create;

partial class CreateScene : UserControl
{
    private GameController gameController;
    public GameController GameController
    {
        get { return gameController; }
        set { gameController = value; }
    }

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
        return string.IsNullOrEmpty(GameNameInput.Text) ? "Untitled" : GameNameInput.Text.Trim();
    }

    public void AddNewGame()
    {
        Game game = new Game();
        game.Title = GetGameName();
        game.CreateDate = DateTime.Now;

        gameController.Games.Add(game);

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
        GameListConainer.Controls.Add(GamePanel);

        // Reset input
        GameNameInput.Text = "";
    }

    public void UpdateWidgetInfo()
    {
        foreach (Panel gamePanel in GameListConainer.Controls)
        {
            foreach(Control control in gamePanel.Controls)
            {
                if (control.Name == "QuestionNumber" && control is Label)
                {
                    string questionNumer = gameController.CurrentGame.GetNumberOfQuestions().ToString();
                    control.Text = questionNumer + " Questions";
                }

                if (control.Name == "CreateDate")
                {
                    control.Text = ViewHelper.FormatDate(DateTime.Now);
                }
            }

        }
    }
}
