using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

using GeoExpert.models;
using GeoExpert.controllers;
using GeoExpert.views.create;
using GeoExpert.views.play;

namespace GeoExpert.views
{
    public partial class MainAppForm : Form
    {
        private readonly Dictionary<string, UserControl> pages = new();

        private GameManagementScene gameManagementScene;
        private QuestionManagementScene questionManagementScene;

        public MainAppForm()
        {
            InitializeComponent();
            SetupPage();
            InitializeControllers();
        }

        private void SetupPage()
        {
            // Create scene instances
            MenuScene menuScene = new MenuScene();
            PlayScene playScene = new PlayScene();
            CreateScene createScene = new CreateScene();
            GameManagementScene gameManagementScene = new GameManagementScene();
            QuestionManagementScene questionManagementScene = new QuestionManagementScene();

            this.gameManagementScene = gameManagementScene;
            this.questionManagementScene = questionManagementScene;

            // Navigation events
            menuScene.PlayBtn.Click += (s, e) => ShowPage("Play");
            menuScene.CreateBtn.Click += (s, e) => ShowPage("Create");
            playScene.ExitBtn.Click += (s, e) => ShowPage("Menu");
            createScene.ExitBtn.Click += (s, e) => ShowPage("Menu");
            gameManagementScene.ExitBtn.Click += (s, e) => ShowPage("Create");
            gameManagementScene.AddQuestionBtn.Click += (s, e) => ShowPage("QuestionManage");
            questionManagementScene.ExitBtn.Click += (s, e) => ShowPage("GameManage");

            // functionality events
            createScene.ConfirmGameBtn.Click += (s, e) => 
            {
                foreach (Control gamePanel in createScene.GameListConainer.Controls)
                {
                    gamePanel.Click += (s, e) =>
                    {
                        ShowPage("GameManage");
                        Game game = createScene.FindGame(gamePanel.Name);
                        gameManagementScene.SetCurrentGame(game);
                        gameManagementScene.UpdateWidgetInfo();
                    };
                }
            };

            questionManagementScene.SaveBtn.Click += (s, e) =>
            {
                Game currentGame = gameManagementScene.GetCurrentGame();
                Question question = questionManagementScene.GetController().GetQuestion();
                QuestionController controller = questionManagementScene.GetController();

                if (question != null)
                {
                    currentGame.Questions.Add(question);
                    controller.SetQuestion(null);
                    gameManagementScene.UpdateWidgetInfo();
                } 

            };

            pages["Menu"] = menuScene;
            pages["Play"] = playScene;
            pages["Create"] = createScene;
            pages["GameManage"] = gameManagementScene;
            pages["QuestionManage"] = questionManagementScene;

            // Add all pages to the form, but they start hidden
            foreach (var page in pages.Values)
                Controls.Add(page);
        }

        public void ShowPage(string key)
        {
            foreach (var page in pages)
                page.Value.Visible = page.Key == key;
        }

        private void InitializeControllers()
        {
            QuestionController questionController = new QuestionController();
            GameController gameController = new GameController();

            QuestionManagementScene questionManagementScene = this.questionManagementScene;
            questionManagementScene.SetController(questionController);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
    

