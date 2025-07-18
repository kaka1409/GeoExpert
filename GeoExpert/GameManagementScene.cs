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

namespace GeoExpert
{
    partial class GameManagementScene : UserControl
    {
        private Game currentGame;
        public Game CurrentGame { get; set; }

        public GameManagementScene()
        {
            InitializeComponent();
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
            GameTitle.Text = CurrentGame.Title + "'s questions";
        }

        public void ListQuestion()
        {
            QuestionList.Items.Clear();

            foreach (Question question in CurrentGame.Questions)
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
                CurrentGame.RemoveQuestion(QuestionList.SelectedIndex);
                QuestionList.Items.Remove(QuestionList.SelectedItem);
            }
        }
    }
}
