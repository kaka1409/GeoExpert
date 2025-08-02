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
using GeoExpert.Utils;

namespace GeoExpert.Views.Play
{
    partial class ResultScene : UserControl
    {
        private GameController gameController;
        public GameController GameController
        {
            get { return gameController; }
            set { gameController = value; }
        }

        public ResultScene()
        {
            InitializeComponent();
        }

        private void GetTimeTaken()
        {
            TimeSpan timeTaken = gameController.TimeTaken;
            TimeResultLabel.Text = DateAndTimeHelper.TimeSpanToString(timeTaken).Trim();
        }

        private void GetScore()
        {
            ScoreResultLabel.Text = gameController.GetCorrectQuestionsNumber().ToString();
        }

        private void GetCorrectQuestion()
        {
            int correctAnswerNumber = GameController.GetCorrectQuestionsNumber();
            int totalQuestions = gameController.CurrentPlayGame.Questions.Count;

            CorrectAnswersResultLabel.Text = $"{correctAnswerNumber}/{totalQuestions}";
        }

        private void GetIncorrectQuestion()
        {
            int IncorrectQuestionsNumber = GameController.GetIncorrectQuestionNumer();
            int totalQuestions = gameController.CurrentPlayGame.Questions.Count;

            InccorrectAnswerResultLabel.Text = $"{IncorrectQuestionsNumber}/{totalQuestions}";
        }

        public void UpdateWidgetInfo()
        {
            GetTimeTaken();
            GetScore();
            GetCorrectQuestion();
            GetIncorrectQuestion();
        }
    }
}
