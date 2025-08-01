using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeoExpert.Utils;
using GeoExpert.controllers;
using GeoExpert.models;

namespace GeoExpert.views.create
{
    partial class GameManagementScene : UserControl
    {
        private GameController gameController;
        public GameController GameController
        {
            get { return gameController; }
            set { gameController = value; }
        }
        private QuestionController questionController;
        public QuestionController QuestionController
        {
            get { return questionController; }
            set { questionController = value; }
        }

        public GameManagementScene()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void UpdateWidgetInfo()
        {
            SetGameTitle();
            ListQuestion();
        }

        public void SetGameTitle()
        {
            GameTitle.Text = gameController.CurrentGame.Title + "'s questions";
        }

        public void ListQuestion()
        {
            QuestionList.Items.Clear();

            foreach (dynamic question in gameController.CurrentGame.Questions)
            {
                if (question != null)
                {
                    string questionType = ViewHelper.FormatQuestionType(question.Type);
                    QuestionList.Items.Add($"[{questionType}] {question.Content}");
                }
            }
        }

        private void QuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<object> questions = gameController.CurrentGame.Questions;
            dynamic? selectedQuestion = QuestionList.SelectedIndex != -1 ? questions[QuestionList.SelectedIndex] : null;
            if (selectedQuestion != null)
            {
                this.questionController.SelectedIndex = QuestionList.SelectedIndex;
                this.questionController.SelectedQuestion = selectedQuestion;
            }
        }

        private void DeleteQuestionBtn_Click(object sender, EventArgs e)
        {
            if (QuestionList.SelectedItem != null)
            {
                //MessageBox.Show(QuestionList.SelectedIndex.ToString());
                gameController.CurrentGame.RemoveQuestion(QuestionList.SelectedIndex);
                QuestionList.Items.Remove(QuestionList.SelectedItem);
            }
        }
        
    }
}
