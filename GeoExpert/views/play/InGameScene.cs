using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeoExpert.models;
using GeoExpert.controllers;
using GeoExpert.Utils;

namespace GeoExpert.Views.Play
{
    partial class InGameScene : UserControl
    {
        private GameController gameController;
        public GameController GameController
        {
            get { return gameController; }
            set { gameController = value; }
        }

        public InGameScene()
        {
            InitializeComponent();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameController.ElapsedTime = gameController.ElapsedTime.Add(TimeSpan.FromSeconds(1));

            TimeLabel.Text = gameController.ElapsedTime.ToString(@"mm\:ss");
        }

        private void QuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuestionList.SelectedIndex != -1)
            {

                dynamic? question = gameController.GetQuestionByIndex(QuestionList.SelectedIndex);

                if (question != null)
                {
                    // Update gamecontroller's states
                    gameController.SelectedIndex = QuestionList.SelectedIndex;
                    gameController.CurrentQuestion = question;

                    // Update text on widgets
                    QuestionContent.Text = question.Content;
                    NumberIndicator.Text = $"Question {QuestionList.SelectedIndex + 1}: {ViewHelper.FormatQuestionType(question.Type)}";
                    QuestionNumerLabel.Text = $"{QuestionList.SelectedIndex + 1}/{gameController.CurrentGame.Questions.Count}";

                    // select correct tab for question type
                    switch (question.Type)
                    {
                        case QuestionType.MultipleChoice:
                            {
                                QuestionTypeTab.SelectTab(MultiChoicePage);

                                Answer1Label.Text = question.Answers[0];
                                Answer2Label.Text = question.Answers[1];
                                Answer3Label.Text = question.Answers[2];
                                Answer4Label.Text = question.Answers[3];

                                if (question.UserAnswer != null)
                                {
                                    switch (question.UserAnswer)
                                    {
                                        case 0:
                                            {
                                                Radio1.Checked = true;
                                                break;
                                            }
                                        case 1:
                                            {
                                                Radio2.Checked = true;
                                                break;
                                            }

                                        case 2:
                                            {
                                                Radio3.Checked = true;
                                                break;
                                            }

                                        case 3:
                                            {
                                                Radio4.Checked = true;
                                                break;
                                            }
                                    }
                                }

                                break;
                            }
                            ;

                        case QuestionType.TrueFalse:
                            {
                                QuestionTypeTab.SelectTab(TrueFalsePage);

                                if (question.UserAnswer != null)
                                {
                                    switch (question.UserAnswer)
                                    {
                                        case 0:
                                            {
                                                TrueRadio.Checked = true;
                                                break;
                                            }

                                        case 1:
                                            {
                                                FalseRadio.Checked = true;
                                                break;
                                            }
                                    }
                                }
                                break;
                            };

                        case QuestionType.OpenEnded:
                            {
                                QuestionTypeTab.SelectTab(OpenEndedPage);

                                if (question.UserAnswer != null) AnswerInput.Text = question.UserAnswer;
                                break;
                            };
                    }

                    SubmitButton.Enabled = QuestionList.SelectedIndex == QuestionList.Items.Count - 1;
                    SubmitButton.Visible = QuestionList.SelectedIndex == QuestionList.Items.Count - 1;
                }
                else
                {
                    MessageBox.Show("Error get current question");
                }
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            if (QuestionList.SelectedIndex < QuestionList.Items.Count - 1)
            {
                QuestionList.SelectedIndex++;
            }
            else
            {
                QuestionList.SelectedIndex = 0;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (QuestionList.SelectedIndex > 0)
            {
                QuestionList.SelectedIndex--;
            }
            else
            {
                QuestionList.SelectedIndex = QuestionList.Items.Count - 1;
            }
        }

        private void InGameScene_Load(object sender, EventArgs e)
        {
            QuestionTypeTab.MakeTransparent();
            gameController.ElapsedTime = TimeSpan.Zero;
        }

        // Multichoice question
        private void Radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (!gameController.IsGameFinished)
            {
                AnswerIndicator.Top = Radio1.Location.Y;
                gameController.CurrentQuestion.UserAnswer = 0;
                gameController.SetQuestionByIndex(QuestionList.SelectedIndex, gameController.CurrentQuestion);
            }

        }

