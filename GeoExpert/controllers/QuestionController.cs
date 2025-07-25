using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeoExpert.models;

namespace GeoExpert.controllers
{
    internal class QuestionController
    {
        private int questionType;
        public int QuestionType { get; set; }
        private string questionContent;
        public string QuestionContent { get; set; }
        private int correctAnswer = -1;
        public int CorrectAnswer { get; set; } = -1;
        private List<string> answers = new List<string>();
        private Question question;
        public Question Question { get; set; }

        public void SetQuestion(Question question)
        {
            this.question = question;
        }

        public Question GetQuestion()
        {
            return this.question;
        }

        public MultiChoiceQuestion CreateMutliChoiceQuestion()
        {
            return new MultiChoiceQuestion();
        }

        public TFQuestion CreateNewTFQuestion()
        {
            return new TFQuestion();
        }

        public OpenEndedQuestion CreateOpenEndedQuestion()
        {
            return new OpenEndedQuestion();
        }

        public void AddAnswer(string answer)
        {
            this.answers.Add(answer);
        }

        public List<string> GetAnswers()
        {
            return this.answers;
        }


        public void ClearAllAnswers()
        {
            this.answers = new List<string>();
        }


        public void SaveQuestion()
        {
            
        }
    }
}
