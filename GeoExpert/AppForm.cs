using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;


namespace GeoExpert
{
    public partial class AppForm : Form
    {
        private readonly Dictionary<string, UserControl> pages = new();


        public AppForm()
        {
            InitializeComponent();
            SetupPage();
        }

        private void SetupPage()
        {
            // Create scene instances
            var menuScene = new MenuScene();
            var playScene = new PlayScene();
            var createScene = new CreateScene();
            var gameManagementScene = new GameManagementScene();
            var questionManagementScene = new QuestionManagementScene();

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
                        gameManagementScene.CurrentGame = createScene.FindGame(gamePanel.Name);
                        gameManagementScene.UpdateWidgetInfo();
                    };
                }
            };

            questionManagementScene.SaveBtn.Click += (s, e) =>
            {
                gameManagementScene.CurrentGame.Questions.Add(questionManagementScene.question);
                gameManagementScene.UpdateWidgetInfo();
                questionManagementScene.ResetQuestionInputs();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

    abstract class Question
    {
        private int id;
        public int Id { get; set; }
        private string type;
        public string Type { get; set; }
        private string content;
        public string Content { get; set; }
        private List<string> answers = new List<string>();
        public List<string> Answers { get; set; }
        private int correctAnswer;
        public int CorrectAnswer { get; set; }

        public abstract bool CheckAnswer();

        public abstract string getAnswer();

    }

    class TFQuestion : Question
    {
        public TFQuestion()
        {
            Type = "True/False";
        }

        public override bool CheckAnswer()
        {
            return true;
        }

        public override string getAnswer()
        {
            return "";
        }
    }

    class MultiChoiceQuestion : Question
    {
        public MultiChoiceQuestion ()
        {
           Type = "Multiple choices";
        }

        public override bool CheckAnswer()
        {
            return true;
        }

        public override string getAnswer()
        {
            return "";
        }
    }

    class OpenEndedQuestion : Question
    {

        public OpenEndedQuestion()
        {
            Type = "Open-ended";
        }
        public override bool CheckAnswer()
        {
            return true;
        }

        public override string getAnswer()
        {
            return "";
        }
    }

    class Game
    {
        private string id;
        public string Id { get; set; }
        private string title;
        public string Title { get; set; }
        private List<Question> questions;
        public List<Question> Questions { get; set; } = new List<Question>();

        private int questionNumber;
        public int QuestionNumber { get; set; }
        private TimeSpan time { get; set; }
        private int score;
        public int Score { get; set; }
        private DateTime createDate;
        public DateTime CreateDate { get; set; }
        private DateTime LastPlayed { get; set; }
        private bool isFinished;
        public bool IsFinished { get; set; }

        public Game() { }
        
        public void AddQuestion()
        {

        }

        public void RemoveQuestion(int index)
        {
            Questions.RemoveAt(index);
        }
        
    
    }
    
}
