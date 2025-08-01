using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GeoExpert.models
{
    abstract class Question
    {
        private int id;
        public int Id { get; set; }

        private string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private List<string> answers = new List<string>();
        public List<string> Answers
        {
            get { return answers; }
            set { answers = value; }
        }
        private int correctAnswer;
        public int CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }

        public abstract bool CheckAnswer();


    }
}
