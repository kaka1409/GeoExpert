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
using GeoExpert.Views.Widget.Custom;

namespace GeoExpert.views.create
{
    partial class QuestionManagementScene : UserControl
    {
        private QuestionController controller;
        public QuestionController Controller
        {
            get { return controller; }
            set { controller = value; }
        }

        public QuestionManagementScene()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(controller.QuestionType.ToString());

            int questionTypeIndex = QuestionTypeCB.SelectedIndex;
            switch (questionTypeIndex)
            {
                case 0:
                    {
                        QuestionTypeTab.SelectTab(questionTypeIndex);
                        controller.QuestionType = QuestionType.MultipleChoice;
                        break;
                    }

                case 1:
                    {
                        QuestionTypeTab.SelectTab(questionTypeIndex);
                        controller.QuestionType = QuestionType.TrueFalse;
                        break;
                    }


                case 2:
                    {
                        QuestionTypeTab.SelectTab(questionTypeIndex);
                        controller.QuestionType = QuestionType.OpenEnded;
                        break;
                    }


                default:
                    {
                        //MessageBox.Show(questionTypeIndex.ToString());
                        break;
                    }
            }
        }

        private void QuestionManagementScene_Load(object sender, EventArgs e)
        {
            QuestionTypeCB.Items.AddRange(new string[] { "Multiple Choice", "True/False", "Open-ended" });
            QuestionTypeTab.MakeTransparent();
        }

        private void MultiChoicePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.controller.QuestionContent = QuestionInput.Text;
        }

        // Multichoice 

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

        public void ResetQuestionInputs()
        {
            // Reset controller's states
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
            AnswerList.Items.Clear();

            // Unchecked all radios
            Radio1.Checked = false;
            Radio2.Checked = false;
            Radio3.Checked = false;
            Radio4.Checked = false;
            TrueRadio.Checked = false;
            FalseRadio.Checked = false;
        }

        // True false
        private void TrueRadio_CheckedChanged(object sender, EventArgs e)
        {
            TFCorrectIndicatior.Top = TrueRadio.Location.Y;
            this.controller.CorrectAnswer = 0;
        }

        private void FalseRadio_CheckedChanged(object sender, EventArgs e)
        {
            TFCorrectIndicatior.Top = FalseRadio.Location.Y;
            this.controller.CorrectAnswer = 1;
        }

        private bool IsTrueFalseQuestionValid()
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

            return true;
        }

        // Open ended
        private void AddAnswerButton_Click(object sender, EventArgs e)
        {
            string answer = AnswerInput.Text.Trim();

            if (answer == "") MessageBox.Show("Please don't leave answer input empty");  

            if (!AnswerList.Items.Contains(answer))
            {
                AnswerList.Items.Add(answer);
                AnswerInput.Clear();
            } else
            {
                MessageBox.Show("This answer already exist");
            }
        }

        private void RemoveAnswerButton_Click(object sender, EventArgs e)
        {
            int removeIndex = AnswerList.SelectedIndex;
            AnswerList.Items.RemoveAt(removeIndex);
        }

        private bool IsOpenEndedQuestionvalid()
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

            if (AnswerList.Items.Count == 0)
            {
                MessageBox.Show("Open-Ended question need to have at least 1 answer");
                return false;
            }

            return true;
        }

        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            switch (controller.QuestionType)
            {

                case QuestionType.MultipleChoice:
                    {
                        MultiChoiceQuestion question = new MultiChoiceQuestion();

                        controller.AddAnswer(AnswerInput1.Text.Trim());
                        controller.AddAnswer(AnswerInput2.Text.Trim());
                        controller.AddAnswer(AnswerInput3.Text.Trim());
                        controller.AddAnswer(AnswerInput4.Text.Trim());

                        if (IsMultiChoiceQuestionValid())
                        {
                            question.Answers = controller.GetAnswers();
                            question.Content = controller.QuestionContent;
                            question.CorrectAnswer = controller.CorrectAnswer;

                            controller.Question = question;
                            ResetQuestionInputs();
                        }

                        break;
                    }

                case QuestionType.TrueFalse:
                    {
                        TFQuestion question = new TFQuestion();

                        controller.AddAnswer(TrueLabel.Text);
                        controller.AddAnswer(FalseLabel.Text);

                        if (IsTrueFalseQuestionValid())
                        {
                            question.Answers = controller.GetAnswers();
                            question.Content = controller.QuestionContent;
                            question.CorrectAnswer = controller.CorrectAnswer;

                            controller.Question = question;
                            ResetQuestionInputs();
                        }

                        break;
                    }

                case QuestionType.OpenEnded:
                    {
                        OpenEndedQuestion question = new OpenEndedQuestion();

                        if (IsOpenEndedQuestionvalid())
                        {
                            question.Content = controller.QuestionContent;
                            foreach (string answer in AnswerList.Items)
                            {
                                question.CorrectAnswers.Add(answer);
                            }

                            controller.Question = question;
                            ResetQuestionInputs();
                        }

                        break;
                    }

                default:
                    {
                        MessageBox.Show("Invalid question type");
                        break;
                    }
            }

        }

    }
}
