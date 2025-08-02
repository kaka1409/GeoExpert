using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExpert.models
{
    class OpenEndedQuestion : Question
    {
        public QuestionType type = QuestionType.OpenEnded;
        public QuestionType Type
        {
            get { return type; }
            set { type = value; }
        }

        private List<string> correctAnswers = new List<string>();
        public List<string> CorrectAnswers
        {
            get { return correctAnswers; }
            set { correctAnswers = value; }
        }

        private string? userAnswer;
        public string? UserAnswer
        {
            get { return userAnswer; }
            set { userAnswer = value; }
        }

        public OpenEndedQuestion() { }
        public override bool IsAnswerCorrect()
        {
            return correctAnswers.Contains(UserAnswer.Trim());
        }

    }
}