        private void Radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (!gameController.IsGameFinished)
            {
                AnswerIndicator.Top = Radio2.Location.Y;
                gameController.CurrentQuestion.UserAnswer = 1;
                gameController.SetQuestionByIndex(QuestionList.SelectedIndex, gameController.CurrentQuestion);
            }

        }

        private void Radio3_CheckedChanged(object sender, EventArgs e)
        {
            if (!gameController.IsGameFinished)
            {
                AnswerIndicator.Top = Radio3.Location.Y;
                gameController.CurrentQuestion.UserAnswer = 2;
                gameController.SetQuestionByIndex(QuestionList.SelectedIndex, gameController.CurrentQuestion);
            }
        }

        private void Radio4_CheckedChanged(object sender, EventArgs e)
        {
            if (!gameController.IsGameFinished)
            {
                AnswerIndicator.Top = Radio4.Location.Y;
                gameController.CurrentQuestion.UserAnswer = 3;
                gameController.SetQuestionByIndex(QuestionList.SelectedIndex, gameController.CurrentQuestion);
            }

        }


        // True/false questiom
        private void TrueRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!gameController.IsGameFinished)
            {
                TrueFalseAnswerIndicator.Top = TrueRadio.Location.Y;
                gameController.CurrentQuestion.UserAnswer = 0;
                gameController.SetQuestionByIndex(QuestionList.SelectedIndex, gameController.CurrentQuestion);
            }

        }

        private void FalseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!gameController.IsGameFinished)
            {
                TrueFalseAnswerIndicator.Top = FalseRadio.Location.Y;
                gameController.CurrentQuestion.UserAnswer = 1;
                gameController.SetQuestionByIndex(QuestionList.SelectedIndex, gameController.CurrentQuestion);
            }

        }

        // Open-ended
        private void AnswerInput_TextChanged(object sender, EventArgs e)
        {
            if (!gameController.IsGameFinished)
            {
                gameController.CurrentQuestion.UserAnswer = AnswerInput.Text.Trim();
                gameController.SetQuestionByIndex(QuestionList.SelectedIndex, gameController.CurrentQuestion);
            }
        }

        private void QuestionListButton_Click(object sender, EventArgs e)
        {
            QuestionList.Visible = !QuestionList.Visible;
        }

        public void ListAllQuestions()
        {
            int index = 1;
            QuestionList.Items.Clear();

            foreach (dynamic question in gameController.CurrentPlayGame.Questions)
            {
                QuestionList.Items.Add($"{index}. [{ViewHelper.FormatQuestionType(question.Type)}] {question.Content}");
                index++;
            }

            QuestionList.SelectedIndex = 0; // default
        }

        public void UpdateWidgetInfo()
        {
            ListAllQuestions();
            gameTimer.Start();
            gameController.ClearAllUserAnswer();    
        }

        public void ResetAllInfo()
        {
            // Reset Widget's info
            QuestionList.Items.Clear();
            QuestionList.Visible = false;

            Answer1Label.Text = "";
            Answer2Label.Text = "";
            Answer3Label.Text = "";
            Answer4Label.Text = "";

            Radio1.Checked = false;
            Radio2.Checked = false;
            Radio3.Checked = false;
            Radio4.Checked = false;

            TrueRadio.Checked = false;
            FalseRadio.Checked = false;

            AnswerInput.Text = "";

            gameTimer.Stop();
            TimeLabel.Text = "00:00";
            gameController.TimeTaken = gameController.ElapsedTime;
            gameController.ElapsedTime = TimeSpan.Zero;
            QuestionNumerLabel.Text = "0/0";

            QuestionTypeTab.SelectTab(EmptyPage);

            // Controller's state
            //gameController.ClearAllUserAnswer();
        }

        // Submit
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            gameController.IsGameFinished = true;
            ResetAllInfo();
            gameController.IsGameFinished = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            gameController.IsGameFinished = true;
            ResetAllInfo();
            gameController.IsGameFinished = false;
        }
    }
}
