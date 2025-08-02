using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeoExpert.views;
using GeoExpert.models;

namespace GeoExpert.controllers
{
    class GameController
    {

        // Create
        private List<Game> games = new List<Game>();
        public List<Game> Games
        {
            get { return games; }
            set { games = value; }
        }
        private Game currentGame;
        public Game CurrentGame
        {
            get { return currentGame; }
            set { currentGame = value; }
        }

        // Play
        private Game currentPlayGame;
        public Game CurrentPlayGame
        {
            get { return currentPlayGame; }
            set { currentPlayGame = value; }
        }

        private int selectedIndex = 1;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set { selectedIndex = value; }
        }

        private dynamic? currentQuestion;
        public dynamic? CurrentQuestion
        {
            get { return currentQuestion; }
            set { currentQuestion = value; }
        }

        private TimeSpan elapsedTime;
        public TimeSpan ElapsedTime
        {
            get { return elapsedTime; }
            set { elapsedTime = value; }
        }

        private TimeSpan timeTaken;
        public TimeSpan TimeTaken
        {
            get { return timeTaken; }
            set { timeTaken = value; }
        }

        private bool isGameFinished;
        public bool IsGameFinished
        {
            get { return isGameFinished; }
            set { isGameFinished = value; }
        }

        public Game? FindGame(string gameTitle)
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

        public void SetQuestionByIndex(int index, dynamic? question)
        {
            if (question != null) currentGame.Questions[index] = question;
        }

        public object? GetQuestionByIndex(int index)
        {
            return index >= 0 && index < currentPlayGame.Questions.Count ? currentPlayGame.Questions[index] : null;
        }

        public int GetCorrectQuestionsNumber()
        {
            int correctQuestionsNumber = 0;

            foreach(dynamic question in currentPlayGame.Questions)
            {
                if (question.IsAnswerCorrect())
                {
                    correctQuestionsNumber++;
                }
            }

            return correctQuestionsNumber;
        }

        public int GetIncorrectQuestionNumer()
        {
            return currentPlayGame.Questions.Count - GetCorrectQuestionsNumber();
        }

        public void ClearAllUserAnswer()
        {
            foreach(dynamic question in currentPlayGame.Questions)
            {
                question.UserAnswer = null;
            }
        }

    }
}
