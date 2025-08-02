using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExpert.models
{
    class Game
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        public string Title
        {
            get {  return title; }
            set { title = value; }
        }

        private List<object> questions = new List<object>();
        public List<object> Questions
        {
            get { return questions; }
            set { questions = value; }
        }

        private int questionNumber;
        public int QuestionNumber
        {
            get { return questionNumber; }
            set { questionNumber = value; }
        }
        private TimeSpan time { get; set; }
        private int score;
        public int Score { get; set; }
        private DateTime createDate;
        public DateTime CreateDate
        {
            get { return  createDate; }
            set { createDate = value; }
        }
        private DateTime LastPlayed { get; set; }
        private bool isFinished;
        public bool IsFinished
        {
            get { return isFinished; }
            set { isFinished = value; }
        }

        public Game() { }

        public void AddQuestion(Question question)
        {
            this.Questions.Add(question);
        }

        public void RemoveQuestion(int index)
        {
            Questions.RemoveAt(index);
        }

        public int GetNumberOfQuestions()
        {
            return Questions.Count;
        }
    }
}
