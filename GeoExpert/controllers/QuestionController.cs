using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GeoExpert.models;

namespace GeoExpert.controllers
{
    public class QuestionController
    {
        // Add question state
        private QuestionType questionType;
        public QuestionType QuestionType
        {
            get { return questionType; }
            set { questionType = value; }
        }
        private string questionContent;
        public string QuestionContent
        {
            get { return questionContent; }
            set { questionContent = value; }
        }
        private int correctAnswer = -1;
        public int CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }
        private List<string> answers = new List<string>();
        private object question;
        public object Question
        {
            get { return question; }
            set { question = value; }
        }

        // Edit question state
        private int selectedIndex;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set { selectedIndex = value; }
        }

        private object selectedQuestion;
        public object SelectedQuestion
        {
            get { return selectedQuestion; }
            set { selectedQuestion = value; }
        }

        public void SetQuestion(object question)
        {
            this.question = question;
        }

        public object GetQuestion()
        {
            return this.question;
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
