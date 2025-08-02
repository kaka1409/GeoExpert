using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

using GeoExpert.models;
using GeoExpert.controllers;
using GeoExpert.views.create;
using GeoExpert.views.play;
using GeoExpert.Views.Play;

namespace GeoExpert.views.main
{
    public partial class MainAppForm : Form
    {
        private readonly Dictionary<string, UserControl> pages = new();

        public MainAppForm()
        {
            InitializeComponent();
            InitializePage();
        }

        private void InitializePage()
        {
            // Controllers instances
            QuestionController questionController = new QuestionController();
            GameController gameController = new GameController();

            // Let scene instances use controllers
            MenuScene menuScene = new MenuScene();

            PlayScene playScene = new PlayScene();
            playScene.GameController = gameController;

            InGameScene inGameScene = new InGameScene();
            inGameScene.GameController = gameController;

            ResultScene resultScene = new ResultScene();
            resultScene.GameController = gameController;

            CreateScene createScene = new CreateScene();
            createScene.GameController = gameController;

            GameManagementScene gameManagementScene = new GameManagementScene();
            gameManagementScene.QuestionController = questionController;
            gameManagementScene.GameController = gameController;

            QuestionManagementScene questionManagementScene = new QuestionManagementScene();
            questionManagementScene.Controller = questionController;

            EditQuestionScene editQuestionScene = new EditQuestionScene();
            editQuestionScene.QuestionController = questionController;


            // Navigation between pages
            menuScene.PlayBtn.Click += (s, e) => 
            { 
                ShowPage("Play");
                playScene.UpdateWidgetInfo();
                foreach (Control gamePanel in playScene.GameList.Controls)
                {
                    gamePanel.Click += (s, e) =>
                    {
                        Game? game = gameController.FindGame(gamePanel.Name);

                        if (game != null)
                        {
                            gameController.CurrentPlayGame = game;
                            if (game.Questions.Count > 0)
                            {
                                inGameScene.UpdateWidgetInfo();
                                ShowPage("InGame");
                            } else
                            {
                                MessageBox.Show("Your game has no questions, please add questions if you want to play");
                            }
                        }
                    };
                }
            };

            menuScene.CreateBtn.Click += (s, e) =>
            {
                ShowPage("Create");
            };

            playScene.ExitBtn.Click += (s, e) =>
            {
                ShowPage("Menu");
            };

            inGameScene.ExitButton.Click += (s, e) =>
            {
                ShowPage("Result");
                resultScene.UpdateWidgetInfo();
            };

            inGameScene.SubmitButton.Click += (s, e) =>
            {
                ShowPage("Result");
                resultScene.UpdateWidgetInfo();
            };

            resultScene.BacktoMenuButton.Click += (s, e) =>
            {
                ShowPage("Menu");
                gameController.ClearAllUserAnswer();
            };

            resultScene.ContinueButton.Click += (s, e) =>
            {
                ShowPage("Play");
                gameController.ClearAllUserAnswer();
            };

            createScene.ExitBtn.Click += (s, e) =>
            {
                ShowPage("Menu");
            };

            // Add game
            createScene.ConfirmGameBtn.Click += (s, e) =>
            {
                foreach (Control gamePanel in createScene.GameListConainer.Controls)
                {
                    gamePanel.Click += (s, e) =>
                    {
                        Game? game = gameController.FindGame(gamePanel.Name);

                        if (game != null)
                        {
                            gameController.CurrentGame = game;
                            ShowPage("GameManage");
                            gameManagementScene.UpdateWidgetInfo();
                        }
                    };
                }
            };

            gameManagementScene.ExitBtn.Click += (s, e) =>
            {
                ShowPage("Create");
            };

            gameManagementScene.AddQuestionBtn.Click += (s, e) =>
            {
                ShowPage("QuestionManage");
            };

            // Go go edit question scene
            gameManagementScene.EditQuestionBtn.Click += (s, e) =>
            {
                dynamic questionToEdit = gameManagementScene.QuestionController.SelectedQuestion;
                if (questionToEdit != null)
                {
                    ShowPage("QuestionEdit");
                    editQuestionScene.UpdateWidgetInfo();
                }
            };

            questionManagementScene.ExitBtn.Click += (s, e) =>
            {
                ShowPage("GameManage");
            };

            // Add question
            questionManagementScene.SaveBtn.Click += (s, e) =>
            {
                QuestionController controller = questionManagementScene.Controller;
                object question = questionManagementScene.Controller.GetQuestion();
                Game currentGame = gameController.CurrentGame;

                if (question != null)
                {
                    currentGame.Questions.Add(question);
                    controller.SetQuestion(null);
                    gameManagementScene.UpdateWidgetInfo();
                }
            };

            editQuestionScene.ExitBtn.Click += (s, e) => 
            { 
                ShowPage("GameManage");
                editQuestionScene.ResetQuestionInputs();
            };

            // Save edit question
            editQuestionScene.SaveBtn.Click += (s, e) =>
            {
                List<object> questionList = gameController.CurrentGame.Questions;
                if (questionList != null && questionList.Count > 0)
                {
                    questionList[questionController.SelectedIndex] = questionController.Question;
                    gameManagementScene.UpdateWidgetInfo();
                }
            };

            // Main
            pages["Menu"] = menuScene;

            // Play
            pages["Play"] = playScene;
            pages["InGame"] = inGameScene;
            pages["Result"] = resultScene;

            // Create
            pages["Create"] = createScene;
            pages["GameManage"] = gameManagementScene;
            pages["QuestionManage"] = questionManagementScene;
            pages["QuestionEdit"] = editQuestionScene;

            foreach (var page in pages.Values)
                Controls.Add(page);
        }

        public void ShowPage(string key)
        {
            foreach (var page in pages)
                page.Value.Visible = page.Key == key;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
    

