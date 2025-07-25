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

        public void AddQuestion(Question question)
        {
            this.Questions.Add(question);
        }

        public void RemoveQuestion(int index)
        {
            Questions.RemoveAt(index);
        }


    }
}
