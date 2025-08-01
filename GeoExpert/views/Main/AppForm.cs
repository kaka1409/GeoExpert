using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

using GeoExpert.models;
using GeoExpert.controllers;
using GeoExpert.views.create;
using GeoExpert.views.play;

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
            // Controllers instance
            QuestionController questionController = new QuestionController();
            GameController gameController = new GameController();

            // Scene instances
            MenuScene menuScene = new MenuScene();
            PlayScene playScene = new PlayScene();
            CreateScene createScene = new CreateScene();

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
            };

            menuScene.CreateBtn.Click += (s, e) =>
            {
                ShowPage("Create");
            };

            playScene.ExitBtn.Click += (s, e) =>
            {
                ShowPage("Menu");
            };

            createScene.ExitBtn.Click += (s, e) =>
            {
                ShowPage("Menu");
            };

            gameManagementScene.ExitBtn.Click += (s, e) =>
            {
                ShowPage("Create");
            };

            gameManagementScene.AddQuestionBtn.Click += (s, e) =>
            {
                ShowPage("QuestionManage");
            };

            questionManagementScene.ExitBtn.Click += (s, e) =>
            {
                ShowPage("GameManage");
            };

            editQuestionScene.ExitBtn.Click += (s, e) => 
            { 
                ShowPage("GameManage");
                editQuestionScene.ResetQuestionInputs();
            };

            // Add game
            createScene.ConfirmGameBtn.Click += (s, e) => 
            {
                foreach (Control gamePanel in createScene.GameListConainer.Controls)
                {
                    gamePanel.Click += (s, e) =>
                    {
                        ShowPage("GameManage");
                        Game game = createScene.FindGame(gamePanel.Name);
                        gameController.CurrentGame = game;  
                        gameManagementScene.UpdateWidgetInfo();
                    };
                }
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

            pages["Menu"] = menuScene;
            pages["Play"] = playScene;
            pages["Create"] = createScene;
            pages["GameManage"] = gameManagementScene;
            pages["QuestionManage"] = questionManagementScene;
            pages["QuestionEdit"] = editQuestionScene;

            // Add all pages to the form, but they start hidden
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
    

