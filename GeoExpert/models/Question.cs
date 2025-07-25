using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExpert.models
{
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
}
