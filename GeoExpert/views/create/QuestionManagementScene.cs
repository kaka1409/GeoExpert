using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using GeoExpert.models;
using GeoExpert.controllers;

namespace GeoExpert.views.create
{
    partial class QuestionManagementScene : UserControl
    {
        private QuestionController controller;
        //public QuestionController Controller { get; set; }

        public QuestionManagementScene()
        {
            InitializeComponent();
        }

        public void SetController(QuestionController controller)
        {
            this.controller = controller;
        }

        public QuestionController GetController()
        {
            return this.controller;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(controller.QuestionType.ToString());

            int questionType = QuestionTypeCB.SelectedIndex;
            QuestionTypeTab.SelectTab(questionType);
            controller.QuestionType = questionType;

            switch (questionType)
            {

                case 0:
                {
                    
                    //MultiChoicePanel.Visible = true;
                    break;
                }

                case 1:
                {
                    //MultiChoicePanel.Visible = false;
                    break;
                }


                case 2:
                {
                    //MultiChoicePanel.Visible = false;
                    break;
                }


                default:
                {
                    //MultiChoicePanel.Visible = true;
                    break;
                }
            }
        }

        private void QuestionManagementScene_Load(object sender, EventArgs e)
        {
            QuestionTypeCB.Items.AddRange(new string[] { "Multiple Choice", "True/False", "Open-ended" });
        }

        private void MultiChoicePanel_Paint(object sender, PaintEventArgs e)
        {
            //MultiChoicePanel.Visible = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.controller.QuestionContent = QuestionInput.Text;
        }

        private void Radio1_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswerIndicator.Top = Radio1.Location.Y;
            this.controller.CorrectAnswer = 0;
        }

        private void Radio2_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswerIndicator.Top = Radio2.Location.Y;
            this.controller.CorrectAnswer = 1;
        }

        private void Radio3_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswerIndicator.Top = Radio3.Location.Y;
            this.controller.CorrectAnswer = 2;
        }

        private void Radio4_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswerIndicator.Top = Radio4.Location.Y;
            this.controller.CorrectAnswer = 3;
        }

        private void AnswerInput1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void AnswerInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnswerInput3_TextChanged(object sender, EventArgs e)
        {
    

        }

        private void AnswerInput4_TextChanged(object sender, EventArgs e)
        {

        }

        public void ResetQuestionInputs()
        {
            controller.ClearAllAnswers();
            controller.CorrectAnswer = -1;
            controller.QuestionContent = "";

            QuestionTypeCB.SelectedIndex = -1;

            // Reset all text input
            AnswerInput1.Clear();
            AnswerInput2.Clear();
            AnswerInput3.Clear();
            AnswerInput4.Clear();
            QuestionInput.Clear();

            Radio1.Checked = false;
            Radio2.Checked = false;
            Radio3.Checked = false;
            Radio4.Checked = false;
        }

        private Boolean IsMultiChoiceQuestionValid()
        {
            if (QuestionTypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a question type");
                return false;
            }

            if (QuestionInput.Text.Trim() == "")
            {
                MessageBox.Show("You can not left the question input empty, please write out the question");
                return false;
            }

            if (controller.CorrectAnswer == -1)
            {
                MessageBox.Show("Please select the correct answer for your question");
                return false;
            }

            string answer1 = AnswerInput1.Text.Trim();
            string answer2 = AnswerInput2.Text.Trim();
            string answer3 = AnswerInput3.Text.Trim();
            string answer4 = AnswerInput4.Text.Trim();

            if (answer1 == "" || answer2 == "" || answer3 == "" || answer4 == "")
            {
                MessageBox.Show("Please don't leave answer input empty");
                return false;
            }

            return true;
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            switch (controller.QuestionType) {

                case 0:
                {
                    MultiChoiceQuestion question = controller.CreateMutliChoiceQuestion();

                    controller.AddAnswer(AnswerInput1.Text);
                    controller.AddAnswer(AnswerInput2.Text);
                    controller.AddAnswer(AnswerInput3.Text);
                    controller.AddAnswer(AnswerInput4.Text);

                    if (IsMultiChoiceQuestionValid()) 
                    {
                        question.Answers = controller.GetAnswers();
                        question.Content = controller.QuestionContent;
                        question.CorrectAnswer = controller.CorrectAnswer;

                        controller.SetQuestion(question);
                        ResetQuestionInputs();
                    }

                    break;
                }

                case 1:
                {
                    TFQuestion question = new TFQuestion();


                    break;
                }

                case 2:
                {
                    OpenEndedQuestion question = new OpenEndedQuestion();
                    
       
                    break;
                }

                default:
                {
                    MessageBox.Show("No question type chosen");
                    break;
                }
            }
        }
    }
}
