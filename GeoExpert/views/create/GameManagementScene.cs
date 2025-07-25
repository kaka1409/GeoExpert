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

using GeoExpert.controllers;
using GeoExpert.models;

namespace GeoExpert.views.create
{

    partial class GameManagementScene : UserControl
    {
        private GameController controller;
        private Game currentGame;

        public GameManagementScene()
        {
            InitializeComponent();
            InitilizeController();
        }

        private void InitilizeController()
        {
            this.controller = new GameController();
        }

        public void SetCurrentGame(Game game)
        {
            this.currentGame = game;
        }

        public Game GetCurrentGame()
        {
            return this.currentGame;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GameManagementScene_Load(object sender, EventArgs e)
        {

        }

        public void UpdateWidgetInfo()
        {
            SetGameTitle();
            ListQuestion();
        }

        public void SetGameTitle()
        {
            GameTitle.Text = currentGame.Title + "'s questions";
        }

        public void ListQuestion()
        {
            QuestionList.Items.Clear();

            foreach (Question question in currentGame.Questions)
            {
                if (question != null)
                {
                    QuestionList.Items.Add($"[{question.Type}] {question.Content}");
                }
            }
        }

        private void DeleteQuestionBtn_Click(object sender, EventArgs e)
        {
            if (QuestionList.SelectedItem != null)
            {
                //MessageBox.Show(QuestionList.SelectedIndex.ToString());
                currentGame.RemoveQuestion(QuestionList.SelectedIndex);
                QuestionList.Items.Remove(QuestionList.SelectedItem);
            }
        }
    }
}
