using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoExpert
{
    partial class QuestionManagementScene : UserControl
    {
        

        public QuestionManagementScene()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuestionManagementScene_Load(object sender, EventArgs e)
        {
            QuestionTypeCB.Items.AddRange(new string[] { "Multiple Choice", "True/False", "Open-ended" });
        }
    }
}
