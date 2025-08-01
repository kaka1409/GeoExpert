using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeoExpert.controllers;
using GeoExpert.models;

namespace GeoExpert.views.create
{
    public partial class EditQuestionScene : UserControl
    {
        private QuestionController questionController;
        public QuestionController QuestionController
        {
            get { return questionController; }
            set { questionController = value; }
        }

        public EditQuestionScene()
        {
            InitializeComponent();
        }
        private void QuestionInput_TextChanged(object sender, EventArgs e)
        {
            questionController.QuestionContent = QuestionInput.Text.Trim();
        }

        // Multi choice
        private void Radio1_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswerIndicator.Top = Radio1.Location.Y;
            this.questionController.CorrectAnswer = 0;
        }

        private void Radio2_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswerIndicator.Top = Radio2.Location.Y;
            this.questionController.CorrectAnswer = 1;
        }

        private void Radio3_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswerIndicator.Top = Radio3.Location.Y;
            this.questionController.CorrectAnswer = 2;
        }

        private void Radio4_CheckedChanged(object sender, EventArgs e)
        {
            CorrectAnswerIndicator.Top = Radio4.Location.Y;
            this.questionController.CorrectAnswer = 3;
        }

        private void QuestionTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int questionTypeIndex = QuestionTypeCB.SelectedIndex;
            switch (questionTypeIndex)
            {
                case 0:
                    {
                        QuestionTypeTab.SelectTab(questionTypeIndex);
                        questionController.QuestionType = QuestionType.MultipleChoice;
                        break;
                    }

                case 1:
                    {
                        QuestionTypeTab.SelectTab(questionTypeIndex);
                        questionController.QuestionType = QuestionType.TrueFalse;
                        break;
                    }


                case 2:
                    {
                        QuestionTypeTab.SelectTab(questionTypeIndex);
                        questionController.QuestionType = QuestionType.OpenEnded;
                        break;
                    }


                default:
                    {
                        QuestionTypeTab.SelectTab(EmptyPage);
                        break;
                    }
            }
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

            if (questionController.CorrectAnswer == -1)
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

        // True false
        private void TrueRadio_CheckedChanged(object sender, EventArgs e)
        {
            TFCorrectIndicatior.Top = TrueRadio.Location.Y;
            this.questionController.CorrectAnswer = 0;
        }

        private void FalseRadio_CheckedChanged(object sender, EventArgs e)
        {
            TFCorrectIndicatior.Top = FalseRadio.Location.Y;
            this.questionController.CorrectAnswer = 1;
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

            if (questionController.CorrectAnswer == -1)
            {
                MessageBox.Show("Please select the correct answer for your question");
                return false;
            }

            return true;
        }

        // Open-ended
        private void AddAnswerButton_Click(object sender, EventArgs e)
        {
            string answer = AnswerInput.Text.Trim();

            if (answer == "") MessageBox.Show("Please don't leave answer input empty");

            if (!AnswerList.Items.Contains(answer))
            {
                AnswerList.Items.Add(answer);
                AnswerInput.Clear();
            }
            else
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

        private void EditQuestionScene_Load(object sender, EventArgs e)
        {
            QuestionTypeCB.Items.AddRange(new string[] { "Multiple Choice", "True/False", "Open-ended" });
            QuestionTypeTab.MakeTransparent();
        }

        public void ResetQuestionInputs()
        {
            // Reset controller's states
            questionController.ClearAllAnswers();
            questionController.CorrectAnswer = -1;
            questionController.QuestionContent = "";
            questionController.SelectedQuestion = null;

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

        public void UpdateWidgetInfo()
        {
            dynamic question = this.QuestionController.SelectedQuestion;

            if (question != null)
            {
                // Update widget info bases on question type
                switch (question.Type)
                {
                    case QuestionType.MultipleChoice:
                        QuestionTypeCB.SelectedIndex = 0;

                        switch (question.CorrectAnswer)
                        {
                            case 0:
                                Radio1.Checked = true;
                                break;

                            case 1:
                                Radio2.Checked = true;
                                break;

                            case 2:
                                Radio3.Checked = true;
                                break;

                            case 3:
                                Radio4.Checked = true;
                                break;

                            default:
                                MessageBox.Show("No correct answer retreived");
                                break;
                        }

                        AnswerInput1.Text = question.Answers[0];
                        AnswerInput2.Text = question.Answers[1];
                        AnswerInput3.Text = question.Answers[2];
                        AnswerInput4.Text = question.Answers[3];
                        break;

                    case QuestionType.TrueFalse:
                        QuestionTypeCB.SelectedIndex = 1;

                        // Update correct answer radio
                        switch (question.CorrectAnswer)
                        {
                            case 0:
                                TrueRadio.Checked = true;
                                break;

                            case 1:
                                FalseRadio.Checked = true;
                                break;

                            default:
                                MessageBox.Show("No correct answer retrived");
                                break;
                        }
                        break;

                    case QuestionType.OpenEnded:
                        QuestionTypeCB.SelectedIndex = 2;

                        foreach (string answer in question.CorrectAnswers)
                        {
                            AnswerList.Items.Add(answer);
                        }
                        break;

                    default:
                        QuestionTypeCB.SelectedIndex = -1;
                        break;
                }

                // Question content
                QuestionInput.Text = question.Content;

            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            switch (questionController.QuestionType)
            {

                case QuestionType.MultipleChoice:
                    {
                        MultiChoiceQuestion question = (MultiChoiceQuestion)questionController.SelectedQuestion;

                        questionController.AddAnswer(AnswerInput1.Text.Trim());
                        questionController.AddAnswer(AnswerInput2.Text.Trim());
                        questionController.AddAnswer(AnswerInput3.Text.Trim());
                        questionController.AddAnswer(AnswerInput4.Text.Trim());

                        if (IsMultiChoiceQuestionValid())
                        {
                            question.Answers = questionController.GetAnswers();
                            question.Content = questionController.QuestionContent;
                            question.CorrectAnswer = questionController.CorrectAnswer;

                            questionController.Question = question;
                            ResetQuestionInputs();
                        }

                        break;
                    }

                case QuestionType.TrueFalse:
                    {
                        TFQuestion question = (TFQuestion)questionController.SelectedQuestion;

                        questionController.AddAnswer(TrueLabel.Text);
                        questionController.AddAnswer(FalseLabel.Text);

                        if (IsTrueFalseQuestionValid())
                        {
                            question.Answers = questionController.GetAnswers();
                            question.Content = questionController.QuestionContent;
                            question.CorrectAnswer = questionController.CorrectAnswer;

                            questionController.Question = question;
                            ResetQuestionInputs();
                        }

                        break;
                    }

                case QuestionType.OpenEnded:
                    {
                        OpenEndedQuestion question = (OpenEndedQuestion)questionController.SelectedQuestion;
            
                        if (IsOpenEndedQuestionvalid())
                        {
                            question.Content = questionController.QuestionContent;
                            foreach (string answer in AnswerList.Items)
                            {
                                question.CorrectAnswers.Add(answer);
                            }

                            questionController.Question = question;
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
