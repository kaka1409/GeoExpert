using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GeoExpert
{
    public partial class AppForm : Form
    {
        private readonly Dictionary<string, UserControl> Pages = new();


        public AppForm()
        {
            InitializeComponent();
            SetupPage();
        }

        private void SetupPage()
        {
            // Create scene instances
            var MenuScene = new MenuScene();
            var PlayScene = new PlayScene();
            var CreateScene = new CreateScene();
            var GameManagementScene = new GameManagementScene();

            // Navigation events
            MenuScene.PlayBtn.Click += (s, e) => ShowPage("Play");
            MenuScene.CreateBtn.Click += (s, e) => ShowPage("Create");
            PlayScene.ExitBtn.Click += (s, e) => ShowPage("Menu");
            CreateScene.ExitBtn.Click += (s, e) => ShowPage("Menu");
            GameManagementScene.ExitBtn.Click += (s, e) => ShowPage("Create");

            // functionality events
            CreateScene.NewGameBtn.Click += (s, e) => 
            {     
                foreach (Control GamePanel in CreateScene.GameListConainer.Controls)
                {
                    GamePanel.Click += (s, e) => ShowPage("GameManage");
                }
            };

            Pages["Menu"] = MenuScene;
            Pages["Play"] = PlayScene;
            Pages["Create"] = CreateScene;
            Pages["GameManage"] = GameManagementScene;

            // Add all pages to the form, but they start hidden
            foreach (var Page in Pages.Values)
                Controls.Add(Page);
        }

        public void ShowPage(string key)
        {
            foreach (var Page in Pages)
                Page.Value.Visible = Page.Key == key;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

    abstract class Question
    {
        private int id { get; set; }
        private string content { get; set; }
        private string[] answers { get; set; }
        private string correctAnswer { get; set; }

        public abstract bool checkAnswer();

        public abstract string getAnswer();

    }

    class TFQuestion : Question
    {
        public override bool checkAnswer()
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
        public override bool checkAnswer()
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
        public override bool checkAnswer()
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
        private string id { get; set; }
        private string title { get; set; } = "Untitled";
        private Question[] questions { get; set; }
        private int questionNumber { get; set; }
        private DateTime time { get; set; }
        private int score { get; set; }
        private DateTime createDate { get; set; }
        private DateTime LastPlayed { get; set; }
        private bool isFinished { get; set; }

        public Game() { }
        

    
    
    }
    
}
